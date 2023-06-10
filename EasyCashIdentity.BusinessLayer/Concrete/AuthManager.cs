using Microsoft.AspNetCore.Identity;
using EasyCashIdentity.EntityLayer.Dtos;
using EasyCashIdentity.EntityLayer.Concrete;
using EasyCashIdentity.BusinessLayer.Abstract;

namespace EasyCashIdentity.BusinessLayer.Concrete
{
    public class AuthManager : IAuthService
    {
        private readonly IMailService _mailService;
        private readonly IUserService _userService;

        public AuthManager(IMailService mailService, IUserService userService)
        {
            _mailService = mailService;
            _userService = userService;
        }

        public async Task<IdentityResult> ConfirmEmail(ConfirmEmailDto confirmEmailDto)
        {
            var user = _userService.FindByEmailAsync(confirmEmailDto.Email).Result;
            if (user.ConfirmCode == confirmEmailDto.ConfirmCode)
            {
                user.EmailConfirmed = true;
                var result = await _userService.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return result;
                }
            }
            return null;
        }

        public async Task<SignInResult> Login(string email, string password, bool isPersistent, bool lockoutOnFailure)
        {
            var result = await _userService.PasswordSignInAsync(email, password, isPersistent, lockoutOnFailure);
            if (result.Succeeded)
            {
                var user = await _userService.FindByEmailAsync(email);
                if (user.EmailConfirmed)
                {
                    return result;
                }
            }
            return null;
        }

        public async Task<IdentityResult> Register(AppUserRegisterDto appUserRegisterDto, string password)
        {
            Random random = new();
            int confirmCode = random.Next(100000, 1000000);
            var appUser = new AppUser
            {
                Name = appUserRegisterDto.Name,
                Surname = appUserRegisterDto.Surname,
                UserName = appUserRegisterDto.Username,
                Email = appUserRegisterDto.Email,
                ConfirmCode = confirmCode,
                Status = true
            };
            var result = await _userService.CreateAsync(appUser, appUserRegisterDto.Password);
            if (result.Succeeded)
            {
                _mailService.SendConfirmCodeToUser(appUserRegisterDto.Email, confirmCode);
                return result;
            }
            return null;
        }
    }
}