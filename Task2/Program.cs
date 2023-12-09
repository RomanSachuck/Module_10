namespace WorkShop10

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ilogger logger = new Logger();
            Сalculator сalculator = new Сalculator(logger);
            сalculator.Run();
        }
    }
}
