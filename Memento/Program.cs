namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("ivan", "54654321");
            Console.WriteLine(user.Role);
            user.SaveState();

            user.ChangeRole(UserRole.Admin);
            Console.WriteLine(user.Role);
            

            user.ChangeRole(UserRole.User);

            user.LoadState();
            Console.WriteLine(user.Role);
        }
    }
}
