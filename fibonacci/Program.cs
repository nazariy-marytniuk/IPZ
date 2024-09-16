namespace fibonacci
{
    static class Program
    {
        static void Main(string[] args)
        {
            Fibonacci();
        }

        public static void Fibonacci()
        {
            uint temp;
            uint number = 1;

            Console.Write("Count -> ");

            if (!int.TryParse(Console.ReadLine(), out int numberOfElements))
            {
                Console.WriteLine("Not a number");
                Environment.Exit(0);
            }

            temp = number;

            Console.Write(number.ToString() + " ");
            for (int i = 0; i < numberOfElements; i++)
            {
                Console.Write(number.ToString() + " ");
                number = number + temp;
                temp = number - temp;
            }
        }
    }
}
