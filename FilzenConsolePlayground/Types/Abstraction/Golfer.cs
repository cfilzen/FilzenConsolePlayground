namespace FilzenConsolePlayground.Types.Abstraction
{
    // Derived class (inherit from Animal)
    class Golfer : Golf
    {
        public override void golfSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The golfer swings the club.");
        }
    }
}
