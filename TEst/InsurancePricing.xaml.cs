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
    public sealed partial class InsurancePricing : Page
    {
        public InsurancePricing()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            pricing finalPrice = e.Parameter as pricing;
            base.OnNavigatedTo(e);
            EstimatedPriceTextBlock.Text = finalPrice.price.price;
            if (finalPrice.price.currency == "EUR") { 
                CurrencyTextBlock.Text = "€";
            }
            else
            {
                CurrencyTextBlock.Text = "$";
            }

            switch (finalPrice.houseType)
            {
                case "HOUSE":
                    Windows.UI.Xaml.Media.Imaging.BitmapImage HouseBitmap = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:///Assets/Images/Icons/insurance_house.png"));
                    HouseTypeImage.Source = HouseBitmap;
                    break;

                case "APARTMENT":
                    Windows.UI.Xaml.Media.Imaging.BitmapImage ApartmentBitmap = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:///Assets/Images/Icons/insurance_apartment.png"));
                    HouseTypeImage.Source = ApartmentBitmap;
                    break;

                case "PAIRHOUSE":
                    Windows.UI.Xaml.Media.Imaging.BitmapImage PairHouseBitmap = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:///Assets/Images/Icons/insurance_pairHouse.png"));
                    HouseTypeImage.Source = PairHouseBitmap;
                    break;

                case "RAWHOUSE":
                    Windows.UI.Xaml.Media.Imaging.BitmapImage RawHouseBitmap = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:///Assets/Images/Icons/insurance_rawHouse.png"));
                    HouseTypeImage.Source = RawHouseBitmap;
                    break;

                case "SAUNA":
                    Windows.UI.Xaml.Media.Imaging.BitmapImage SaunaBitMap = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:///Assets/Images/Icons/insurance_sauna.png"));
                    HouseTypeImage.Source = SaunaBitMap;
                    break;

                case "SUMMERHOUSE":
                    Windows.UI.Xaml.Media.Imaging.BitmapImage SummerHouseBitmap = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:///Assets/Images/Icons/insurance_summerHouse.png"));
                    HouseTypeImage.Source = SummerHouseBitmap;
                    break;
            }
            AreaTextBlock.Text = finalPrice.area;
            YearTextBlock.Text = finalPrice.buildYear;
            PostalCodeTextBlock.Text = finalPrice.postalCode;
            AddressTextBlock.Text = finalPrice.address;
            DateTextBlock.Text = finalPrice.insuranceStartDate;

            switch (finalPrice.price.billingPeriod)
            {
                case "MONTH":
                    Windows.UI.Xaml.Media.Imaging.BitmapImage OneBitmap = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:///Assets/Images/Icons/insurance_1.png"));
                    BillingPeriodImage.Source = OneBitmap;
                    break;

                case "QUARTER":
                    Windows.UI.Xaml.Media.Imaging.BitmapImage FourBitmap = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:///Assets/Images/Icons/insurance_4.png"));
                    BillingPeriodImage.Source = FourBitmap;
                    break;

                case "YEAR":
                    Windows.UI.Xaml.Media.Imaging.BitmapImage TwelveBitmap = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:///Assets/Images/Icons/insurance_12.png"));
                    BillingPeriodImage.Source = TwelveBitmap;
                    break;
            }    
        }


        private void Main_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }

        private void Agree_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InsuranceContact), null);
        }

        private void Modify_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HomeInsurance), null);
            
        }


    }
}
