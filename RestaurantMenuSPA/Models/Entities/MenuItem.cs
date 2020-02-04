using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMenuSPA.Models.Entities
{
    public class MenuItem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        //[Column(TypeName = "Money")]
        public decimal Price { get; set; }

        public bool IsCurrentlyOnMenu { get; set; }

        public virtual ICollection<MenuItemType> MenuItemTypes { get; set; }
    }
}
