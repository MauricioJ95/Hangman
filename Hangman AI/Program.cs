using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_AI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sup");
            Player hp = new HumanPlayer();
            HangmanGame hp2 = new HangmanGame(hp);
            Player rp = new RandomPlayer();
            HangmanGame rp2 = new HangmanGame(rp);
            Player bp = new BrutePlayer();
            HangmanGame bp2 = new HangmanGame(bp);
            Player sp = new SmartPlayer();
            HangmanGame sp2 = new HangmanGame(sp);

            Console.WriteLine($"Human player won in {hp.NumberOfGuesses} guesses.");
            Console.WriteLine($"Random player won in {rp.NumberOfGuesses} guesses.");
            Console.WriteLine($"Brute player won in {bp.NumberOfGuesses} guesses.");
            Console.WriteLine($"Smart player won in {sp.NumberOfGuesses} guesses.");
        }
    }
}
