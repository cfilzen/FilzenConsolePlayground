using FilzenConsolePlayground.Types.Properties;

namespace FilzenConsolePlayground.Helpers
{
    public class Properties
    {
        public static void DoIt()
        {
            var myObjPerson = new Person
            {
                Name = "Liam"
            };

            Console.WriteLine($"From Person (Property): {myObjPerson.Name}");
        }
    }
}
