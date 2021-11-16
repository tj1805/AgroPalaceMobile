using AgroPalaceMobile.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgroPalaceMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselPage : ContentPage
    {
        public CarouselPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            myList.ItemsSource = LoadCollection();

        }
        public  List<OnBoardingData> LoadCollection()
        {
            var groupData = new List<OnBoardingData>();

            //groupData.Add("ths is the first view");
            //groupData.Add("ths is the second view");
            //groupData.Add("this is the third view");
            groupData.Add(new OnBoardingData 
            {
                ImageUrl="Acarousel.jpg", 
                Title= "Lorem Ipsum", 
                Text= "simply dummy text of the printing and typesetting"
            });
            groupData.Add(new OnBoardingData 
            { 
                ImageUrl= "Bcarousel.jpg",
                Title= "Lorem Ipsum ", 
                Text= " simply dummy text of the printing and typesetting"
            });
            groupData.Add(new OnBoardingData 
            {
                ImageUrl="Ccarousel.jpg", 
                Title = "lorem ipsum" ,
                Text= "simply dummy text of the printing and typesetting"
            });
            return groupData;
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TabPage());
        }
    }

}