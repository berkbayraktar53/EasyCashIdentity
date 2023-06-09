using FluentValidation;
using EasyCashIdentity.EntityLayer.Dtos;

namespace EasyCashIdentity.BusinessLayer.ValidationRules.FluentValidation
{
    public class ConfirmMailValidator : AbstractValidator<ConfirmEmailDto>
    {
        public ConfirmMailValidator()
        {
            RuleFor(p => p.ConfirmCode).NotNull().WithMessage("Onay kodu boş geçilemez");
        }
    }
}