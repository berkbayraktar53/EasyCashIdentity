using FluentValidation;
using EasyCashIdentity.EntityLayer.Dtos;

namespace EasyCashIdentity.BusinessLayer.ValidationRules.FluentValidation
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Lütfen adınızı giriniz");
            RuleFor(p => p.Name).MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapın");
            RuleFor(p => p.Name).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter veri girişi yapın");

            RuleFor(p => p.Surname).NotEmpty().WithMessage("Lütfen soyadınızı giriniz");
            RuleFor(p => p.Surname).MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapın");
            RuleFor(p => p.Surname).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter veri girişi yapın");

            RuleFor(p => p.Username).NotEmpty().WithMessage("Lütfen kullanıcı adınızı giriniz");
            RuleFor(p => p.Username).MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapın");
            RuleFor(p => p.Username).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter veri girişi yapın");

            RuleFor(p => p.Email).NotEmpty().WithMessage("Lütfen email adresinizi giriniz");
            RuleFor(p => p.Email).MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapın");
            RuleFor(p => p.Email).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter veri girişi yapın");
            RuleFor(p => p.Email).EmailAddress().WithMessage("Lütfen geçerli bir mail adresi giriniz");

            RuleFor(p => p.Password).NotEmpty().WithMessage("Lütfen şifrenizi giriniz");
            RuleFor(p => p.Password).MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapın");
            RuleFor(p => p.Password).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter veri girişi yapın");
            RuleFor(p => p.Password).Equal(p => p.ConfirmPassword).WithMessage("Şifreler birbiriyle eşleşmiyor");

            RuleFor(p => p.ConfirmPassword).NotEmpty().WithMessage("Lütfen şifrenizi tekrar giriniz");
            RuleFor(p => p.ConfirmPassword).MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapın");
            RuleFor(p => p.ConfirmPassword).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter veri girişi yapın");
            RuleFor(p => p.ConfirmPassword).Equal(p => p.Password).WithMessage("Şifreler birbiriyle eşleşmiyor");
        }
    }
}