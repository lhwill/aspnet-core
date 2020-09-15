using System.Threading.Tasks;
using Abp.Application.Services;
using StudentMS.Authorization.Accounts.Dto;

namespace StudentMS.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
