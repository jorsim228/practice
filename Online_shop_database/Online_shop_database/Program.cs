
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Online_shop_database;

using (var db = new MyDbContext())
{
    // retrieve all users
    var users = db.Users.ToList();
    foreach (var user in users)
    {
        Console.WriteLine($"{user.Username} ({user.Email})");
    }

    // add a new user
    var newUser = new Users
    {
        Username = "johndoe",
        Password = "password",
        Email = "johndoe@example.com"
    };
    db.Users.Add(newUser);
    db.SaveChanges();
}


class Programm
{
    static void Main(string[] args)
    {
        using var context = new MyDbContext();
        var items = context.Items.Include(p => p.ItemCategory).ToList();
        Console.WriteLine("Items:");
        foreach (var item in items)
        {
            Console.WriteLine($"{item.ItemName} ({item.ItemCategory}) - {item.ItemPrice:c}");
        }
    }
}

