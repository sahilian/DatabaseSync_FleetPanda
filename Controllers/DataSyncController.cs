using DatabaseSync.Data;
using DatabaseSync.Models.Source;
using DatabaseSync.Services;
using DatabaseSync.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatabaseSync.Controllers
{
    public class DataSyncController : Controller
    {
        private readonly DataSyncService _dataSyncService;
        private readonly TargetDbContext _targetDb;
        private readonly SourceDbContext _sourceDb;

        public DataSyncController(DataSyncService dataSyncService, TargetDbContext targetDb, SourceDbContext sourceDb)
        {
            _dataSyncService = dataSyncService;
            _targetDb = targetDb;
            _sourceDb = sourceDb;
        }

        public async Task<IActionResult> Index(int? syncInterval)
        {
            var customers = await _targetDb.Customers.Include(c => c.Locations).ToListAsync();

            var model = new DataSyncVM
            {
                SyncInterval = syncInterval ?? 60,         
                Customers = customers      
            };

            if (model.Customers == null || !model.Customers.Any())
            {
                ViewBag.Message = "No customers found.";
            }

            return View(model);    
        }


        [HttpPost]
        public IActionResult SyncData(int syncInterval)
        {
            var backgroundService = HttpContext.RequestServices.GetService<DataSyncBackgroundService>();
            backgroundService?.UpdateSyncInterval(syncInterval);

            DateTime lastSyncTime = DateTime.Now.AddSeconds(-syncInterval);
            _dataSyncService.SyncData(lastSyncTime);

            var model = new DataSyncVM
            {
                SyncInterval = syncInterval,
                Customers = _dataSyncService.GetAllCustomers()
            };

            return View("Index", model);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View(new CustomerLocationVM());
        }

        [HttpPost]
        public async Task<IActionResult> Create(CustomerLocationVM model)
        {
            if (ModelState.IsValid)
            {
                var customer = new SourceCustomer
                {
                    Name = model.Name,
                    Email = model.Email,
                    Phone = model.Phone,
                    LastModified = model.LastModified,
                    Locations = new List<SourceLocation>
                {
                    new SourceLocation
                    {
                        Address = model.Address,
                        LastModified = model.LastModified
                    }
                }
                };

                _sourceDb.Customers.Add(customer);
                await _sourceDb.SaveChangesAsync();

                return RedirectToAction("Index");     
            }

            return View(model);       
        }
    }
}
