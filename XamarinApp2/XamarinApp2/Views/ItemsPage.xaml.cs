using Xamarin.Forms;
using System.Collections.ObjectModel;
using XamarinApp2.Models;
using System.Threading.Tasks;
using System.Threading;

namespace XamarinApp2.Views
{
    public partial class ItemsPage : ContentPage
    {
        ObservableCollection<Item> items = new ObservableCollection<Item>();
        public ObservableCollection<Item> Items { get { return items; } }

        public ItemsPage()
        {
            InitializeComponent();
            ItemsView.ItemsSource = items;

            for (int i = 0; i < 1000; i++)
            {
                items.Add(new Item { Text = "Animacja #" + (i + 1) });
            }
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}

