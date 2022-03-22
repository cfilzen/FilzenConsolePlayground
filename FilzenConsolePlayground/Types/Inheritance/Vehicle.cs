namespace FilzenConsolePlayground.Types.Inheritance
{
    class Vehicle //base class (parent)
    {
        public string brand = "Big Wagons";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("From Wagon Base Class: Tuut, tuut!");
        }
    }

    //NOTE: If you try to access a sealed class, C# will generate an error:
    //sealed class Vehicle
    //{}

    //class Car : Vehicle
    //{}
}