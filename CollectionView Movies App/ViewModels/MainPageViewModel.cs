using CollectionView_Movies_App.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CollectionView_Movies_App.ViewModels
{
    class MainPageViewModel
    {
        public ObservableCollection<Product> Products { get; set; }
        public MainPageViewModel()
        {
            Products = new ObservableCollection<Product>
            {
                new Product
                {
                    Name="Avengers:Endgame",
                    Year=2019,
                    Image="avengers.jpg"
                 
                },
                new Product
                {
                    Name="Inception",
                    Year=2010,
                    Image="inception.jpg"

                },
                new Product
                {
                    Name="Fury",
                    Year=2014,
                    Image="fury.jpg"

                },
                new Product
                {
                    Name="Wonder Woman",
                    Year=2019,
                    Image="ww.jpg"

                },
                new Product
                {
                    Name="Catch Me If You Can",
                    Year=2002,
                    Image="catchme.jpg"

                },

            };

            
                
            
    }
    }
}