﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestingStudentKnowledge
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new StartTestPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
