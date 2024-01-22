// See https://aka.ms/new-console-template for more information
using DatabaseExample.Entities;
using DatabaseExample.Repositories;

Console.WriteLine("Hello, World!");

ExampleDbContext db = new ExampleDbContext();

User newUser = new User
{
    UserName = "halisoy",
    Password = "1234",
    FirstName = "Halis",
    LastName = "Oy",
    IdentificationNumber = "11223344551",
    IsActive = true

};

//db.Users.Add(newUser);
//db.Users.Remove();

db.SaveChanges();