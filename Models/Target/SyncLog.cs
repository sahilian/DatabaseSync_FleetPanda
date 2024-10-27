using System.ComponentModel.DataAnnotations;

namespace DatabaseSync.Models.Target
{
    public class SyncLog
    {
        [Key]
        public int Id { get; set; }
        public DateTime SyncTime { get; set; }
        public string Changes { get; set; } 
    }
}
