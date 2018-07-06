﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipCalculator.ViewModel;
using Xamarin.Forms;

namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {        
        public MainPage()
        {
            InitializeComponent();

            // ENLAZAMOS EL BINDINGCONTEXT CON EL "CONTROLADOR"
            this.BindingContext = new MainPageViewModel();
        }
    }
}
