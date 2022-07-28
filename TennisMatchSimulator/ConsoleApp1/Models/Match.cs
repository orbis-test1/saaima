namespace ConsoleApp1.Models
{
    public class Match
    {
        public Match(string player1, string player2)
        {
            Player1 = player1;
            Player2 = player2;

        }
        public string Player1 { get; set; }

        public string Player2 { get; set; }

        public List<Set> Sets { get; set; }

        public void InitiateMatch()
        {
            Console.WriteLine($"Initiating Match with Player 1: {Player1} and Player 2: {Player2} ");
            Sets = new List<Set>();
            var newSet = new Set();
            Sets = newSet.RunSets();
            int p1 = 0, p2 = 0;
            FindWinner(ref p1, ref p2);
            Console.WriteLine("The winner is " + ((p1 > p2) ? Player1 : Player2));
            Console.ReadLine();
        }

        private void FindWinner(ref int p1, ref int p2)
        {
            foreach (var set in Sets)
            {
                if (set.Player1 > set.Player2)
                {
                    p1++;
                }
                else
                {
                    p2++;
                }
            }
        }
    }
}
