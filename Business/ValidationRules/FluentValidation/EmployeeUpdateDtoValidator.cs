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
    public class EmployeeUpdateDtoValidator: AbstractValidator<EmployeeUpdateDto>
    {
        public EmployeeUpdateDtoValidator()
        {
            RuleFor(p => p.Address).NotEmpty().WithMessage(Messages.ThisFieldIsRequired).Must(IsLetter).WithMessage(Messages.LetterOnly);

            RuleFor(phoneNumber => phoneNumber.PhoneNumber)
            .NotEmpty().WithMessage(Messages.ThisFieldIsRequired)
            .Matches(@"^0[2-9][0-9]{8}$").WithMessage(Messages.NotAValidPhoneNumber);
        }

        public bool IsLetter(string name)
        {
            if (!name.All(char.IsDigit))
            {
                return true;
            }
            return false;
        }
    }
}
