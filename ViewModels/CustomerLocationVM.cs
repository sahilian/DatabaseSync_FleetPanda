using System.ComponentModel.DataAnnotations;

namespace DatabaseSync.ViewModels
{
    public class CustomerLocationVM
    {
        // Customer details
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        // Location details
        public string Address { get; set; }
        public DateTime LastModified { get; set; } = DateTime.Now;
    }

}
