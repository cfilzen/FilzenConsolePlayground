using FilzenConsolePlayground.Types.Members;

namespace FilzenConsolePlayground.Helpers
{
    public class Members
    {
        public static void DoIt()
        {
            var myObj = new Bike
            {
                color = "red",
                maxSpeed = 20
            };

            Console.WriteLine($"From Bike (Members): {myObj.color} {myObj.maxSpeed}");
        }
    }
}
