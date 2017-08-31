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
        private string _title = "Бабочки";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        private ObservableCollection<Butterfly> _butterflyList;
        public ObservableCollection<Butterfly>  Butterfly 
        {
            get { return _butterflyList; }
            set { SetProperty(ref _butterflyList, value); }
        }

        private bool _isExtraControlsVisible = true;
        public bool IsExtraControlsVisible
        {
            get { return IsExtraControlsVisible; }
            set { SetProperty(ref _isExtraControlsVisible, value); }
        }

        private DelegateCommand<Butterfly> _selectedCommand;
        public DelegateCommand<Butterfly> SelectedCommand => _selectedCommand != null ? _selectedCommand : (_selectedCommand = new DelegateCommand<Butterfly>(ButterflySelected));

        private DelegateCommand<Butterfly> _appearingCommand;
        public DelegateCommand<Butterfly> AppearingCommand => _appearingCommand != null ? _appearingCommand : (_appearingCommand = new DelegateCommand<Butterfly>(CheckForLoad));

        private readonly INavigationService _navigationService;
        private readonly IButterfliesService _butterflyService;
        public MainPageViewModel(INavigationService navigationService, IButterfliesService butterflyService)
        {
            _navigationService = navigationService;
            _butterflyService = butterflyService;
            Butterfly = new ObservableCollection<Butterfly>();
            LoadButterfly();
        }

        private const int CountForLoad = 5;
        private async void LoadButterfly()
        {
            var butterflies = await _butterflyService.Load(CountForLoad, _butterflyList.Count);
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