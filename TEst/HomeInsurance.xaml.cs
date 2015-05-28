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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Net.Http;
using System.Text;



// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TEst
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomeInsurance : Page
    {
        public HomeInsurance()
        {
            this.InitializeComponent();
        }

        private void Main_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }

        private void GetPrice_Click(object sender, RoutedEventArgs e)
        {
            pricing myPrice = new pricing();
            String formatDate;
            myPrice.address = addressTextBox.Text;
            if (HOUSE.IsChecked == true)
                myPrice.houseType = "HOUSE";
            else if (APARTMENT.IsChecked == true)
                myPrice.houseType = "APARTMENT";
            else if (ROWHOUSE.IsChecked == true)
                myPrice.houseType = "ROWHOUSE";
            else if (PAIRHOUSE.IsChecked == true)
                myPrice.houseType = "PAIRHOUSE";
            else if (SUMMERHOUSE.IsChecked == true)
                myPrice.houseType = "SUMMERHOUSE";
            else 
                myPrice.houseType = "SAUNA";

            myPrice.area = areaSlider.Value.ToString();
            myPrice.buildYear = buildYearSlider.Value.ToString();
            myPrice.postalCode = postalCode.Text;
            formatDate = startDate.Date.Day+"."+startDate.Date.Month+"."+startDate.Date.Year;
            myPrice.insuranceStartDate = formatDate;
            if (ONE.IsChecked == true)
                myPrice.billingPeriod = "MONTH";
            else if (QUARTER.IsChecked == true)
                myPrice.billingPeriod = "QUARTER";
            else
                myPrice.billingPeriod = "YEAR";
            if (EUR.IsChecked == true)
                myPrice.currency = "EUR";
            else
                myPrice.currency = "USD";
            
            getPrice(myPrice);
            
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HomeInsurance), null);
        }


        public async void getPrice(pricing myPrice)
        {

            MemoryStream stream = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(pricing));
            ser.WriteObject(stream, myPrice);
            stream.Position = 0;
            StreamReader
            sr = new StreamReader(stream);
            string sr_string = sr.ReadToEnd();
            //For example let's get prices
            string RequestUrl = "http://185.20.136.51/sellertool/prices/";
            HttpClient clientOb = new HttpClient();
            string plain = "LUT" + ":" + "0gmsl48hgi_jhfiud76";
            string authString = System.Convert.ToBase64String(Encoding.UTF8.GetBytes(plain));
            clientOb.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", authString);
            clientOb.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await clientOb.PostAsync(RequestUrl, new StringContent(sr_string, Encoding.UTF8, "application/json"));

            using (HttpContent content = response.Content)
            {
                var result = await content.ReadAsStringAsync();
                DataContractJsonSerializer deSer = new DataContractJsonSerializer(typeof(pricing));
                MemoryStream str = new MemoryStream(Encoding.UTF8.GetBytes(result));
                pricing res = (pricing)deSer.ReadObject(str);
                this.Frame.Navigate(typeof(InsurancePricing), res);
            }
            
        }

    }
}
