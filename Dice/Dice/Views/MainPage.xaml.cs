﻿using Dice.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace Dice.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private readonly MainViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();          
            viewModel = new MainViewModel();
            BindingContext = viewModel;
            TextDice.Text = "Six edge dice";
        }
        private void WallsSwitch_Toggled(object sender, ToggledEventArgs e)
        {

            if (e.Value == true)
            {
                viewModel.SwitchOn();
                TextDice.Text = "Ten edge dice";
            }
            else
            {
                viewModel.SwitchOff();
                TextDice.Text = "Six edge dice";
            }
        }
        public void Button_Clicked(object sender, EventArgs e)
        {
            DiceLabel.Text = viewModel.dice.Throw();
        }

        private void WallsSwitch_SizeChanged(object sender, EventArgs e)
        {

        }
    }
}
