using DatabaseSync.Models.Target;

namespace DatabaseSync.ViewModels
{
    public class DataSyncVM
    {
        public int SyncInterval { get; set; } // In seconds
        public List<TargetCustomer> Customers { get; set; }
    }
}
