using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantMenuSPA.Migrations
{
    public partial class Seed_Data_And_Currently_On_Menu_Column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "MenuItems",
                type: "money",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<bool>(
                name: "IsCurrentlyOnMenu",
                table: "MenuItems",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Description", "IsCurrentlyOnMenu", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Tortilla chips with homemade salsa and queso", true, "Chips and Salsa", 6.99m },
                    { 26, "Double Chocolate- Rich, fudgy chocolate cake filled and frosted with our house chocolate buttercream", true, "Slice of Chocolate Cake", 2.5m },
                    { 25, null, true, "Mayo", 0.5m },
                    { 24, null, true, "Ranch", 0.5m },
                    { 23, null, true, "Mustard", 0.5m },
                    { 22, null, true, "Ketchup", 0.5m },
                    { 21, null, true, "Sprite", 1.5m },
                    { 20, null, true, "Diet Coke", 1.5m },
                    { 18, "Flavors chocolate, vanilla, strawberry, caramel, banana", true, "Milk Shake", 2.99m },
                    { 17, null, true, "Three Bean Chili", 3.99m },
                    { 16, null, true, "Side Salad", 2.99m },
                    { 15, null, true, "Mac and Cheese", 3.99m },
                    { 14, null, true, "Onion Rings", 3.99m },
                    { 19, null, true, "Coke", 1.5m },
                    { 12, null, true, "French Fries", 2.99m },
                    { 13, null, true, "Cole Slaw", 2.99m },
                    { 3, "A dozen salted soft pretzels bites served with queso and mustard on side", true, "Pretzel Bites", 7.59m },
                    { 4, "Six chicken wings, onion rings, mozzerella sticks, fried pickles served with a side of ranch", true, "Combo Platter", 13.99m },
                    { 5, "Our signature burger with cheese, lettuce, tomato, onion, pickle and mayo", true, "Classic Burger", 8.99m },
                    { 6, "Tender roast beef with grilled onions, green peppers, mushrooms, and provolone cheese", true, "Philly Cheese Steak Sandwich", 9.99m },
                    { 2, "Red pepper hummus, pitas, celery, carrots and cucumber", true, "Hummus Plate", 9.49m },
                    { 8, "Romaine lettuce, grilled chicken breast, tomato, provolone and mozzarella cheese, Caesar dressing and croutons", true, "Chicken Casesar Salad", 7.29m },
                    { 9, "An iceberg wedge topped with blue cheese dressing and crumbles, piled high with bacon, chives and tomato", true, "Wedge Salad", 7.29m },
                    { 10, "Scoop of vanilla, chocolate, and strawberry ice cream with banana, cherry and hot fudge on top", true, "Banana Split", 5.99m },
                    { 11, "White cheddar over rotini noodles with hickory smoked bacon bits and bread crumbs", true, "Bacon Mac and Cheese", 8.99m },
                    { 7, "A triple-decker served on your choice of bread or toast; includes turkey, bacon, lettuce, tomato, mayo and American cheese", true, "Smoked Turkey Club Sandwich", 8.49m }
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 10, "Pasta" },
                    { 1, "Regular Side" },
                    { 2, "Premium Side" },
                    { 3, "Entree" },
                    { 4, "Drink" },
                    { 5, "Dessert" },
                    { 6, "Condiment" },
                    { 7, "Sandwich" },
                    { 8, "Soup" },
                    { 9, "Salad" },
                    { 11, "Appetizer" }
                });

            migrationBuilder.InsertData(
                table: "MenuItemTypes",
                columns: new[] { "MenuItemId", "TypeId" },
                values: new object[,]
                {
                    { 12, 1 },
                    { 23, 6 },
                    { 24, 6 },
                    { 25, 6 },
                    { 5, 7 },
                    { 6, 7 },
                    { 7, 7 },
                    { 22, 6 },
                    { 17, 8 },
                    { 9, 9 },
                    { 16, 9 },
                    { 11, 10 },
                    { 15, 10 },
                    { 1, 11 },
                    { 2, 11 },
                    { 8, 9 },
                    { 26, 5 },
                    { 18, 5 },
                    { 10, 5 },
                    { 13, 1 },
                    { 16, 1 },
                    { 14, 2 },
                    { 15, 2 },
                    { 17, 2 },
                    { 5, 3 },
                    { 6, 3 },
                    { 7, 3 },
                    { 8, 3 },
                    { 9, 3 },
                    { 11, 3 },
                    { 18, 4 },
                    { 19, 4 },
                    { 20, 4 },
                    { 21, 4 },
                    { 3, 11 },
                    { 4, 11 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuItemTypes",
                keyColumns: new[] { "MenuItemId", "TypeId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "MenuItemTypes",
                keyColumns: new[] { "MenuItemId", "TypeId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "MenuItemTypes",
                keyColumns: new[] { "MenuItemId", "TypeId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "MenuItemTypes",
                keyColumns: new[] { "MenuItemId", "TypeId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "MenuItemTypes",
                keyColumns: new[] { "MenuItemId", "TypeId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "MenuItemTypes",
                keyColumns: new[] { "MenuItemId", "TypeId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "MenuItemTypes",
                keyColumns: new[] { "MenuItemId", "TypeId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "MenuItemTypes",
                keyColumns: new[] { "MenuItemId", "TypeId" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "MenuItemTypes",
                keyColumns: new[] { "MenuItemId", "TypeId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "MenuItemTypes",
                keyColumns: new[] { "MenuItemId", "TypeId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "MenuItemTypes",
                keyColumns: new[] { "MenuItemId", "TypeId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "MenuItemTypes",
                keyColumns: new[] { "MenuItemId", "TypeId" },
                keyValues: new object[] { 8, 9 });

            migrationBuilder.DeleteData(
                table: "MenuItemTypes",
                keyColumns: new[] { "MenuItemId", "TypeId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "MenuItemTypes",
                keyColumns: new[] { "MenuItemId", "TypeId" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "MenuItemTypes",
                keyColumns: new[] { "MenuItemId", "TypeId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "MenuItemTypes",
                keyColumns: new[] { "MenuItemId", "TypeId" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                table: "MenuItemTypes",
                keyColumns: new[] { "MenuItemId", "TypeId" },
                keyValues: new object[] { 11, 10 });

            migrationBuilder.DeleteData(
                table: "MenuItemTypes",
                keyColumns: new[] { "MenuItemId", "TypeId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "MenuItemTypes",
                keyColumns: new[] { "MenuItemId", "TypeId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "MenuItemTypes",
                keyColumns: new[] { "MenuItemId", "TypeId" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                table: "MenuItemTypes",
                keyColumns: new[] { "MenuItemId", "TypeId" },
                keyValues: new object[] { 15, 2 });

            migrationBuilder.DeleteData(
                table: "MenuItemTypes",
                keyColumns: new[] { "MenuItemId", "TypeId" },
                keyValues: new object[] { 15, 10 });

            migrationBuilder.DeleteData(
                table: "MenuItemTypes",
                keyColumns: new[] { "MenuItemId", "TypeId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "MenuItemTypes",
                keyColumns: new[] { "MenuItemId", "TypeId" },
                keyValues: new object[] { 16, 9 });

            migrationBuilder.DeleteData(
                table: "MenuItemTypes",
                keyColumns: new[] { "MenuItemId", "TypeId" },
                keyValues: new object[] { 17, 2 });

            migrationBuilder.DeleteData(
                table: "MenuItemTypes",
                keyColumns: new[] { "MenuItemId", "TypeId" },
                keyValues: new object[] { 17, 8 });

            migrationBuilder.DeleteData(
                table: "MenuItemTypes",
                keyColumns: new[] { "MenuItemId", "TypeId" },
                keyValues: new object[] { 18, 4 });

            migrationBuilder.DeleteData(
                table: "MenuItemTypes",
                keyColumns: new[] { "MenuItemId", "TypeId" },
                keyValues: new object[] { 18, 5 });

            migrationBuilder.DeleteData(
                table: "MenuItemTypes",
                keyColumns: new[] { "MenuItemId", "TypeId" },
                keyValues: new object[] { 19, 4 });

            migrationBuilder.DeleteData(
                table: "MenuItemTypes",
                keyColumns: new[] { "MenuItemId", "TypeId" },
                keyValues: new object[] { 20, 4 });

            migrationBuilder.DeleteData(
                table: "MenuItemTypes",
                keyColumns: new[] { "MenuItemId", "TypeId" },
                keyValues: new object[] { 21, 4 });

            migrationBuilder.DeleteData(
                table: "MenuItemTypes",
                keyColumns: new[] { "MenuItemId", "TypeId" },
                keyValues: new object[] { 22, 6 });

            migrationBuilder.DeleteData(
                table: "MenuItemTypes",
                keyColumns: new[] { "MenuItemId", "TypeId" },
                keyValues: new object[] { 23, 6 });

            migrationBuilder.DeleteData(
                table: "MenuItemTypes",
                keyColumns: new[] { "MenuItemId", "TypeId" },
                keyValues: new object[] { 24, 6 });

            migrationBuilder.DeleteData(
                table: "MenuItemTypes",
                keyColumns: new[] { "MenuItemId", "TypeId" },
                keyValues: new object[] { 25, 6 });

            migrationBuilder.DeleteData(
                table: "MenuItemTypes",
                keyColumns: new[] { "MenuItemId", "TypeId" },
                keyValues: new object[] { 26, 5 });

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DropColumn(
                name: "IsCurrentlyOnMenu",
                table: "MenuItems");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "MenuItems",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");
        }
    }
}
