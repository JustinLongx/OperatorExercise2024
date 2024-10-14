namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
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

        }
    }
}
