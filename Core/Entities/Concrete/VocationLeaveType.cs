namespace Core.Entities.Concrete
{
    public class VocationLeaveType: IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Day { get; set; }
    }
}
