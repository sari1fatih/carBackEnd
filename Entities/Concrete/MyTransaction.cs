using Core.Entities;

namespace Entities.Concrete
{
    public class MyTransaction : IEntity
    {
        public int Id { get; set; }
        public int BuyId { get; set; }
        public string Message { get; set; }
    }
}
