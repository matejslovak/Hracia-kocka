using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Dice
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
            dice = new Dice(6);
            TextDice.Text = "SixEdgeDice";
        }
        private Dice dice; 
        public void WallsSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            if (e.Value == false)
            {
                dice = new Dice(6);
                TextDice.Text = "SixEdgeDice";
            }
            else
            {
                dice = new Dice(10);
                TextDice.Text = "TenEdgeDice";
            }
        }

        public void Button_Clicked(object sender, EventArgs e)
        {
            DiceLabel.Text = dice.Throw();     
        }
    }
}
