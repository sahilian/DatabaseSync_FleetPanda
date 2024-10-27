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
                    LastModified = DateTime.Now, // Set to current time
                    Locations = new List<SourceLocation>()
                };

                // Loop through each address in the Addresses list and create a SourceLocation
                foreach (var address in model.Addresses)
                {
                    customer.Locations.Add(new SourceLocation
                    {
                        Address = address,
                        LastModified = DateTime.Now // Set to current time
                    });
                }

                _sourceDb.Customers.Add(customer);
                await _sourceDb.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return View(model);
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var customer = await _sourceDb.Customers
                .Include(c => c.Locations)
                .FirstOrDefaultAsync(c => c.CustomerID == id);

            if (customer == null)
            {
                return NotFound();
            }

            var model = new CustomerLocationVM
            {
                Name = customer.Name,
                Email = customer.Email,
                Phone = customer.Phone,
                Addresses = customer.Locations.Select(l => l.Address).ToList()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CustomerLocationVM model, int id)
        {
            if (ModelState.IsValid)
            {
                var customer = await _sourceDb.Customers
                    .Include(c => c.Locations)
                    .FirstOrDefaultAsync(c => c.CustomerID == id);

                if (customer != null)
                {
                    customer.Name = model.Name;
                    customer.Email = model.Email;
                    customer.Phone = model.Phone;
                    customer.LastModified = DateTime.Now;
                    // Clear existing locations and add updated ones
                    customer.Locations.Clear();
                    foreach (var address in model.Addresses)
                    {
                        customer.Locations.Add(new SourceLocation
                        {
                            Address = address,
                            LastModified = DateTime.Now
                        });
                    }

                    await _sourceDb.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var customer = await _sourceDb.Customers.FindAsync(id);
            if (customer != null)
            {
                _sourceDb.Customers.Remove(customer);
                await _sourceDb.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return NotFound();
        }
    }
}
