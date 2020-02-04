using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestaurantMenuSPA.Models.Entities;
using Type = RestaurantMenuSPA.Models.Entities.Type;

namespace RestaurantMenuSPA.Models.Context
{
    public class RestaurantMenuContext : DbContext
    {
        public RestaurantMenuContext(DbContextOptions<RestaurantMenuContext> options)
           : base(options)
        {
        }

        public DbSet<MenuItem> MenuItems { get; set; }

        public DbSet<Type> Types { get; set; }

        public DbSet<MenuItemType> MenuItemTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MenuItemType>()
                .HasKey(c => new { c.MenuItemId, c.TypeId });

            modelBuilder.Entity<MenuItem>()
                .Property(i => i.Price)
                .HasColumnType("money");

            modelBuilder.Entity<Type>().HasData(
                new { Id = 1, Name = "Regular Side" },
                new { Id = 2, Name = "Premium Side" },
                new { Id = 3, Name = "Entree" },
                new { Id = 4, Name = "Drink" },
                new { Id = 5, Name = "Dessert" },
                new { Id = 6, Name = "Condiment" },
                new { Id = 7, Name = "Sandwich" },
                new { Id = 8, Name = "Soup" },
                new { Id = 9, Name = "Salad" },
                new { Id = 10, Name = "Pasta" },
                new { Id = 11, Name = "Appetizer" }
                );

            modelBuilder.Entity<MenuItem>().HasData(
                new { Id = 1, Name = "Chips and Salsa", Description = "Tortilla chips with homemade salsa and queso", Price = (decimal)6.99, IsCurrentlyOnMenu = true },
                new { Id = 2, Name = "Hummus Plate", Description = "Red pepper hummus, pitas, celery, carrots and cucumber", Price = (decimal)9.49, IsCurrentlyOnMenu = true },
                new { Id = 3, Name = "Pretzel Bites", Description = "A dozen salted soft pretzels bites served with queso and mustard on side", Price = (decimal)7.59, IsCurrentlyOnMenu = true },
                new { Id = 4, Name = "Combo Platter", Description = "Six chicken wings, onion rings, mozzerella sticks, fried pickles served with a side of ranch", Price = (decimal)13.99, IsCurrentlyOnMenu = true },
                new { Id = 5, Name = "Classic Burger", Description = "Our signature burger with cheese, lettuce, tomato, onion, pickle and mayo", Price = (decimal)8.99, IsCurrentlyOnMenu = true },
                new { Id = 6, Name = "Philly Cheese Steak Sandwich", Description = "Tender roast beef with grilled onions, green peppers, mushrooms, and provolone cheese", Price = (decimal)9.99, IsCurrentlyOnMenu = true },
                new { Id = 7, Name = "Smoked Turkey Club Sandwich", Description = "A triple-decker served on your choice of bread or toast; includes turkey, bacon, lettuce, tomato, mayo and American cheese", Price = (decimal)8.49, IsCurrentlyOnMenu = true },
                new { Id = 8, Name = "Chicken Casesar Salad", Description = "Romaine lettuce, grilled chicken breast, tomato, provolone and mozzarella cheese, Caesar dressing and croutons", Price = (decimal)7.29, IsCurrentlyOnMenu = true },
                new { Id = 9, Name = "Wedge Salad", Description = "An iceberg wedge topped with blue cheese dressing and crumbles, piled high with bacon, chives and tomato", Price = (decimal)7.29, IsCurrentlyOnMenu = true },
                new { Id = 10, Name = "Banana Split", Description = "Scoop of vanilla, chocolate, and strawberry ice cream with banana, cherry and hot fudge on top", Price = (decimal)5.99, IsCurrentlyOnMenu = true },
                new { Id = 11, Name = "Bacon Mac and Cheese", Description = "White cheddar over rotini noodles with hickory smoked bacon bits and bread crumbs", Price = (decimal)8.99, IsCurrentlyOnMenu = true },
                new { Id = 12, Name = "French Fries", Price = (decimal)2.99, IsCurrentlyOnMenu = true },
                new { Id = 13, Name = "Cole Slaw", Price = (decimal)2.99, IsCurrentlyOnMenu = true },
                new { Id = 14, Name = "Onion Rings", Price = (decimal)3.99, IsCurrentlyOnMenu = true },
                new { Id = 15, Name = "Mac and Cheese", Price = (decimal)3.99, IsCurrentlyOnMenu = true },
                new { Id = 16, Name = "Side Salad", Price = (decimal)2.99, IsCurrentlyOnMenu = true },
                new { Id = 17, Name = "Three Bean Chili", Price = (decimal)3.99, IsCurrentlyOnMenu = true },
                new { Id = 18, Name = "Milk Shake", Description = "Flavors chocolate, vanilla, strawberry, caramel, banana", Price = (decimal)2.99, IsCurrentlyOnMenu = true },
                new { Id = 19, Name = "Coke", Price = (decimal)1.50, IsCurrentlyOnMenu = true },
                new { Id = 20, Name = "Diet Coke", Price = (decimal)1.50, IsCurrentlyOnMenu = true },
                new { Id = 21, Name = "Sprite", Price = (decimal)1.50, IsCurrentlyOnMenu = true },
                new { Id = 22, Name = "Ketchup", Price = (decimal)0.50, IsCurrentlyOnMenu = true },
                new { Id = 23, Name = "Mustard", Price = (decimal)0.50, IsCurrentlyOnMenu = true },
                new { Id = 24, Name = "Ranch", Price = (decimal)0.50, IsCurrentlyOnMenu = true },
                new { Id = 25, Name = "Mayo", Price = (decimal)0.50, IsCurrentlyOnMenu = true },
                new { Id = 26, Name = "Slice of Chocolate Cake", Description = "Double Chocolate- Rich, fudgy chocolate cake filled and frosted with our house chocolate buttercream", Price = (decimal)2.50, IsCurrentlyOnMenu = true }
                );

