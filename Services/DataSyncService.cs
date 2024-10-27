using DatabaseSync.Data;
using DatabaseSync.Models.Source;
using DatabaseSync.Models.Target;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace DatabaseSync.Services
{
    public class DataSyncService
    {
        private readonly SourceDbContext _sourceDb;
        private readonly TargetDbContext _targetDb;

        public DataSyncService(SourceDbContext sourceDb, TargetDbContext targetDb)
        {
            _sourceDb = sourceDb;
            _targetDb = targetDb;
        }

        public void SyncData(DateTime lastSyncTime)
        {
            var sourceCustomers = _sourceDb.Customers
                .Include(c => c.Locations)
                .ToList();

            bool isTargetEmpty = !_targetDb.Customers.Any();

            if (isTargetEmpty)
            {
                foreach (var sourceCustomer in sourceCustomers)
                {
                    var newCustomer = MapSourceToTargetCustomer(sourceCustomer);
                    newCustomer.LastModified = DateTime.Now;
                    _targetDb.Customers.Add(newCustomer);

                    SyncLocations(sourceCustomer.Locations, newCustomer.Locations, newCustomer.CustomerID);
                    LogSyncDetails($"New customer added: {sourceCustomer.CustomerID}, {sourceCustomer.Name}");
                }
            }
            else
            {
                var updatedCustomers = sourceCustomers
                    .Where(c => c.LastModified > lastSyncTime)
                    .ToList();

                if (updatedCustomers.Count() == 0)
                {
                    foreach (var sourceCustomer in sourceCustomers)
                    {
                        var targetCustomerIds = _targetDb.Customers
                            .Select(c => c.CustomerID)
                            .ToList();

                        var customersNotInTarget = _sourceDb.Customers
                            .Where(c => !targetCustomerIds.Contains(c.CustomerID))
                            .Include(c => c.Locations)
                            .ToList();

                        var targetCustomer = MapSourceToTargetCustomers(customersNotInTarget);

                        _targetDb.Customers.AddRange(targetCustomer);

                        foreach (var customer in targetCustomer)
                        {
                            SyncLocations(sourceCustomer.Locations, customer.Locations, customer.CustomerID);
                            LogSyncDetails($"New customer added: {sourceCustomer.CustomerID}, {sourceCustomer.Name}");
                        }



                    }
                }
                foreach (var sourceCustomer in updatedCustomers)
                {
                    var targetCustomer = _targetDb.Customers
                        .Include(c => c.Locations)
                        .FirstOrDefault(c => c.CustomerID == sourceCustomer.CustomerID);

                    if (targetCustomer == null)
                    {
                        var newCustomer = MapSourceToTargetCustomer(sourceCustomer);
                        newCustomer.LastModified = DateTime.Now;
                        _targetDb.Customers.Add(newCustomer);

                        SyncLocations(sourceCustomer.Locations, newCustomer.Locations, newCustomer.CustomerID);
                        LogSyncDetails($"New customer added: {sourceCustomer.CustomerID}, {sourceCustomer.Name}");
                    }
                    else
                    {
                        bool hasChanges = UpdateCustomerIfChanged(targetCustomer, sourceCustomer);
                        if (hasChanges)
                        {
                            targetCustomer.LastModified = DateTime.Now;
                            _targetDb.Customers.Update(targetCustomer);
                            LogSyncDetails($"Updated customer: {targetCustomer.CustomerID}, {targetCustomer.Name}");
                        }

                        SyncLocations(sourceCustomer.Locations, targetCustomer.Locations, sourceCustomer.CustomerID);
                    }
                }
            }
            var sourceCustomerIds = sourceCustomers.Select(c => c.CustomerID).ToHashSet();

            var targetCustomers = _sourceDb.Customers
                    .Include(c => c.Locations)
                    .ToList();

            var deletedCustomers = targetCustomers
                .Where(tc => !sourceCustomerIds.Contains(tc.CustomerID))
                .ToList();

            foreach (var deletedCustomer in deletedCustomers)
            {
                var deletedCustomerMapped = MapSourceToTargetCustomer(deletedCustomer);
                _targetDb.Customers.Remove(deletedCustomerMapped);
                LogSyncDetails($"Deleted customer: {deletedCustomer.CustomerID}, {deletedCustomer.Name}");
            }


            _targetDb.SaveChanges();
        }



        private bool UpdateCustomerIfChanged(TargetCustomer targetCustomer, SourceCustomer sourceCustomer)
        {
            bool hasChanges = false;
            if (sourceCustomer.Name != targetCustomer.Name)
            {
                Log.Information("Customer {CustomerID}: Name changed from '{OldName}' to '{NewName}'",
                                sourceCustomer.CustomerID, targetCustomer.Name, sourceCustomer.Name);
                targetCustomer.Name = sourceCustomer.Name;
                hasChanges = true;
            }
            return hasChanges;
        }

        private void SyncLocations(IEnumerable<SourceLocation> sourceLocations, ICollection<TargetLocation> targetLocations, int customerId)
        {
            foreach (var sourceLocation in sourceLocations)
            {
                var targetLocation = targetLocations.FirstOrDefault(l => l.LocationID == sourceLocation.LocationID);
                if (targetLocation == null)
                {
                    var newLocation = new TargetLocation
                    {
                        LocationID = sourceLocation.LocationID,
                        Address = sourceLocation.Address,
                        CustomerID = customerId,
                        LastModified = DateTime.Now
                    };

                    targetLocations.Add(newLocation);
                    LogSyncDetails($"New location added for CustomerID {customerId}: {sourceLocation.LocationID}, {sourceLocation.Address}");
                }
                else
                {
                    bool locationChanged = UpdateLocationIfChanged(targetLocation, sourceLocation);
                    if (locationChanged)
                    {
                        LogSyncDetails($"Updated location for CustomerID {customerId}: {targetLocation.LocationID}, {targetLocation.Address}");
                    }
                }
            }
        }
        private bool UpdateLocationIfChanged(TargetLocation targetLocation, SourceLocation sourceLocation)
        {
            bool hasChanges = false;

            if (targetLocation.Address != sourceLocation.Address)
            {
                Log.Information("Location {LocationID} for Customer {CustomerID}: Address changed from '{OldAddress}' to '{NewAddress}'",
                                targetLocation.LocationID, targetLocation.CustomerID, targetLocation.Address, sourceLocation.Address);
                targetLocation.Address = sourceLocation.Address;
                hasChanges = true;
            }

            if (hasChanges)
            {
                targetLocation.LastModified = DateTime.Now;
            }

            return hasChanges;
        }


        private void LogSyncDetails(string changes)
        {
            var syncLog = new SyncLog
            {
                SyncTime = DateTime.Now,
                Changes = changes
            };

            _targetDb.SyncLogs.Add(syncLog);
            _targetDb.SaveChanges();
        }



        public TargetCustomer MapSourceToTargetCustomer(SourceCustomer sourceCustomer)
        {
            return new TargetCustomer
            {
                CustomerID = sourceCustomer.CustomerID,
                Name = sourceCustomer.Name,
                Email = sourceCustomer.Email,
                Phone = sourceCustomer.Phone,
                Locations = sourceCustomer.Locations.Select(sourceLocation => new TargetLocation
                {
                    LocationID = sourceLocation.LocationID,
                    Address = sourceLocation.Address,
                    CustomerID = sourceCustomer.CustomerID,
                    LastModified = DateTime.Now
                }).ToList(),
                LastModified = DateTime.Now,
            };
        }

        public List<TargetCustomer> MapSourceToTargetCustomers(List<SourceCustomer> sourceCustomers)
        {
            var targetCustomers = new List<TargetCustomer>();

            foreach (var sourceCustomer in sourceCustomers)
            {
                var targetCustomer = new TargetCustomer
                {
                    CustomerID = sourceCustomer.CustomerID,
                    Name = sourceCustomer.Name,
                    Email = sourceCustomer.Email,
                    Phone = sourceCustomer.Phone,
                    LastModified = sourceCustomer.LastModified,

                    Locations = sourceCustomer.Locations.Select(sourceLocation => new TargetLocation
                    {
                        LocationID = sourceLocation.LocationID,
                        CustomerID = sourceLocation.CustomerID,
                        Address = sourceLocation.Address,
                        LastModified = sourceLocation.LastModified
                    }).ToList()
                };

                targetCustomers.Add(targetCustomer);
            }

            return targetCustomers;
        }

        public List<TargetCustomer> GetAllCustomers()
        {
            return _targetDb.Customers
                .Include(c => c.Locations)
                .ToList();
        }
    }
}
