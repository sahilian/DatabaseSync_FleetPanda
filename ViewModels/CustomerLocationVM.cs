using System.ComponentModel.DataAnnotations;

namespace DatabaseSync.ViewModels
{
    public class CustomerLocationVM
    {
        // Customer details
        [Required]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }

        // Location details
        public List<string> Addresses { get; set; } = new List<string>(); // List to hold multiple addresses

        public DateTime LastModified { get; set; } = DateTime.Now;
    }
}
