using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgClass;


namespace Alg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string a = "Как вас зовут?";
            //Console.WriteLine(a);
            //string Name = Console.ReadLine();
            //Console.WriteLine($"Привет " + Name);
            //Console.WriteLine("Сколько элементов будет в массиве?");
            //int count = Convert.ToInt32(Console.ReadLine());
            //string[] array;
            //array = new string[count];
            //for (int i = 0; i < count; i++)
            //{
            //    array[i] = Console.ReadLine();
            //}
            //Console.WriteLine("Все элементы записаны");

            //Console.WriteLine("Введите свой возраст");
            //byte age = Convert.ToByte(Console.ReadLine());
            //if (age > 13) 
            //{
            //    Console.WriteLine("Вы успешно зарегистрированы");
            //}
            //else
            //    Console.WriteLine("Пользователи младше 14 лет не могут пройти регистрацию");
            List<User> users = new List<User>
        {
            new User { Login = "user1", Name = "Иван", IsPremium = true },
            new User { Login = "user2", Name = "Мария", IsPremium = false },
        };

            Console.Write("Введите логин: ");
            string inputLogin = Console.ReadLine();

            User user = FindUser(users, inputLogin);
            if (user != null)
            {
                GreetUser(user);
                if (!user.IsPremium)
                {
                    user.ShowAds();
                }
            }
            else
            {
                Console.WriteLine("Пользователь с таким логином не найден.");
            }
            Console.ReadKey();
        }

        static void GreetUser(User user)
        {
            Console.WriteLine($"Привет, {user.Name} ({user.Login})!");
        }

        static User FindUser(List<User> users, string login)
        {
            foreach (User user in users)
            {
                if (user.Login == login)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
