using NToastNotify;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using EasyCashIdentity.EntityLayer.Dtos;
using EasyCashIdentity.BusinessLayer.Abstract;
using EasyCashIdentity.BusinessLayer.ValidationRules.FluentValidation;
using Microsoft.AspNetCore.Identity;
using EasyCashIdentity.BusinessLayer.Concrete;

namespace EasyCashIdentity.WebUILayer.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;
        private readonly IToastNotification _toastNotification;

        public AuthController(IAuthService authService, IToastNotification toastNotification)
        {
            _authService = authService;
            _toastNotification = toastNotification;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserForLoginDto userForLoginDto)
        {
            var result = await _authService.Login(userForLoginDto.Email, userForLoginDto.Password, false, true);
            if (result.Succeeded)
            {
                _toastNotification.AddSuccessToastMessage("Giriş başarılı");
                return RedirectToAction("Index", "MyAccounts");
            }
            _toastNotification.AddErrorToastMessage("Kullanıcı adı veya şifre hatalı");
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(AppUserRegisterDto appUserRegisterDto)
        {
            AppUserRegisterValidator appUserRegisterValidator = new();
            ValidationResult validationResult = appUserRegisterValidator.Validate(appUserRegisterDto);
            if (validationResult.IsValid)
            {
                var result = await _authService.Register(appUserRegisterDto, appUserRegisterDto.Password);
                if (result.Succeeded)
                {
                    TempData["UserEmail"] = appUserRegisterDto.Email;
                    _toastNotification.AddInfoToastMessage("Mail adresinize gelen 6 haneli kodu giriniz");
                    return RedirectToAction("ConfirmMail", "Auth");
                }
                _toastNotification.AddErrorToastMessage("Onay kodu gönderilemedi");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View(appUserRegisterDto);
        }

        [HttpGet]
        public IActionResult ConfirmMail()
        {
            var userEmail = TempData["UserEmail"];
            ViewBag.userEmail = userEmail;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmMail(ConfirmEmailDto confirmEmailDto)
        {
            var user = await _authService.ConfirmEmail(confirmEmailDto);
            if (user != null)
            {
                _toastNotification.AddSuccessToastMessage("Başarılı bir şekilde kayıt oldunuz");
                return RedirectToAction("Login", "Auth");
            }
            _toastNotification.AddErrorToastMessage("Onay kodu gönderilemedi");
            return View();
        }
    }
}