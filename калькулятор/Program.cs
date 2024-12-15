using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

/*namespace caculator
{
    internal class program
    {
        static void Main(string[] args)
        {
            float one, two, result;
            char sign;
            Console.WriteLine("Дарова это я калькулятор давай накалякой первое число потом короче выбираешь знак (*,/,-,+) ну ручками вводишь ну ты понял а потом второе число ОК йоу!!!!");
            Console.WriteLine("Первое число");
            one = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Знак ");
            sign = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Втрое число");
            two = Convert.ToSingle(Console.ReadLine());
            if(sign=='+')
            {
                result = one + two;
                Console.WriteLine("Сумма ваших чисел" + result);
                Console.ReadKey();
            }
            else if (sign == '-')
            {
                result = one - two;
                Console.WriteLine("Разница ваших чисел" + result);
                Console.ReadKey();
            }
            else if (sign == '*')
            {
                result = one * two;
                Console.WriteLine("Произведение ваших чисел" + result);
                Console.ReadKey();
            }
            else if (sign == '/')
            {
                if (two == 0)
                {
                    Console.WriteLine("Ошибка. Делитель не может быть равным нулю.");
                    Console.ReadKey();
                }
                result = one / two;
                Console.WriteLine("Частность ваших чисел: " + result);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ты че ввел давай занова но нормально");
                Console.ReadKey();
            }
        }
    }
}*/
namespace Ugodayka;
class Program
{
    static void Main()
    {
        Random rand = new Random();
        int i = rand.Next(6);
        int count = 1;
        Console.WriteLine("Пк загадал число от 0 до 5");
        Console.WriteLine("Введите свое число у вас 3 попытки");
        int k = Convert.ToInt32(Console.ReadLine());
        while (count < 3)
        {
            if (i == k)
            {
                Console.WriteLine("Да! Компьютер загадал число " + k + "!");
                break;
            }
            else
            {
                count++;
                if (count == 4)
                {
                    Console.WriteLine("Увы, вы не отгодали загаданное число. Это было число " + i + "!");
                    break;
                }
                Console.WriteLine("Нет, это не число " + k + "! Попытка № " + count + ":");
                k = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Это было число: " + i);
        Console.ReadLine();
    }
}