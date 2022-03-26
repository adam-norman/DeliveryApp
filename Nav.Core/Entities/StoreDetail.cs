using Nav.Core.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace Nav.Core.Entities
{
    public class StoreDetail:Entity
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }
        public string PhotoUrl { get; set; }
       public Store Store { get; set; }
    }
}
