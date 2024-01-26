using MyLibraryWithEntityFrameworkCore.Context;
using MyLibraryWithEntityFrameworkCore.Models;


using (var context = new MyDbContext())
{
    context.Authors?.Add(new Author { FirstName = "ABC", LastName = "ZXC" });
    context.SaveChanges();
}
Console.WriteLine("The author added"); 