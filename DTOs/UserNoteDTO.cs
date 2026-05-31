namespace apbdtask10_v2.DTOs
{
    public class UserNoteDTO
    {
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
