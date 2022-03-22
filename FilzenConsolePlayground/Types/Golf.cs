namespace FilzenConsolePlayground.Types
{
    public class Golf : Game
    {
        public string? Course { get; set; }
        public int? TotalYardage { get; set; }

    }

    public class Hole
    {
        public int? HoleNumber { get; set; }
        public int? Par { get; set; }
        public int? Shots { get; set; }
        public int? Yardage { get; set; }
    }

    public class Game : Player
    {
        public List<Hole>? Holes { get; set; }
        public int? Score { get; set; }
    }

    public class Player
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public decimal? Handicap { get; set; }
    }
}
