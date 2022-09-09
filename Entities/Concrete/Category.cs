using Core.Entities;

namespace Entities.Concrete
{  // çıplak class acemi işi 
    public class Category: IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
