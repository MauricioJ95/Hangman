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
            char[] chars = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            index++;
            return chars[index - 1];
        }
    }
}
