using System.ComponentModel.DataAnnotations;

namespace apbdtask10_v2.ViewModels
{
    public class AddNoteViewModel
    {
        [Required]
        [StringLength(100, MinimumLength = 4)]
        public string Title { get; set; } = null!;

        [Required]
        public string Content { get; set; } = null!;

    }
}
