using ConsoleApp1.Models;

namespace ConsoleApp1.Utility
{
    public class RandomGenerator : IRandomGenerator
    {
        private readonly Random _random=new Random();
     
        public Point GeneratePoint()
        {
            return (Point)_random.Next(0, Enum.GetNames(typeof(Point)).Length);
        }
    }
}
