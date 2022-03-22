using FilzenConsolePlayground.Types.Generics.Class;

namespace FilzenConsolePlayground.Helpers
{
    public class GenericsClass
    {
        public static void DoIt()
        {
            var strStore = new DataStore<string>
            {
                Data = "strStore output: Hello Chris!"
            };

            Console.WriteLine(strStore.Data);

            var intStore = new DataStore<int>
            {
                Data = 100
            };

            Console.WriteLine($"DataStore int value: { intStore.Data.ToString()}");

            FilzenConsolePlayground.Types.Generics.Class.KeyValuePair<int, string> kvp1 = new()
            {
                Key = 100,
                Value = "Hundred"
            };

            Console.WriteLine($"KayValuePair (int,string) output: {kvp1.Key}, {kvp1.Value}");

            FilzenConsolePlayground.Types.Generics.Class.KeyValuePair<string, string> kvp2 = new()
            {
                Key = "IT",
                Value = "Information Technology"
            };

            Console.WriteLine($"KeyValuePair (string, string) output: {kvp2.Key}, {kvp2.Value}");
        }
    }
}
