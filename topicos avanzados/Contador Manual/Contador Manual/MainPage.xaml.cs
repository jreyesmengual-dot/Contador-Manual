﻿namespace Contador_Manual
{
    public partial class MainPage : ContentPage
    {
       // _conteo lleva el conteo de la aplicacion
        private int _conteo;

        public MainPage()
        {
            InitializeComponent();
            _conteo = 0;
            ConteoLabel.Text= _conteo.ToString();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            _conteo = 0;
            
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            _conteo++;
              ConteoLabel.Text = _conteo.ToString();
        }

    }
}
