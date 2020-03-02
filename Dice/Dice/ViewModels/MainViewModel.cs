using System;
using System.Collections.Generic;
using System.Text;

namespace Dice.ViewModels
{
    class MainViewModel
    {
        public Models.Dice dice;

        //public string RandomNumber { get; private set; }

        public MainViewModel()
        {
            dice = new Models.Dice(6);
        }
        //public void Tap()
        //{
        //    RandomNumber = dice.Throw();
        //}
        public void SwitchOn()
        {
            dice = new Models.Dice(10);
        }
        public void SwitchOff()
        {
            dice = new Models.Dice(6);
        }
    }
}
