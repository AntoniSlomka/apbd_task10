using apbdtask10_v2.Data;
using apbdtask10_v2.DTOs;
using Microsoft.EntityFrameworkCore;

namespace apbdtask10_v2.Service
{
    public class AppUserService : IAppUserService
    {

        private readonly DatabaseContext _databaseContext;

        public AppUserService(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<List<AppUserDTO>> GetAppUsers()
        {
            return await _databaseContext.Users
                .Select(u => new AppUserDTO
                {
                    Username = u.UserName!,
                    NoteCout = _databaseContext.UserNotes.Where(n => n.AppUserId == u.Id).Count(),
                    CreatedAt = u.CreatedAt
                })
                .ToListAsync();
        }

    }
}
