using Microsoft.AspNetCore.Identity;
using EasyCashIdentity.EntityLayer.Concrete;

namespace EasyCashIdentity.BusinessLayer.Abstract
{
    public interface IUserService
    {
        Task<AppUser> FindByEmailAsync(string email);
        Task<IdentityResult> UpdateAsync(AppUser appUser);
        Task<IdentityResult> CreateAsync(AppUser appUser, string password);
        Task<SignInResult> PasswordSignInAsync(string email, string password, bool isPersistent, bool lockoutOnFailure);
    }
}