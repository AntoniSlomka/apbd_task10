using System.ComponentModel.DataAnnotations;

namespace apbdtask10_v2.Models
{
    public class UserNote
    {
        [Key]
        public int Id { get; set; }
        public string AppUserId { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public AppUser AppUser { get; set; } = null!;

    }
}
