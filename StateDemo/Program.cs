namespace StateDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("petrov", "654656", new ActiveState());
            user.SendMessage("hello!");

            user.ChangeState(new  SuspendedState());
            user.SendMessage("Hello!");

            user.ChangeState(new BannedState());
            user.SendMessage("Hello!");

        }
    }
}
