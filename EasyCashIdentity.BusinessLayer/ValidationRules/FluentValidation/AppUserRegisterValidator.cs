using FluentValidation;
using EasyCashIdentity.EntityLayer.Dtos;

namespace EasyCashIdentity.BusinessLayer.ValidationRules.FluentValidation
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");
            RuleFor(p => p.Name).MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapın");
            RuleFor(p => p.Name).MinimumLength(30).WithMessage("Lütfen en fazla 30 karakter veri girişi yapın");

            RuleFor(p => p.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez");
            RuleFor(p => p.Surname).MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapın");
            RuleFor(p => p.Surname).MinimumLength(30).WithMessage("Lütfen en fazla 30 karakter veri girişi yapın");

            RuleFor(p => p.Username).NotEmpty().WithMessage("Kullanıcı adı alanı boş geçilemez");
            RuleFor(p => p.Username).MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapın");
            RuleFor(p => p.Username).MinimumLength(30).WithMessage("Lütfen en fazla 30 karakter veri girişi yapın");

            RuleFor(p => p.Email).NotEmpty().WithMessage("Email alanı boş geçilemez");
            RuleFor(p => p.Email).MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapın");
            RuleFor(p => p.Email).MinimumLength(30).WithMessage("Lütfen en fazla 30 karakter veri girişi yapın");
            RuleFor(p => p.Email).EmailAddress().WithMessage("Lütfen geçerli bir mail adresi giriniz");

            RuleFor(p => p.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez");
            RuleFor(p => p.Password).MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapın");
            RuleFor(p => p.Password).MinimumLength(30).WithMessage("Lütfen en fazla 30 karakter veri girişi yapın");

            RuleFor(p => p.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrar alanı boş geçilemez");
            RuleFor(p => p.ConfirmPassword).MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapın");
            RuleFor(p => p.ConfirmPassword).MinimumLength(30).WithMessage("Lütfen en fazla 30 karakter veri girişi yapın");
            RuleFor(p => p.ConfirmPassword).Equal(p => p.Password).WithMessage("Şifreler birbiriyle eşleşmiyor");
        }
    }
}