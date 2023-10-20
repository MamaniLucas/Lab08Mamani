using Lab08Mamani.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Lab08Mamani.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}