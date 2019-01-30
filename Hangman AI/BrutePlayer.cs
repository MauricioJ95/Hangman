using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_AI
{
    class BrutePlayer : Player
    {
        int index = 0;
        public override char Guess()
        {
            NumberOfGuesses++;
            char[] chars = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            index++;
            Console.WriteLine(chars[index - 1]);
            return chars[index - 1];
        }
    }
}