            modelBuilder.Entity<MenuItemType>().HasData(
                new { MenuItemId = 1, TypeId = 11 },
                new { MenuItemId = 2, TypeId = 11 },
                new { MenuItemId = 3, TypeId = 11 },
                new { MenuItemId = 4, TypeId = 11 },
                new { MenuItemId = 5, TypeId = 3 },
                new { MenuItemId = 5, TypeId = 7 },
                new { MenuItemId = 6, TypeId = 3 },
                new { MenuItemId = 6, TypeId = 7 },
                new { MenuItemId = 7, TypeId = 3 },
                new { MenuItemId = 7, TypeId = 7 },
                new { MenuItemId = 8, TypeId = 3 },
                new { MenuItemId = 8, TypeId = 9 },
                new { MenuItemId = 9, TypeId = 3 },
                new { MenuItemId = 9, TypeId = 9 },
                new { MenuItemId = 10, TypeId = 5 },
                new { MenuItemId = 11, TypeId = 3 },
                new { MenuItemId = 11, TypeId = 10 },
                new { MenuItemId = 12, TypeId = 1 },
                new { MenuItemId = 13, TypeId = 1 },
                new { MenuItemId = 14, TypeId = 2 },
                new { MenuItemId = 15, TypeId = 2 },
                new { MenuItemId = 15, TypeId = 10 },
                new { MenuItemId = 16, TypeId = 1 },
                new { MenuItemId = 16, TypeId = 9 },
                new { MenuItemId = 17, TypeId = 2 },
                new { MenuItemId = 17, TypeId = 8 },
                new { MenuItemId = 18, TypeId = 4 },
                new { MenuItemId = 18, TypeId = 5 },
                new { MenuItemId = 19, TypeId = 4 },
                new { MenuItemId = 20, TypeId = 4 },
                new { MenuItemId = 21, TypeId = 4 },
                new { MenuItemId = 22, TypeId = 6 },
                new { MenuItemId = 23, TypeId = 6 },
                new { MenuItemId = 24, TypeId = 6 },
                new { MenuItemId = 25, TypeId = 6 },
                new { MenuItemId = 26, TypeId = 5 }
                );
        }
    }
}
