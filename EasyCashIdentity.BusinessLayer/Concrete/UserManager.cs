using Microsoft.AspNetCore.Identity;
using EasyCashIdentity.EntityLayer.Concrete;
using EasyCashIdentity.BusinessLayer.Abstract;

namespace EasyCashIdentity.BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        private readonly UserManager<AppUser> _userManager;

        public UserManager(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
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
    }
}