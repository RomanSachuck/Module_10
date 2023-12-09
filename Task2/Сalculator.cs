using System;

namespace WorkShop10

{
    internal class Сalculator : ISumTwo
    {
        private Ilogger Logger { get; }
        public Сalculator(Ilogger logger)
        {
            Logger = logger;
        }

        public int SumTwo(int a, int b)
        {
            return a + b;
        }

        public void Run()
        {
            int a, b;
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
                    Logger.Error(ex.Message + " Неверный ввод!");
                    continue;
                }

                Logger.Event(SumTwo(a, b).ToString());
            }
        }
    }
}
