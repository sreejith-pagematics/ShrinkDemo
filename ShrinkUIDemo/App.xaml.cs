using ListPM_Caller.Views.HomeTab;

namespace ShrinkUIDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CarouselHomePage();
        }
    }
}
