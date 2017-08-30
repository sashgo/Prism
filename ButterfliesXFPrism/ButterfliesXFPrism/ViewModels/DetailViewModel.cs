using ButterfliesXFPrism.Models;
using Prism.Mvvm;
using Prism.Navigation;

namespace ButterfliesXFPrism.ViewModels
{
    public class DetailViewModel : BindableBase, INavigatedAware
    {      
        private Butterfly _butterfly;
        public Butterfly Butterfly
        {
            get { return _butterfly; }
            set { SetProperty(ref _butterfly, value); }
        }

        public DetailViewModel(){}

        public void OnNavigatedFrom(NavigationParameters parameters){}

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("butterfly"))
                Butterfly = (Butterfly)parameters["butterfly"];
        }
    }
 }

