using apbdtask10_v2.DTOs;
using apbdtask10_v2.Models;

namespace apbdtask10_v2.Service
{
    public interface IUserNoteService
    {
        Task<List<UserNoteDTO>> GetAllUserNotes(string userId);

        Task AddNote(UserNote note);
    }
}
