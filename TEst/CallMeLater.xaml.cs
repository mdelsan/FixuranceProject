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
    public sealed partial class CallMeLater : Page
    {
        public CallMeLater()
        {
            this.InitializeComponent();
        }

        private void Main_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }

        private void Acceptance_Click(object sender, RoutedEventArgs e)
        {
            Person myPerson = new Person();

            myPerson.FirstName = FirstName.Text;
            myPerson.LastName = LastName.Text;
            myPerson.Email = Email.Text;
            myPerson.Phone = Phone.Text;

            if (MORNING.IsChecked == true)
                myPerson.ContactHour = "Morning";
            else if (AFTERNOON.IsChecked == true)
                myPerson.ContactHour = "Afternoon";
            else
                myPerson.ContactHour = "Night";

            if (WEEKDAY.IsChecked == true)
                myPerson.PreferredTime = "Weekday";
            else
                myPerson.PreferredTime = "Weekend";

            if (HOME.IsChecked.Value)
                myPerson.insurances.home = true;
            else
                myPerson.insurances.home = false;
            if (FAMILY.IsChecked.Value)
                myPerson.insurances.family = true;
            else
                myPerson.insurances.family = false;
            if (VEHICLE.IsChecked.Value)
                myPerson.insurances.vehicle = true;
            else
                myPerson.insurances.vehicle = false;
            if (HEALTH.IsChecked.Value)
                myPerson.insurances.health = true;
            else
                myPerson.insurances.health = false;
            if (PET.IsChecked.Value)
                myPerson.insurances.pet = true;
            else
                myPerson.insurances.pet = false;


            this.Frame.Navigate(typeof(CallMeLaterSaved), myPerson);
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CallMeLater), null);
        }
    }
}
