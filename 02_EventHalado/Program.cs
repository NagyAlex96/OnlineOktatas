namespace _02_EventHalado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserManager manager = new UserManager(5);


            manager.AddUser(new Users("valaki1", "1234", 1000, false));
            manager.AddUser(new Users("valaki2", "5678", 1000, true));
            manager.AddUser(new Users("valaki3", "8765", 1000, true));
            manager.AddUser(new Users("valaki4", "4321", 1000, false));

            manager.UserChanged += Manager_UserChanged;

            manager.ChangeUser(new Users("Ember", "2253", 2000, true), 1);

            Console.WriteLine("Lefutott!");
        }

        private static void Manager_UserChanged(object? sender, UserChangedEventArgs<Users> e)
        {
            Console.WriteLine("Event");
            Console.WriteLine($"Old item: {e.oldUser}");
            Console.WriteLine($"New item: {e.newUser}");
        }
    }
}
