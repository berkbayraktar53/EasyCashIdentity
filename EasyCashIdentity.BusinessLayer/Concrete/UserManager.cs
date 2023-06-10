using Microsoft.AspNetCore.Identity;
using EasyCashIdentity.EntityLayer.Concrete;
using EasyCashIdentity.BusinessLayer.Abstract;

namespace EasyCashIdentity.BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public UserManager(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public Task<IdentityResult> CreateAsync(AppUser appUser, string password)
        {
            return _userManager.CreateAsync(appUser, password);
        }

        public Task<AppUser> FindByEmailAsync(string email)
        {
            return _userManager.FindByEmailAsync(email);
        }

        public Task<IdentityResult> UpdateAsync(AppUser appUser)
        {
            return _userManager.UpdateAsync(appUser);
        }

        public Task<SignInResult> PasswordSignInAsync(string email, string password, bool isPersistent, bool lockoutOnFailure)
        {
            return _signInManager.PasswordSignInAsync(email, password, isPersistent, lockoutOnFailure);
        }
    }
}