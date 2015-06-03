using System;
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
using System.ComponentModel;
using Windows.UI.Popups;
using Windows.UI.Xaml.Markup;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace FIXurance.CustomUserControls
{
    public sealed partial class ImageRadioButton : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        String imageSource;
        //Default values, can be changed.
        Thickness customBorderThickness = new Thickness(4);
        SolidColorBrush customBorderBrush = new SolidColorBrush(Windows.UI.Colors.DarkGray);

        public ImageRadioButton()
        {
                this.DataContext = this;
                this.InitializeComponent();
        }

        public Thickness CustomBorderThickness
        {
            get
            {
                return this.customBorderThickness;
            }
            set
            {
                this.customBorderThickness = value;
                OnPropertyChanged("CustomBorderThickness");
            }
        }

        public SolidColorBrush CustomBorderBrush
        {
            get
            {
                if (MyRadioButton.IsChecked == true)
                    return customBorderBrush;
                else return new SolidColorBrush(Windows.UI.Colors.Transparent);
            }
            set
            {
                customBorderBrush = value;
                OnPropertyChanged("CustomBorderBrush");
            }
        }

        public String ImageSource
        {
            get
            {
                return imageSource;
            }
            set
            {
                imageSource = value;
                OnPropertyChanged("ImageSource");
            }
        }

        public String GroupName
        {
            get
            {
                return MyRadioButton.GroupName;
            }
            set
            {
                MyRadioButton.GroupName = value;
            }
        }

        public bool IsChecked
        {
            get
            {                
                return (bool)MyRadioButton.IsChecked;
            }
            set
            {
                MyRadioButton.IsChecked = value;
            }
        }

        private void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        private void RadioButtonValueChanged(object sender, RoutedEventArgs e)
        {
            OnPropertyChanged("CustomBorderBrush");
        }
    }
}