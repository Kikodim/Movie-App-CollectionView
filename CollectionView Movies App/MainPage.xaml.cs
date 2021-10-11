using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using CollectionView_Movies_App.ViewModels;

namespace CollectionView_Movies_App
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();

        }
    }
}
