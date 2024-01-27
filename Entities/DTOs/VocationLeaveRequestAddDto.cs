namespace Entities.DTOs
{
    public class VocationLeaveRequestAddDto
    {
        public DateTime StartingDate { get; set; }

        //public DateTime EndingDate { get; set; }

        public string VocationLeaveTypeName { get; set; }

        public int Day { get; set; }

    }
}
