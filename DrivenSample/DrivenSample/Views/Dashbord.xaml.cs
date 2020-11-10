﻿using DrivenSample.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DrivenSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dashbord : ContentPage
    {
        public Dashbord()
        {
            InitializeComponent();
            BindingContext = new DashboardViewModel();

        }
    }
}