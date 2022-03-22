using FilzenConsolePlayground.Types.Abstraction;

namespace FilzenConsolePlayground.Helpers
{
    public class Abstraction
    {
        public static void DoIt()
        {
            var golfer = new Golfer(); // Create a Pig object
            golfer.golfSound();  // Call the abstract method
            golfer.drive();  // Call the regular method
        }
    }
}
