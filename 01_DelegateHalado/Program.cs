namespace _01_DelegateHalado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Administrator administrator = new Administrator();

            administrator.AddUser(new Users("Valaki1", "1234", false));
            administrator.AddUser(new Users("Valaki2", "4321", true));
            administrator.AddUser(new Users("Valaki3", "5678", true));
            administrator.AddUser(new Users("Valaki4", "8765", false));

            administrator.Kiiratas(Kiiratas);


            Console.WriteLine("\n\nLefutott");
        }

        static void Kiiratas(Users user)
        {
            Console.WriteLine($"UserName: {user.UserName} PassWord: {user.PassWord} Isadmin: {user.IsAdmin}");
        }
    }
}
