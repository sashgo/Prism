using ButterfliesXFPrism.Models;
using ButterfliesXFPrism.ViewModels;
using Xamarin.Forms;

namespace ButterfliesXFPrism.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnItemTapped(object sender, ItemTappedEventArgs args)
        {
            ((MainPageViewModel)BindingContext).SelectedCommand.Execute((Butterfly)args.Item);
            ((ListView)sender).SelectedItem = null;
        }

        private void ListView_ItemAppearing(object sender, ItemVisibilityEventArgs e)
        {
            ((MainPageViewModel)BindingContext).AppearingCommand.Execute((Butterfly)e.Item);
        }
    }
}
