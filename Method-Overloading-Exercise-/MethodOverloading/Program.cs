namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a = 29;
            var b = 55;

            int answer = AddMethods.Addition( a,  b);

           

            var decimalAnswer = AddMethods.Addition(a, b);

            var thirdAnswer = AddMethods.Addition(0, 1, true);

            Console.WriteLine($"int add: {answer} decimal add: {decimalAnswer}");
            Console.WriteLine(thirdAnswer);
        }
    }
}
