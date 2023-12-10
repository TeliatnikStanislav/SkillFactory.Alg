using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "Как вас зовут?";
            Console.WriteLine(a);
            string Name = Console.ReadLine();
            Console.WriteLine($"Привет " + Name);
            Console.WriteLine("Сколько элементов будет в массиве?");
            int count = Convert.ToInt32(Console.ReadLine());
            string[] array;
            array = new string[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = Console.ReadLine();
            }
            Console.WriteLine("Все элементы записаны");

            Console.WriteLine("Введите свой возраст");
            byte age = Convert.ToByte(Console.ReadLine());
            if (age > 13) 
            {
                Console.WriteLine("Вы успешно зарегистрированы");
            }
            else
                Console.WriteLine("Пользователи младше 14 лет не могут пройти регистрацию");
            Console.ReadKey();

        }
    }
}
