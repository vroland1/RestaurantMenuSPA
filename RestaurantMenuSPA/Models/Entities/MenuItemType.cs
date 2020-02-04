using RestaurantMenuSPA.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Type = RestaurantMenuSPA.Models.Entities.Type;

namespace RestaurantMenuSPA.Models
{
    public class MenuItemType
    {
        [Key, Column(Order = 0)]
        public int MenuItemId { get; set; }
        [Key, Column(Order = 1)]
        public int TypeId { get; set; }

        public virtual MenuItem MenuItem { get; set; }
        public virtual Type Type { get; set; }
    }
}
