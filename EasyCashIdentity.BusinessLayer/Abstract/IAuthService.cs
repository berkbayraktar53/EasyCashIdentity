using Microsoft.AspNetCore.Identity;
using EasyCashIdentity.EntityLayer.Dtos;

namespace EasyCashIdentity.BusinessLayer.Abstract
{
    public interface IAuthService
    {
        Task<IdentityResult> ConfirmEmail(ConfirmEmailDto confirmEmailDto);
        Task<IdentityResult> Register(AppUserRegisterDto appUserRegisterDto, string password);
        Task<SignInResult> Login(string email, string password, bool isPersistent, bool lockoutOnFailure);
    }
}