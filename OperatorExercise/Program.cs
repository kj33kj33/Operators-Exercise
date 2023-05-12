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

            Console.WriteLine("Hi, what is your circle's radius?");

            var radius = double.Parse(Console.ReadLine());

            Console.WriteLine($"The area of a circle with radius {radius} is " + AreaOfCircle(radius));

            //var i = 3;
            //var j = 4;
            //var k = ++i * j++;

            //Console.WriteLine(k);
        }

        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);

            return area;
        }
    }
}
