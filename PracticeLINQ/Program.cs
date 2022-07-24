using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace PracticeLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> favoriteGames = new List<string>() {"sims","Animal Crossing", "Call of Duty", "Outward", "No man's sky"};
            favoriteGames = favoriteGames.OrderBy(x => x.Length).ToList();
            foreach (var item in favoriteGames)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
