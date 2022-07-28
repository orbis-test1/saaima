namespace ConsoleApp1.Models
{
    public class Set
    {
        public int Number { get; set; }

        public List<Game> Games { get; set; }

        public int Player1 { get; set; }

        public int Player2 { get; set; }

        public List<Set> RunSets()
        {
            var sets = new List<Set>();
            while (Number < 3)
            {
                Game newGame = InitiateNewGame();
                newGame.ProceedGame();
                Player1 = newGame.Player1;
                Player2 = newGame.Player2;
                Console.WriteLine($"Set {Number} : {Player1} - {Player2} ");
                sets.Add(new Set { Number = Number, Player1 = Player1, Player2 = Player2 });
            }
            return sets;
        }

        private Game InitiateNewGame()
        {
            Number++;
            Games = new List<Game>();
            Player1 = 0;
            Player2 = 0;
            var newGame = new Game();
            return newGame;
        }
    }
}
