using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ShrinkUIDemo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public ObservableCollection<HomePageItems> homeList;

        public MainPage()
        {
            InitializeComponent();
            homeList = new ObservableCollection<HomePageItems>();
            SetHomePageOptions();
        }

        private void SetHomePageOptions()
        {
            try
            {
                homeList.Clear();
                homeList.Add(new HomePageItems() { Title = "Option 1"});
                homeList.Add(new HomePageItems() { Title = "Option 2"});
                homeList.Add(new HomePageItems() { Title = "Option 3"});
                homeList.Add(new HomePageItems() { Title = "Option 4"});
                homeList.Add(new HomePageItems() { Title = "Option 5"});
                homeList.Add(new HomePageItems() { Title = "Option 6"});
                homeList.Add(new HomePageItems() { Title = "Option 7"});
                homeList.Add(new HomePageItems() { Title = "Option 8"});
                homeList.Add(new HomePageItems() { Title = "Option 9"});
                homeList.Add(new HomePageItems() { Title = "Option 10"});
                homelistview.ItemsSource = homeList;
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception:>>" + e);
            }
        }

        private async void HomeOptionsTapped(object sender, ItemTappedEventArgs e)
        {
            //await Navigation.PushModalAsync(new Page2());
        }
    }

    public class HomePageItems
    {
        public string Title { get; set; }
    }

}
