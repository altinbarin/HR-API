using Business.Constants;
using Entities.DTOs;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class FirmAddDtoValidator : AbstractValidator<FirmAddDto>
    {
        public FirmAddDtoValidator()
        {
            RuleFor(f => f.Name).NotEmpty().WithMessage(Messages.ThisFieldIsRequired).MaximumLength(100).WithMessage(Messages.MaxValue100);
            RuleFor(f => f.Address).NotEmpty().WithMessage(Messages.ThisFieldIsRequired).MaximumLength(250).WithMessage(Messages.MaxValue250);
            RuleFor(f => f.ConctractEndDate).NotEmpty().WithMessage(Messages.ThisFieldIsRequired).GreaterThan(DateTime.Now);
            RuleFor(f => f.ConctractStartDate).NotEmpty().WithMessage(Messages.ThisFieldIsRequired).LessThan(f => f.ConctractEndDate);
            RuleFor(f => f.DateOfFoundation).NotEmpty().WithMessage(Messages.ThisFieldIsRequired).LessThan(DateTime.Now);
            RuleFor(f => f.Email).NotEmpty().WithMessage(Messages.ThisFieldIsRequired).EmailAddress();
            RuleFor(f => f.EmployeeCount).NotEmpty().WithMessage(Messages.ThisFieldIsRequired).GreaterThan(0).LessThan(1000000);
            RuleFor(f => f.MersisNo).NotEmpty().WithMessage(Messages.ThisFieldIsRequired).Must(IsDigit).WithMessage(Messages.NumberOnly).Length(16).WithMessage(Messages.Value16);
            RuleFor(f => f.PhoneNumber).NotEmpty().WithMessage(Messages.ThisFieldIsRequired).Must(IsDigit).WithMessage(Messages.NumberOnly).Length(11).WithMessage(Messages.NotAValidPhoneNumber);
            RuleFor(f => f.Title).NotEmpty().WithMessage(Messages.ThisFieldIsRequired).MaximumLength(100).WithMessage(Messages.MaxValue100);
            RuleFor(f => f.VergiNo).NotEmpty().WithMessage(Messages.ThisFieldIsRequired).MaximumLength(100).WithMessage(Messages.Value10).Must(IsDigit).WithMessage(Messages.NumberOnly);
            RuleFor(f => f.VergiDairesi).NotEmpty().WithMessage(Messages.ThisFieldIsRequired).MaximumLength(100).WithMessage(Messages.MaxValue100);
            
        }

        private bool IsDigit(string mersisNo)
        {
            if(mersisNo.All(char.IsDigit))
            {
                return true;
            }
            return false;
        }
    }
}
