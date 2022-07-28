namespace ConsoleApp1.Models
{
    public class Game
    {
        public int Id { get; set; }

        public int Player1 { get; set; }

        public int Player2 { get; set; }

        public List<Score> Scores { get; set; }

        public Game()
        {
            Scores = new List<Score>();
            Player1 = 0;
            Player2 = 0;
        }

        public void ProceedGame()
        {
            while (Player1 < 6 && Player2 < 6)
            {
                Id++;
                var score = new Score();
                score.AssignScores();
                Scores.Add(score);
                if (score.Player1 == Point.Game)
                {
                    Player1++;
                }
                else if (score.Player2 == Point.Game)
                {
                    Player2++;
                }
               
                Console.WriteLine($"Game {Id} : {Player1} - {Player2} ");
            }
        }
    }
}
