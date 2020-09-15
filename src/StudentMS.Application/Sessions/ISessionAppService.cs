using System.Threading.Tasks;
using Abp.Application.Services;
using StudentMS.Sessions.Dto;

namespace StudentMS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
