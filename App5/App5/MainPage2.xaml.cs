﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App5
{
    public partial class MainPage2 : ContentPage
    {
        public MainPage2()
        {
            InitializeComponent();
            ButtonBMI.Clicked += ButtonClickEvent;
            ButtonBMI2.Clicked += ButtonClickEvent2;
        }

        private void ButtonClickEvent2(object sender, EventArgs e)
        {
            float height = float.Parse(EntryHeight.Text);
            Navigation.PushModalAsync(new NavigationPage(new BmiResult(height)));
        }

        private void ButtonClickEvent(object sender, EventArgs e)
        {
            float height = float.Parse(EntryHeight.Text);
            height = height * height;

            float weight = int.Parse(EntryWeight.Text);
            weight = weight/height;

            LabelResult.Text = "BMI=" + weight;

        }
    }
}
