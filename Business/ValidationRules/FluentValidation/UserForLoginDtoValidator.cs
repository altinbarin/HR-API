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
    public class UserForLoginDtoValidator : AbstractValidator<UserForLoginDto>
    {
        public UserForLoginDtoValidator()
        {
            RuleFor(x=>x.Email).NotEmpty().WithMessage(Messages.NotAValidEmail).EmailAddress().WithMessage(Messages.NotAValidEmail);

            RuleFor(x => x.Password).NotEmpty().WithMessage(Messages.ThisFieldIsRequired);
        }
    }
}
