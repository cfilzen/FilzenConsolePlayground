using FilzenConsolePlayground.Types.Polymorphism;

namespace FilzenConsolePlayground.Helpers
{
    public class Polymorphism
    {
        public static void DoIt()
        {
            var myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
        }
    }
}
