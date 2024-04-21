using Domain.Models.Account;
using Domain.Response;
using System.Security.Claims;

namespace BusinessLogic.Interfaces
{
    public interface IAccountBL
    {
        Task<BaseResponse<ClaimsIdentity>> Register(RegisterViewModel model);

        Task<BaseResponse<ClaimsIdentity>> Login(LoginViewModel model);

        Task<BaseResponse<bool>> ChangePassword(ChangePasswordViewModel model);
    }
}