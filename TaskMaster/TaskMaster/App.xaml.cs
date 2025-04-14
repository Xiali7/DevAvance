using Microsoft.Maui.Controls;

namespace TaskMaster
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}