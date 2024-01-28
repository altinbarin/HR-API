using Business.Constants;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class SpendingRequestAddDtoValidator: AbstractValidator<SpendingRequestAddDto>
    {
        public SpendingRequestAddDtoValidator()
        {

            RuleFor(s => s.Price).NotEmpty().WithMessage(Messages.ThisFieldIsRequired).GreaterThan(0).WithMessage(Messages.TheAmountCanNotBeLessThanZero).Must(IsDigit).WithMessage(Messages.NumberOnly) ;
            RuleFor(s => s.Currency).NotEmpty().WithMessage(Messages.ThisFieldIsRequired).Must(IsNotDigit).WithMessage(Messages.LetterOnly);
            RuleFor(s => s.Name).NotEmpty().WithMessage(Messages.ThisFieldIsRequired);
            //RuleFor(s => s.Folder).NotEmpty().WithMessage(Messages.ThisFieldIsRequired);
            
        }

        private bool IsNotDigit(string currency)
        {
            if(currency.All(char.IsLetter))
            {
                return true;
            }
            return false;
        }

        private bool IsDigit(decimal price)
        {
            if (price.ToString().All(char.IsDigit))
            {
                return true;
            }
            return false;
        }
    }
}
