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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TEst
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CallMeLaterSaved : Page
    {
        public CallMeLaterSaved()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Person client = e.Parameter as Person;
            base.OnNavigatedTo(e);

            ClientName.Text = "Thank you for your interest in our insurances, " + client.FirstName;
            PhoneTextBlock.Text = client.Phone;
            EmailTextBlock.Text = client.Email;

            switch (client.ContactHour)
            {
                case "Morning":
                    Windows.UI.Xaml.Media.Imaging.BitmapImage MorningBitmap = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:///Assets/Images/Icons/agree_morning.png"));
                    ContactHourImage.Source = MorningBitmap;
                    break;

                case "Afternoon":
                    Windows.UI.Xaml.Media.Imaging.BitmapImage AfternoonBitmap = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:///Assets/Images/Icons/agree_afternoon.png"));
                    ContactHourImage.Source = AfternoonBitmap;
                    break;

                case "Night":
                    Windows.UI.Xaml.Media.Imaging.BitmapImage NightBitmap = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:///Assets/Images/Icons/agree_night.png"));
                    ContactHourImage.Source = NightBitmap;
                    break;
            }
            switch (client.PreferredTime)
            {
                case "Weekday":
                    Windows.UI.Xaml.Media.Imaging.BitmapImage WeekdayBitmap = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:///Assets/Images/Icons/agree_weekday.png"));
                    PreferredTimeImage.Source = WeekdayBitmap;
                    break;

                case "Weekend":
                    Windows.UI.Xaml.Media.Imaging.BitmapImage WeekendBitmap = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:///Assets/Images/Icons/agree_weekend.png"));
                    PreferredTimeImage.Source = WeekendBitmap;
                    break;

            }

            if (client.insurances.home) { 
                Windows.UI.Xaml.Media.Imaging.BitmapImage HomeBitmap = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:///Assets/Images/Icons/insurance_home.png"));
                InterestedInImage1.Source = HomeBitmap;
            }
            if (client.insurances.family)
            {
                Windows.UI.Xaml.Media.Imaging.BitmapImage FamilyBitmap = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:///Assets/Images/Icons/callme_family.png"));
                InterestedInImage2.Source = FamilyBitmap;
            }
            if (client.insurances.vehicle)
            {
                Windows.UI.Xaml.Media.Imaging.BitmapImage VehicleBitmap = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:///Assets/Images/Icons/callme_vehicle.png"));
                InterestedInImage3.Source = VehicleBitmap;
            }
            if (client.insurances.health)
            {
                Windows.UI.Xaml.Media.Imaging.BitmapImage HealthBitmap = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:///Assets/Images/Icons/callme_health.png"));
                InterestedInImage4.Source = HealthBitmap;
            }
            if (client.insurances.pet)
            {
                Windows.UI.Xaml.Media.Imaging.BitmapImage PetBitmap = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:///Assets/Images/Icons/callme_pet.png"));
                InterestedInImage5.Source = PetBitmap;
            }
        }

        private void Main_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }
    }
}
