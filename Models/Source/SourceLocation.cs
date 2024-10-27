using System.ComponentModel.DataAnnotations;

namespace DatabaseSync.Models.Source
{
    public class SourceLocation
    {
        [Key]
        public int LocationID { get; set; }
        public int CustomerID { get; set; }
        public string Address { get; set; }
        public DateTime LastModified { get; set; } = DateTime.Now;

        public SourceCustomer Customer { get; set; }
    }
}
