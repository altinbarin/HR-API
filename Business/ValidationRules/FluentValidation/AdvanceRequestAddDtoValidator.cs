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
    public class AdvanceRequestAddDtoValidator: AbstractValidator<AdvanceRequestAddDto>
    {
        public AdvanceRequestAddDtoValidator()
        {
            RuleFor(a=>a.Price).Must(IsDigit).WithMessage(Messages.NumberOnly).NotEmpty();
            RuleFor(a => a.Currency).Must(IsNotDigit).WithMessage(Messages.LetterOnly).NotEmpty();
            RuleFor(a => a.Description).NotEmpty().WithMessage(Messages.ThisFieldIsRequired);
            
        }

        private bool IsDigit(decimal price)
        {
            if (price.ToString().All(char.IsDigit))
            {
                return true;
            }
            return false;
        }

        private bool IsNotDigit(string currency)
        {
            if (currency.All(char.IsLetter))
            {
                return true;
            }
            return false;
        }
    }
}
