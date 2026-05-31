using apbdtask10_v2.DTOs;

namespace apbdtask10_v2.Service
{
    public interface IAppUserService
    {

        Task<List<AppUserDTO>> GetAppUsers();

    }
}
