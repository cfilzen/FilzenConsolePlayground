namespace FilzenConsolePlayground.Types.Abstraction
{
    // Abstract class
    abstract class Golf
    {
        // Abstract method (does not have a body)
        public abstract void golfSound();
        
        // Regular method
        public void drive()
        {
            Console.WriteLine("Ping!!");
        }
    }
}
