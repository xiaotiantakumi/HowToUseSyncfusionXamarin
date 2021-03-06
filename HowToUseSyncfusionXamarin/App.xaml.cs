﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HowToUseSyncfusionXamarin.ColorPicker;
using HowToUseSyncfusionXamarin.GettingStarted;
using Xamarin.Forms;

namespace HowToUseSyncfusionXamarin
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("");
            InitializeComponent();
            MainPage = new ChipsAsColorPicker();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
