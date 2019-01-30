using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_AI
{
    class RandomPlayer : Player
    {
        public override char Guess()
        {
            NumberOfGuesses++;
            char[] chars = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            Random r = new Random();
            int i = r.Next(chars.Length);
            Console.WriteLine(chars[i]);
            return chars[i];
        }
    }
}
