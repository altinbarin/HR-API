namespace Core.Entities.Concrete
{
    public class AdvanceRequest:IEntity
    {
        public int Id { get; set; }

        public DateTime? RequestDate { get; set; } = DateTime.Now;

        public DateTime? ResponseDate { get; set; }

        public int? RequestApprovalStatusId { get; set; } = 1;

        public int EmployeeId { get; set; }

        public decimal Price { get; set; }

        public string Currency { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }

        public bool Status { get; set; } = true;
    }
}
