using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prism.Mvvm;
using ButterfliesXFPrism.Models;
using System.Collections.ObjectModel;
using ButterfliesXFPrism.Services.ButterfliesService.Interfaces;
using Prism.Navigation;
using ButterfliesXFPrism.Services.ButterfliesService;

namespace ButterfliesXFPrism.ViewModels
{
    public class MainPageViewModel:BindableBase, INavigationAware
    {
        private ObservableCollection<Butterfly> _butterfly;
        public ObservableCollection<Butterfly>  Butterfly 
        {
            get { return _butterfly;}
            set
            {
                SetProperty(ref _butterfly, value);
            }
       }
        public MainPageViewModel()
        {
            _service = new ButterfliesService();

            Butterfly = new ObservableCollection<Butterfly>(_service.Load(12));
        }

        private IButterfliesService _service;
        public MainPageViewModel(IButterfliesService service)
        {
            _service = service;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (Butterfly == null)
                Butterfly = new ObservableCollection<Butterfly>(_service.Load(12));
        }
    }
}