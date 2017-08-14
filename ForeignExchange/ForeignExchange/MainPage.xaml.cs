﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ForeignExchange
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ConvertButton.Clicked += ConvertButton_Clicked;
        }

        void ConvertButton_Clicked(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty((PesosEntry.Text)))
            {
                DisplayAlert("Error", "You must enter a value in pesos", "Accept");
                return;
            }

            decimal pesos = 0;
            decimal.TryParse(PesosEntry.Text, out pesos);

            var dollars = pesos / 2994.01198M;
            var euros = pesos / 3514.95509M;
            var pounds = pesos / 3894.50599M;

            DollarsEntry.Text = string.Format("{0:C2}", dollars);
            EurosEntry.Text = string.Format("{0:C2}", euros);
            PoundsEntry.Text = string.Format("{0:C2}", pounds);
        }
    }
}
