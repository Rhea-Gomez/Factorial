namespace Factorial
{
    internal class Program
    {
        public static int Factorial(int num)
        {
            int factorial = num;
            if(num == 1)
            {
                return factorial;
            }
            return factorial * Factorial(num - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number to calculate its factorial: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Factorial of " + number + " is " +Factorial(number));

        }
    }
}
