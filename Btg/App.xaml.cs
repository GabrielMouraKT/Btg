using Btg.Views;

namespace Btg
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ChartPage();
        }
    }
}
