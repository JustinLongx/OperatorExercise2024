namespace OperatorExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            var sum = a + b;
            var subtract = a - b;
            var multiply = a * b;
            var division = a / b;

            int quotient = a / b;
            int remainder = a % b;



            Console.WriteLine($"{a}/{b} is {division} remainder {remainder}");

            Console.WriteLine("What is the radius of your circle ?");
            var radius = double.Parse(Console.ReadLine());

            AreaOfACircle(radius);

            Console.WriteLine(AreaOfACircle(radius));

            Console.ReadLine();
        }

        public static double AreaOfACircle(double radius)
        {
            
            

            var area = Math.PI * Math.Pow(radius, 2);
            return area;
            

        }
    }
}
