using System;

namespace WorkShop10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Сalculator сalculator = new Сalculator();
            while (true)
            {
                Console.WriteLine("Введите два числа через пробел:");
                try
                {
                    string[] str = Console.ReadLine().Split(' ');
                    if (str.Length >= 3)
                        throw new Exception("Ожидалось два числа!");
                    a = int.Parse(str[0]);
                    b = int.Parse(str[1]);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message + " Неверный ввод!");
                    continue;
                }
                Console.WriteLine(сalculator.SumTwo(a, b));
            }
        }
    }
}
