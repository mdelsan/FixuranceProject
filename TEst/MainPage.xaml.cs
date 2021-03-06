﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TEst
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void HomeInsurances_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HomeInsurance), null);
        }

        private void CallMeLater_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CallMeLater), null);
        }

        private void InnerCircle_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InnerCircle), null);
        }

        private void Exit_Application(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }
    }
}
