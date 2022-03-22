using FilzenConsolePlayground.Types;
using Newtonsoft.Json;

namespace FilzenConsolePlayground.Helpers
{
    internal class PlayGolf
    {
        public static void DoIt()
        {
            var golf = new Golf()
            {
                Course = "Creekside",
                FirstName = "Chris",
                LastName = "Filzen",
                Handicap = 35,
                Holes = new()
                {
                    new Hole() { HoleNumber = 1, Par = 4, Shots = 4, Yardage = 365 },
                    new Hole() { HoleNumber = 2, Par = 3, Shots = 4, Yardage = 165 },
                    new Hole() { HoleNumber = 3, Par = 4, Shots = 4, Yardage = 370 },
                    new Hole() { HoleNumber = 4, Par = 5, Shots = 6, Yardage = 580 },
                    new Hole() { HoleNumber = 5, Par = 4, Shots = 5, Yardage = 415 },
                    new Hole() { HoleNumber = 6, Par = 3, Shots = 3, Yardage = 145 },
                    new Hole() { HoleNumber = 7, Par = 4, Shots = 5, Yardage = 440 },
                    new Hole() { HoleNumber = 8, Par = 3, Shots = 4, Yardage = 156 },
                    new Hole() { HoleNumber = 9, Par = 4, Shots = 4, Yardage = 379 },
                    new Hole() { HoleNumber = 10, Par = 4, Shots = 5, Yardage = 456 },
                    new Hole() { HoleNumber = 11, Par = 3, Shots = 3, Yardage = 170 },
                    new Hole() { HoleNumber = 12, Par = 4, Shots = 5, Yardage = 493 },
                    new Hole() { HoleNumber = 13, Par = 5, Shots = 6, Yardage = 630 },
                    new Hole() { HoleNumber = 14, Par = 4, Shots = 5, Yardage = 398 },
                    new Hole() { HoleNumber = 15, Par = 4, Shots = 4, Yardage = 439 },
                    new Hole() { HoleNumber = 16, Par = 5, Shots = 5, Yardage = 598 },
                    new Hole() { HoleNumber = 17, Par = 3, Shots = 5, Yardage = 140 },
                    new Hole() { HoleNumber = 18, Par = 4, Shots = 5, Yardage = 440 }
                },
            };

            golf.Score = golf.Holes.Sum<Hole>(x => x.Shots);
            golf.TotalYardage = golf.Holes.Sum<Hole>(x => x.Yardage);

            Console.WriteLine(JsonConvert.SerializeObject(golf));
        }
    }
}
