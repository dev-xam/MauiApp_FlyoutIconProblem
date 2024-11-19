using MauiApp3.Models;
using MauiApp3.PageModels;

namespace MauiApp3.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}