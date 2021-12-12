namespace ConsoleApp2.Model
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        public BaseEntity()
        {

        }
        public BaseEntity(bool initialize)
        {
            if (initialize)
            {
                Id = Guid.NewGuid();
            }
        }
    }
}
