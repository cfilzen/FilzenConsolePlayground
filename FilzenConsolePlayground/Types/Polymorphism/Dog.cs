namespace FilzenConsolePlayground.Types.Polymorphism
{
    class Dog : Animal
    {

        /* Override the base by adding the virtual keyword to the method
         * inside the base class, and by using the override keyword for each derived class methods:
         */

        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }
}
