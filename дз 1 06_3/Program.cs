namespace дз_1_06_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random number= new Random();
            Console.WriteLine(number.Next(-1000000,1000000));
            Console.WriteLine(number.Next(-1000000,1000000));
            Console.WriteLine(number.Next(-1000000,1000000));
            Console.WriteLine(number.Next(-1000000,1000000));
        }
    }
}
