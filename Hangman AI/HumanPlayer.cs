﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_AI
{
    class HumanPlayer : Player
    {
        public override char Guess()
        {
            NumberOfGuesses++;
            char guess = char.Parse(Console.ReadLine());
            return guess;
        }
    }
}
