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
        Dictionary<int, string> imagesSixEdgeDice;
        public string ActualPicture { get; set; }

        public MainPage()
        {
            InitializeComponent();
            imagesSixEdgeDice = new Dictionary<int, string>();
            imagesSixEdgeDice.Add(1, "Dice1.jpg");
            imagesSixEdgeDice.Add(2, "Dice2.jpg");
            imagesSixEdgeDice.Add(3, "Dice3.jpg");
            imagesSixEdgeDice.Add(4, "Dice4.jpg");
            imagesSixEdgeDice.Add(5, "Dice5.jpg");
            imagesSixEdgeDice.Add(6, "Dice6.exe");
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
            string diceThrow = dice.Throw();
            DiceLabel.Text = diceThrow;

            ActualPicture = "/drawable/" + imagesSixEdgeDice.TryGetValue(diceThrow);



        }
    }
}
