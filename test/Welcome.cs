using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Welcome
    {
        User _user;
        public Welcome(User user)
        {
            _user = user;
        }

        public void addUser()
        {
            Console.WriteLine("Введите имя");
            _user.Name = Console.ReadLine();

            Console.WriteLine($"Здравствуйте, {_user.Name}, введите ваш логин.");
            _user.Login = Console.ReadLine();

            Console.WriteLine($"{_user.Name}, проверяем наличие вашей подписки");
            Random random = new Random();
            _user.IsPremium = random.Next(2) == 1; // 50 na 50

            if (_user.IsPremium)
            {
                Console.WriteLine("Добро пожаловать");
            }
            else
            {
                Commercial.ShowAds();
            }
        }
    }
}
