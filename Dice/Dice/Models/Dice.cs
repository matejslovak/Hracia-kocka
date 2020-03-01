using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Dice.Models
{
    class Dice
    {
        public int CountOfWalls { get; set; }

        public Dice(int countOfWalls)
        {
            CountOfWalls = countOfWalls; 
        }

        public string Throw()
        {
            Random number = new Random();
            return number.Next(1, CountOfWalls + 1).ToString();
        }
    }
}
