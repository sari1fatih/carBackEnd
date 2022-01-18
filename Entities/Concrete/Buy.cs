using Core.Entities;

namespace Entities.Concrete
{
    public class Buy : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Model { get; set; }
        public string Message { get; set; }
    }
}
