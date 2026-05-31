using apbdtask10_v2.Data;
using apbdtask10_v2.DTOs;
using apbdtask10_v2.Models;
using Microsoft.EntityFrameworkCore;

namespace apbdtask10_v2.Service
{
    public class UserNoteService : IUserNoteService
    {

        private readonly DatabaseContext _databaseContext;

        public UserNoteService(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<List<UserNoteDTO>> GetAllUserNotes(string userId)
        {
            return await _databaseContext.UserNotes
                .Where(n => n.AppUserId == userId)
                .Select(n => new UserNoteDTO
                {
                    Title = n.Title,
                    Content = n.Content,
                    CreatedAt = n.CreatedAt
                }).ToListAsync();
        }

        public async Task AddNote(UserNote note)
        {
            await _databaseContext.UserNotes.AddAsync(note);
            await _databaseContext.SaveChangesAsync();
        }
    }
}
