﻿using Xamarin.Forms;

namespace WareHousePickPack
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new Views.DashboardPage());
        }
    }
}
