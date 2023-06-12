using FluentValidation;
using EasyCashIdentity.EntityLayer.Dtos;

namespace EasyCashIdentity.BusinessLayer.ValidationRules.FluentValidation
{
    public class UserForLoginValidator : AbstractValidator<UserForLoginDto>
    {
        public UserForLoginValidator()
        {
            RuleFor(p => p.Email).NotEmpty().WithMessage("Lütfen mail adresinizi giriniz");
            RuleFor(p => p.Email).MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapın");
            RuleFor(p => p.Email).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter veri girişi yapın");
            RuleFor(p => p.Email).EmailAddress().WithMessage("Lütfen geçerli bir mail adresi giriniz");

            RuleFor(p => p.Password).NotEmpty().WithMessage("Lütfen şifrenizi giriniz");
            RuleFor(p => p.Password).MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapın");
            RuleFor(p => p.Password).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter veri girişi yapın");
        }
    }
}