namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;

            int b = 4;

            int sum = a + b;

            int product = a * b;

            int difference = a - b;

            int quotient = a / b;

            int remainder = a % b;

            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

                Console.WriteLine($"{a}*{b} is {product}, {a}-{b} is {difference}, and {a}+{b} is {sum}");
            }
        }
    }
}
