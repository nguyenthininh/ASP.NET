namespace BookWebServiceAPI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<BookWebServiceAPI.Data.BookWebServiceAPIContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookWebServiceAPI.Data.BookWebServiceAPIContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            //context.Authors.AddOrUpdate(x => x.Id,
            //    new Author() { Id = 1, Name = "Jane Austen" },
            //    new Author() { Id = 2, Name = "Charles Dickes" },
            //    new Author() { Id = 3, Name = "Miguel de Cervanres" });

            //context.Books.AddOrUpdate(x => x.Id,
            //    new Book() { Id = 1, Title = "Price and Prejudice", Year = 1831, AuthorId = 1,
            //        Price = 9.99M, Genre = "Comedy pf manners" },

            //       new Book() { Id = 2, Title = "Price and Prejudice", Year = 1851, AuthorId = 2,
            //           Price = 9.99M, Genre = "Comedy pf manners" },

            //    new Book() { Id = 3, Title = "Price and Prejudice", Year = 1851, AuthorId = 2,
            //        Price = 9.99M, Genre = "Miguel de Cervantes" });

            context.Categories.AddOrUpdate(x => x.Id,
                new Category() { Id = 1, Category_Name = "Dress"},
                new Category() { Id = 2, Category_Name = "Jeans" },
                new Category() { Id = 3, Category_Name = "Shoe" },
                new Category() { Id = 4, Category_Name = "Glass" });

            context.Products.AddOrUpdate(x => x.Id,
                new Product() {  Id = 1, Prodcuct_Name = "Gore Skirt",Context= "Kiểu váy có độ xòe nhẹ", Price=1M, CategoryId= 1},
                new Product() { Id = 2, Prodcuct_Name = "3D glasses", Context = "La kieu kinh game thu dac thich cho nhưng ai hay choi game, giup ho có đọ fill như đnag ở ngoai doi thuc",
                    Price = 3M, CategoryId = 4 },
                new Product() { Id = 3, Prodcuct_Name = "Sneakers", Context = "Là sự lựa chọn phù hợp cho những phong cách trẻ, một sự giao thoa giữa cổ điển và hiện đại giữa smart và casual. ", Price = 4M, CategoryId = 3 },
                new Product() { Id = 4, Prodcuct_Name = "Loose Fit", Context = "Quần jean rộng thùng thình", Price = 1M, CategoryId = 2 },
                new Product() { Id = 5, Prodcuct_Name = "Skinny Fit jeant", Context = "Quần jeans bó", Price = 1M, CategoryId = 1 }

                );
        }
    }
}
