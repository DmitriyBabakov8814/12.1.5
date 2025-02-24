namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Welcome welcome = new Welcome(user);
            welcome.addUser();
        }
    }
}
