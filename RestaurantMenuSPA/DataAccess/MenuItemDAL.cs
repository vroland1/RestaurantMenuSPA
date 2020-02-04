using Microsoft.EntityFrameworkCore;
using RestaurantMenuSPA.Models.Context;
using RestaurantMenuSPA.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMenuSPA.DataAccess
{
    public class MenuItemDAL
    {
        private RestaurantMenuContext _context;

        public MenuItemDAL(RestaurantMenuContext _context)
        {
            this._context = _context;
        }

        public async Task<List<MenuItem>> GetAllMenuItems()
        {
            List<MenuItem> items = await _context.MenuItems.ToListAsync<MenuItem>();

            return items;
        }
    }
}
