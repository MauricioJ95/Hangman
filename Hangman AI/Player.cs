using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_AI
{
    abstract class Player
    {
        public int NumberOfGuesses = 0;
        public abstract char Guess();
    }
    
}
