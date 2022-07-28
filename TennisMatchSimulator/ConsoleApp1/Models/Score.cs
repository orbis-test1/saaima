

using ConsoleApp1.Utility;

namespace ConsoleApp1.Models
{
    public class Score
    {
        private readonly IRandomGenerator _randomGenerator = new RandomGenerator();

        public Point Player1 { get; set; }

        public Point Player2 { get; set; }

        public Score()
        {
        }

        public void AssignScores()
        {
            while (!(Player1 == Point.Game || Player2 == Point.Game))
            {
                Player1 = _randomGenerator.GeneratePoint();
                Player2 = _randomGenerator.GeneratePoint();
                //Just a work around to make sure no two players win due to random generation of scores
                if (Player1 == Point.Game && Player2 == Point.Game)
                {
                    continue;
                }
            }

        }
    }


    public enum Point { Love, Fifteen, Thirty, Fourty, Game }
}
