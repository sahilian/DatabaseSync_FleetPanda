using System.ComponentModel.DataAnnotations;

namespace DatabaseSync.Models.Source
{
    public class SourceCustomer
    {
        [Key]
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime LastModified { get; set; } = DateTime.Now;

        public ICollection<SourceLocation> Locations { get; set; }
    }
}
