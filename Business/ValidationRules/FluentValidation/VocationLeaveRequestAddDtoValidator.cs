using Business.Constants;
using Entities.DTOs;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class VocationLeaveRequestAddDtoValidator: AbstractValidator<VocationLeaveRequestAddDto>
    {
        public VocationLeaveRequestAddDtoValidator()
        {
            RuleFor(v=>v.StartingDate).NotEmpty().WithMessage(Messages.ThisFieldIsRequired).GreaterThan(DateTime.Now).WithMessage(Messages.TheDateCanNotBeAPreviousDate);
        }
    }
}
