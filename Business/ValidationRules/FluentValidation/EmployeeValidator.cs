using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(h => h.PhoneNumber).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
            RuleFor(h => h.PhoneNumber).Length(11).WithMessage("Lütfen telefon numaranızı 11 haneli, başında 0 (sıfır) olacak şekilde giriniz");
            RuleFor(h => h.PhoneNumber).Must(IsNumber).WithMessage("Lütfen telefon numaranızı sadece rakamlardan oluşacak şekilde giriniz");
            RuleFor(h => h.Address).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
            //RuleFor(h => h.ImageData).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
        }
        private bool IsNumber(string arg)
        {
            return arg.All(char.IsDigit);
        }
    }
}
