using Business.Constants;
using Core.Entities;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(tc => tc.TurkishIdentificationNumber).Must(BeAValidTcKimlikNo).WithMessage(Messages.NotAValidTc);

            RuleFor(phoneNumber => phoneNumber.PhoneNumber)
            .NotEmpty().WithMessage(Messages.ThisFieldIsRequired)
            .Matches(@"^0[2-9][0-9]{8}$").WithMessage(Messages.NotAValidPhoneNumber);

            RuleFor(adress => adress.Address).NotEmpty().WithMessage(Messages.ThisFieldIsRequired);

            RuleFor(fn => fn.FirstName).NotEmpty().WithMessage(Messages.ThisFieldIsRequired).Must(IsLetter).WithMessage(Messages.LetterOnly);

            RuleFor(fn => fn.LastName).NotEmpty().WithMessage(Messages.ThisFieldIsRequired).Must(IsLetter).WithMessage(Messages.LetterOnly);

            RuleFor(fn => fn.MiddleName).Must(IsLetter).WithMessage(Messages.LetterOnly);

            RuleFor(fn => fn.SecondLastname).Must(IsLetter).WithMessage(Messages.LetterOnly);

            RuleFor(s => s.Salary).NotNull().GreaterThan(0).WithMessage(Messages.NotAValidSalary);

            RuleFor(p=>p.Profession).NotEmpty().Must(IsLetter).WithMessage(Messages.LetterOnly);

            RuleFor(p => p.City).NotEmpty().WithMessage(Messages.ThisFieldIsRequired).Must(IsLetter).WithMessage(Messages.LetterOnly);


            RuleFor(d=>d.Department).NotEmpty().WithMessage(Messages.ThisFieldIsRequired).Must(IsLetter).WithMessage(Messages.LetterOnly);

            RuleFor(p => p.Address).NotEmpty().WithMessage(Messages.ThisFieldIsRequired).Must(IsLetter).WithMessage(Messages.LetterOnly);

            RuleFor(p => p.Position).NotEmpty().WithMessage(Messages.ThisFieldIsRequired).Must(IsLetter).WithMessage(Messages.LetterOnly);

            RuleFor(p => p.Company).NotEmpty().WithMessage(Messages.ThisFieldIsRequired).Must(IsLetter).WithMessage(Messages.LetterOnly);

            RuleFor(p => p.BirthLocation).NotEmpty().WithMessage(Messages.ThisFieldIsRequired).Must(IsLetter).WithMessage(Messages.LetterOnly);

            RuleFor(e => e.EmailForRegister).NotEmpty().WithMessage(Messages.ThisFieldIsRequired).EmailAddress().WithMessage(Messages.NotAValidEmail);
        }

      

        public bool IsLetter(string name)
        {
            if (!name.All(char.IsDigit))
            {
                return true;
            }
            return false;
        }

        private bool BeAValidTcKimlikNo(string tcKimlikNo)
        {

            if (tcKimlikNo.All(char.IsDigit) && tcKimlikNo.Length == 11)
            {
                int[] digits = tcKimlikNo.Select(c => int.Parse(c.ToString())).ToArray();

                int evenSum = digits.Where((d, i) => i % 2 == 0).Sum();
                int oddSum = digits.Where((d, i) => i % 2 == 1 && i < 9).Sum();

                int tenthDigit = (evenSum * 7 - oddSum) % 10;
                int eleventhDigit = (evenSum + oddSum + tenthDigit) % 10;

                return digits[9] == tenthDigit && digits[10] == eleventhDigit;
            }

            return false;
        }
    }
}
