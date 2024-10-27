using System.ComponentModel.DataAnnotations;

namespace DatabaseSync.Models.Target
{
    public class TargetCustomer
    {
        [Key]
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime LastModified { get; set; }

        public ICollection<TargetLocation> Locations { get; set; }
    }
}
