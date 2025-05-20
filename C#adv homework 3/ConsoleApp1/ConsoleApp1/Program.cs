
using ConsoleApp1.Database;
using ConsoleApp1.Models;

User userById = UserDatabase.SerchById(2);
Console.WriteLine($"User ID: {userById.Id} Name: {userById.Name} Age: {userById.Age}");

List<User> userByName = UserDatabase.SerchByName("Dejan");
foreach(User user in userByName)
{
Console.WriteLine($"Name: {user.Name} ID: {user.Id} Age: {user.Age}"); 
}

List<User> usersByAge = UserDatabase.SearchByAge(29);
foreach (User user in  usersByAge)
{
    Console.WriteLine($"User ID: {user.Id} Name: {user.Name} Age: {user.Age}");
}