namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var c = TempConverter.FahrenheitToCelsius(77);
            var f = TempConverter.CelsiusToFahrenheit(27);

            Console.WriteLine($"Celsius: {c}");
            Console.WriteLine($"Fahrenheit: {f}");
        }
    }
}
