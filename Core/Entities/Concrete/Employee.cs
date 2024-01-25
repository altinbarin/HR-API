using Core.Entities;
using Core.Helpers;

namespace Entities.Concrete
{
    public class Employee : IEntity
    {
        public int Id { get; set; }
        public string TurkishIdentificationNumber { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public string EmailForRegister{ get; set; }
        public string? Email
        {
            //get { 
            //    return $"{FirstName.ToLower()}.{LastName.ToLower()}@bilgeadamboost.com"; }
            get { return EmailConvertHelper.GenerateDefaultEmail(FirstName, LastName); }
            set { }
        }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public bool Status { get; set; }
        public string? SecondLastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfEmployment { get; set; }
        public DateTime? DateOfDismissal { get; set; }
        public string BirthLocation { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Profession { get; set; }
        public decimal Salary { get; set; }
        public byte[]? ImageData { get; set; }

        public int TitleId { get; set; }
        //public Title Title { get; set; }

    }
}
