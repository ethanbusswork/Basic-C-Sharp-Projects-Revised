using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() { "Ethan", "Jim", "Dwight" };
            game.ListPlayers();
            Console.ReadLine();

            Deck deck = new Deck();

            deck.Shuffle(5);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);

            }
            Console.WriteLine("Number of cards in deck: " + deck.Cards.Count);
            Console.Read();
        }
    }
}
