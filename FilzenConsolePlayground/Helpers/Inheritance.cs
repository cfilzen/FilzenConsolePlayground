using FilzenConsolePlayground.Types.Inheritance;

namespace FilzenConsolePlayground.Helpers
{
    public class Inheritance
    {
        public static void DoIt()
        {
            var myWagon = new Wagon();

            // Call the honk() method (From the Vehicle class) on the myWagon object
            myWagon.honk();

            Console.WriteLine($"From Wagon (Inheritance): {myWagon.brand} {myWagon.modelName}");
        }
    }
}
