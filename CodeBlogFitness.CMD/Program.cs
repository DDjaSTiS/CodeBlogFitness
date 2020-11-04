using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlogFitness.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует приложение CodeBlogFitness!");
            Console.WriteLine("Введите имя пользователя");

            var name = Console.ReadLine();
            Console.WriteLine("Введите пол");
            var gender = Console.ReadLine();
            Console.WriteLine("Введите дату рождения");
            var birthDate = DateTime.Parse(Console.ReadLine()); //toto: Переписать
        }
    }
}
