using ListPMCaller.Views.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ListPMCallerBee.Views.Requests;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ListPM_Caller.Views.HomeTab
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeTabPage : ContentView
    {
        public ObservableCollection<HomePageItems> homeList;
        string mode;
        public HomeTabPage()
        {
            InitializeComponent();
            homeList = new ObservableCollection<HomePageItems>();
            SetMode();
        }

        private void SetMode()
        {
            try
            {
                mode = Preferences.Default.Get("mode", "light");
                if (mode == "light")
                {
                    LightMode();
                }
                else if (mode == "dark")
                {
                    DarkMode();
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("Exception:>>" + e);
                Preferences.Default.Set("mode", "light");
                mode = "light";
                LightMode();
            }
            SetHomePageOptions();
        }

        private void LightMode()
        {
            try
            {
                //root_stack.BackgroundColor = Colors.White;
                home_layout.BackgroundColor = Colors.White;
                homelistview.BackgroundColor = Colors.White;
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception:>>" + e);
            }
        }

        private void DarkMode()
        {
            try
            {
                //root_stack.BackgroundColor = Color.FromArgb("#434343");
                home_layout.BackgroundColor = Color.FromArgb("#434343");
                homelistview.BackgroundColor = Color.FromArgb("#434343");
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception:>>" + e);
            }
        }

        private void SetHomePageOptions()
        {
            try
            {
                homeList.Clear();
                homeList.Add(new HomePageItems() { Title = "Option1", BGColor = Color.FromArgb("#e4e4e4"), TextColor = Colors.Black, ImageSource = "ic_black_right_arrow_xx.png" });
                homeList.Add(new HomePageItems() { Title = "Option2", BGColor = Color.FromArgb("#e4e4e4"), TextColor = Colors.Black, ImageSource = "ic_black_right_arrow_xx.png" });
                homeList.Add(new HomePageItems() { Title = "Option3", BGColor = Color.FromArgb("#e4e4e4"), TextColor = Colors.Black, ImageSource = "ic_black_right_arrow_xx.png" });
                homeList.Add(new HomePageItems() { Title = "Option4", BGColor = Color.FromArgb("#e4e4e4"), TextColor = Colors.Black, ImageSource = "ic_black_right_arrow_xx.png" });
                homeList.Add(new HomePageItems() { Title = "Option5", BGColor = Color.FromArgb("#e4e4e4"), TextColor = Colors.Black, ImageSource = "ic_black_right_arrow_xx.png" });
                homeList.Add(new HomePageItems() { Title = "Option6", BGColor = Color.FromArgb("#e4e4e4"), TextColor = Colors.Black, ImageSource = "ic_black_right_arrow_xx.png" });
                homeList.Add(new HomePageItems() { Title = "Option7", BGColor = Color.FromArgb("#e4e4e4"), TextColor = Colors.Black, ImageSource = "ic_black_right_arrow_xx.png" });
                homeList.Add(new HomePageItems() { Title = "Option8", BGColor = Color.FromArgb("#e4e4e4"), TextColor = Colors.Black, ImageSource = "ic_black_right_arrow_xx.png" });
                homeList.Add(new HomePageItems() { Title = "Option9", BGColor = Color.FromArgb("#e4e4e4"), TextColor = Colors.Black, ImageSource = "ic_black_right_arrow_xx.png" });
                homelistview.ItemsSource = homeList;
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception:>>" + e);
            }
        }

        private async void HomeOptionsTapped(object sender, ItemTappedEventArgs e)
        {
            try
            {
                var selectedItem = (HomePageItems)e.Item;
                string title = "";
                if (selectedItem != null)
                {
                    selectedItem.BGColor = Color.FromArgb("#a1a1a1");
                    selectedItem.TextColor = Colors.White;
                    selectedItem.ImageSource = "ic_white_right_arrow_xx.png";
                    await Task.Delay(TimeSpan.FromSeconds(0.25));
                    title = selectedItem.Title;

                    if (title == "Option1")
                    {
                        await Navigation.PushModalAsync(new CommentsPage());
                    }
                    else if (title == "Option2")
                    {
                        await Navigation.PushModalAsync(new CreateRequestPage());
                    }
                    selectedItem.BGColor = Color.FromArgb("#e4e4e4");
                    selectedItem.TextColor = Colors.Black;
                    selectedItem.ImageSource = "ic_black_right_arrow_xx.png";
                }
                homelistview.SelectedItem = null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception:>>" + ex);
            }
        }

        private void ShowKeypad(object sender, EventArgs e)
        {
            try
            {
                //WeakReferenceMessenger.Default.Send(new TabSelectionMessage("child-1"));
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception:>>" + ex);
            }
        }

        private void ShowHistory(object sender, EventArgs e)
        {
            try
            {
                //WeakReferenceMessenger.Default.Send(new TabSelectionMessage("child-2"));
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception:>>" + ex);
            }
        }

        private void ShowContacts(object sender, EventArgs e)
        {
            try
            {
                //WeakReferenceMessenger.Default.Send(new TabSelectionMessage("child-3"));
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception:>>" + ex);
            }
        }

        private void ShowMessages(object sender, EventArgs e)
        {
            try
            {
                //WeakReferenceMessenger.Default.Send(new TabSelectionMessage("child-4"));
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception:>>" + ex);
            }
        }

        private async void SettingPages(object sender, EventArgs e)
        {
            try
            {
                //await Navigation.PushModalAsync(new SettingsPage("normalsettings"));
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception:>>" + ex);
            }
        }

        private async void LoadNotificationsPage(object sender, EventArgs e)
        {
            try
            {
                //Utility.isShowProgress = true;
                //await Navigation.PushModalAsync(new NotificationsPage());
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception:>>" + ex);
            }
        }
    }

    public class HomePageItems : INotifyPropertyChanged
    {
        public string Title { get; set; }

        private Color bgColor;
        public Color BGColor
        {
            set
            {
                if (value != null)
                {
                    bgColor = value;
                    NotifyPropertyChanged();
                }
            }
            get
            {
                return bgColor;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Color textColor;
        public Color TextColor
        {
            set
            {
                if (value != null)
                {
                    textColor = value;
                    NotifyPropertyChanged();
                }
            }
            get
            {
                return textColor;
            }
        }

        private string imageSource;
        public string ImageSource
        {
            set
            {
                if (value != null)
                {
                    imageSource = value;
                    NotifyPropertyChanged();
                }
            }
            get
            {
                return imageSource;
            }
        }
    }
}