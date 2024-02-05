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
    public class UserForRegisterDtoValidator : AbstractValidator<UserForRegisterDto>
    {
        public UserForRegisterDtoValidator()
        {
            RuleFor(tc => tc.TurkishIdentificationNumber).Must(BeAValidTcKimlikNo).WithMessage(Messages.NotAValidTc);

            RuleFor(phoneNumber => phoneNumber.PhoneNumber)
            .NotEmpty().WithMessage(Messages.ThisFieldIsRequired)
            .Must(IsPhoneNumberValid).WithMessage(Messages.NotAValidPhoneNumber);

            RuleFor(fn => fn.FirstName).NotEmpty().WithMessage(Messages.ThisFieldIsRequired).Must(IsLetter).WithMessage(Messages.LetterOnly);

            RuleFor(fn => fn.LastName).NotEmpty().WithMessage(Messages.ThisFieldIsRequired).Must(IsLetter).WithMessage(Messages.LetterOnly);

            RuleFor(fn => fn.MiddleName).Must(IsLetter).WithMessage(Messages.LetterOnly);

            RuleFor(fn => fn.SecondLastname).Must(IsLetter).WithMessage(Messages.LetterOnly);

            RuleFor(s => s.Salary).NotEmpty().GreaterThan(0).WithMessage(Messages.NotAValidSalary);

            RuleFor(p => p.Profession).NotEmpty().Must(IsLetter).WithMessage(Messages.LetterOnly);

            RuleFor(p => p.City).NotEmpty().WithMessage(Messages.ThisFieldIsRequired).Must(IsLetter).WithMessage(Messages.LetterOnly);


            RuleFor(d => d.Department).NotEmpty().WithMessage(Messages.ThisFieldIsRequired).Must(IsLetter).WithMessage(Messages.LetterOnly);

            RuleFor(p => p.Address).NotEmpty().WithMessage(Messages.ThisFieldIsRequired).Must(IsLetter).WithMessage(Messages.LetterOnly);

            RuleFor(p => p.Position).NotEmpty().WithMessage(Messages.ThisFieldIsRequired).Must(IsLetter).WithMessage(Messages.LetterOnly);

            RuleFor(p => p.Company).NotEmpty().WithMessage(Messages.ThisFieldIsRequired).Must(IsLetter).WithMessage(Messages.LetterOnly);

            RuleFor(p => p.BirthLocation).NotEmpty().WithMessage(Messages.ThisFieldIsRequired).Must(IsLetter).WithMessage(Messages.LetterOnly);

            RuleFor(e => e.EmailForRegister).NotEmpty().WithMessage(Messages.ThisFieldIsRequired).EmailAddress().WithMessage(Messages.NotAValidEmail);
        }

        private bool IsPhoneNumberValid(string telNo)
        {
            if (telNo.All(char.IsDigit) && telNo.StartsWith('0') && telNo.Length == 11)
            {
                return true;
            }
            return false;
        }

        public bool IsLetter(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return true;
            }
            if (!name.All(char.IsDigit))
            {
                return true;
            }
            return false;
        }

        private bool BeAValidTcKimlikNo(string tcKimlikNo)
        {
            if (string.IsNullOrEmpty(tcKimlikNo) || tcKimlikNo.Length != 11 || !tcKimlikNo.All(char.IsDigit))
            {
                return false;
            }

            int[] digits = tcKimlikNo.Select(c => int.Parse(c.ToString())).ToArray();

            int sum1 = digits[0] + digits[2] + digits[4] + digits[6] + digits[8];
            int sum2 = digits[1] + digits[3] + digits[5] + digits[7];

            int tenthDigit = (sum1 * 7 - sum2) % 10;
            int eleventhDigit = (sum1 + sum2 + digits[9]) % 10;

            return digits[9] == tenthDigit && digits[10] == eleventhDigit;
        }

    }
}
