using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantMenuSPA.DataAccess;
using RestaurantMenuSPA.Models.Context;
using RestaurantMenuSPA.Models.Entities;

namespace RestaurantMenuSPA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        public MenuItemDAL dl;

        public MenuController(MenuItemDAL dl)
        {
            this.dl = dl;
        }

        [HttpGet]
        [Route("/item")]
        public async Task<JsonResult> GetMenuItems()
        {
            List<MenuItem> items = dl.


        }
    }
}