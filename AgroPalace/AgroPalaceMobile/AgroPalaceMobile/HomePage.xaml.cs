using AgroPalaceMobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgroPalaceMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            var fruits = new List<Fruit> {
            new Fruit
            {
                Name = "Apple",
                Description = "This stuff is good fro the body",
                Price=12.95,
                ImageUrl="mangoo.jpg",
            },
              new Fruit
              {
                  Name = "Apple",
                  Description = "This stuff is good fro the body",
                     Price=12.95,
                  ImageUrl = "mangoo.jpg",
              },
               new Fruit
              {
                  Name = "Apple",
                  Description = "This stuff is good fro the body",
                     Price=12.95,
                  ImageUrl = "mangoo.jpg",
              },
                new Fruit
              {
                  Name = "Apple",
                  Description = "This stuff is good fro the body",
                     Price=12.95,
                  ImageUrl = "mangoo.jpg",
              },
                 new Fruit
              {
                  Name = "Apple",
                  Description = "This stuff is good fro the body",
                     Price=12.95,
                  ImageUrl = "mangoo.jpg",
              },
                  new Fruit
              {
                  Name = "Apple",
                  Description = "This stuff is good fro the body",
                     Price=12.95,
                  ImageUrl = "Bcarousel.jpg",
              },
                   new Fruit
              {
                  Name = "Apple",
                  Description = "This stuff is good fro the body",
                     Price=12.95,
                  ImageUrl = "Bcarousel.jpg",
              },
          };
         FruitCollectionView.ItemsSource = fruits;

        }
       
    }
}