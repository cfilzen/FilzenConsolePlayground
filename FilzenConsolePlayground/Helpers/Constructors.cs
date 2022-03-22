using FilzenConsolePlayground.Types.Constructors;

namespace FilzenConsolePlayground.Helpers
{
    public class Constructors
    {
        public static void DoIt()
        {
            var Ford = new Car();  // Create an object of the Car Class (this will call the constructor)
            Console.WriteLine($"From Car (Constructor): {Ford.model}");  // Print the value of model
        }
    }
}
