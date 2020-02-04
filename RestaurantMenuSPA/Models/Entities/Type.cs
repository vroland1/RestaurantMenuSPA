using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMenuSPA.Models.Entities
{
    public class Type
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<MenuItemType> MenuItemTypes { get; set; }
    }
}
