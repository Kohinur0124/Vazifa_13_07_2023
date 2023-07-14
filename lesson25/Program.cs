// See https://aka.ms/new-console-template for more information
using lesson25.Data;
using lesson25.Enum;
using lesson25.Model;
using lesson25.Methods;

Console.WriteLine("Hello, World!");


var user = new User()
{
    UserId = 5,
    Age = 7,
    Name = "7",
    PhoneNumber = "7",
    Gender =Gender.Female,
};

Method.DeleteAll();