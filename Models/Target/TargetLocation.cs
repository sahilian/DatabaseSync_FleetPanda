using System.ComponentModel.DataAnnotations;

namespace DatabaseSync.Models.Target
{
    public class TargetLocation
    {
        [Key]
        public int LocationID { get; set; }
        public int CustomerID { get; set; }
        public string Address { get; set; }
        public DateTime LastModified { get; set; }

        public virtual TargetCustomer Customer { get; set; }
    }
}
