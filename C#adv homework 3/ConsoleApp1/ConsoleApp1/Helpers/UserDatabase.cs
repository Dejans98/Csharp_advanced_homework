using ConsoleApp1.Models;

namespace ConsoleApp1.Database
{
    public static class UserDatabase
    {
        public static List<User> users = new List<User>()
        {
            new User(1,"Filip",29),
            new User(2,"Petar",22),
            new User(3,"Dejan",27),
        };

        public static User SerchById(int id)
        {
            return users.FirstOrDefault(u => u.Id == id);
        }
        public static List<User> SerchByName(string name)
        {
            return users.Where(u => u.Name == name).ToList();
        }
        public static List<User> SearchByAge(int age)
        {
            return users.Where(u => u.Age == age).ToList();
        }
    }
}
