namespace Core.Entities.Concrete
{
    public class VocationLeaveRequest : IEntity
    {
        public int Id { get; set; }

        //public int Day { get; set; }

        public DateTime StartingDate { get; set; }

        public DateTime EndingDate { get; set; }

        public DateTime? RequestDate { get; set; } = DateTime.Now;

        public DateTime? ResponseDate { get; set; }

        public int EmployeeId { get; set; }

        public int VocationLeaveTypeId { get; set; }

        public int? RequestApprovalStatusId { get; set; } = 1;


    }
}
