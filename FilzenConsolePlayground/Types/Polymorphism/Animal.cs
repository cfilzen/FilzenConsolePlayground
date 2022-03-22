namespace FilzenConsolePlayground.Types.Polymorphism
{
    class Animal //Base Class Parent
    {
        /* NOTE: When implementing Polymorphism, the virtual (base class) and 
         * override (children) keywords are needed. */

        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
}
