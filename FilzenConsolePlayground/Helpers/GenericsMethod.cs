namespace FilzenConsolePlayground.Helpers
{
    public class GenericsMethod
    {
        public static void DoIt()
        {
            //Generics (Methods)
            var cities = new FilzenConsolePlayground.Types.Generics.Method.DataStore<string>();
            cities.AddOrUpdate(0, "Mumbai");
            cities.AddOrUpdate(1, "Chicago");
            cities.AddOrUpdate(2, "London");
            cities.AddOrUpdate(3, "New York");
            cities.AddOrUpdate(4, "Sarasota");
            cities.AddOrUpdate(5, "Atlanta");
            cities.AddOrUpdate(6, "Denver");
            cities.AddOrUpdate(7, "Dallas");
            cities.AddOrUpdate(8, "Miami");
            cities.AddOrUpdate(9, "Nashville");

            Console.WriteLine("What did we get in generic methods (string)?");

            int i = 0;
            while (i <= 9)
            {
                Console.WriteLine($"Value {i}: {cities.GetData(i)}");
                i++;
            }


            var empIds = new FilzenConsolePlayground.Types.Generics.Method.DataStore<int>();
            empIds.AddOrUpdate(0, 50);
            empIds.AddOrUpdate(1, 65);
            empIds.AddOrUpdate(2, 89);

            Console.WriteLine("What did we get in generic methods (int)?");

            int k = 0;
            while (k <= 2)
            {
                Console.WriteLine($"Value {k}: {empIds.GetData(k)}");
                k++;
            }

            var printer = new FilzenConsolePlayground.Types.Generics.Method.Printer();
            printer.Print<int>(100);
            printer.Print(200); // type infer from the specified value
            printer.Print<string>("Hello");
            printer.Print("World!"); // type infer from the specified value
        }
    }
}
