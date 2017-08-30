using Prism.Mvvm;
using ButterfliesXFPrism.Models;
using System.Collections.ObjectModel;
using Prism.Navigation;
using ButterfliesXFPrism.Services.ButterfliesService;
using Prism.Commands;

namespace ButterfliesXFPrism.ViewModels
{
    public class MainPageViewModel:BindableBase
    {

        private ObservableCollection<Butterfly> _butterflyList;
        public ObservableCollection<Butterfly>  Butterfly 
        {
            get { return _butterflyList; }
            set
            {
                SetProperty(ref _butterflyList, value);
            }
        }

        private DelegateCommand<Butterfly> _butterflySelectedCommand;
        public DelegateCommand<Butterfly> ButterflySelectedCommand => _butterflySelectedCommand != null ? _butterflySelectedCommand : (_butterflySelectedCommand = new DelegateCommand<Butterfly>(ButterflySelected));

        private DelegateCommand<Butterfly> _butterflyAppearingCommand;
        public DelegateCommand<Butterfly> ButterflyAppearingCommand => _butterflyAppearingCommand != null ? _butterflyAppearingCommand : (_butterflyAppearingCommand = new DelegateCommand<Butterfly>(CheckForLoad));

        private readonly INavigationService _navigationService;
        private readonly IButterfliesService _butterflyServicee;
        public MainPageViewModel(INavigationService navigationService, IButterfliesService butterflyService)
        {
            _navigationService = navigationService;
            _butterflyServicee = butterflyService;
            Butterfly = new ObservableCollection<Butterfly>();
            LoadButterfly();
        }

        private const int CountForLoad = 10;
        private async void LoadButterfly()
        {
            var butterflies = await _butterflyServicee.Load(CountForLoad, _butterflyList.Count);
            foreach (var item in butterflies)
            {
                Butterfly.Add(item);
            }
        }

        private async void ButterflySelected(Butterfly butterfly)
        {
            var p = new NavigationParameters();
            p.Add("butterfly", butterfly);

            await _navigationService.NavigateAsync("DetailPage", p);
        }

        private void CheckForLoad(Butterfly butterfly)
        {
            var indexCurrent = _butterflyList.IndexOf(butterfly);
            if(indexCurrent == _butterflyList.Count - 1)
                LoadButterfly();
        }
    }
}