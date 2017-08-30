using ButterfliesXFPrism.Views;
using Prism.Unity;
using Xamarin.Forms;
using Microsoft.Practices.Unity;
using ButterfliesXFPrism.Services.ButterfliesService;
using ButterfliesXFPrism.ViewModels;

namespace ButterfliesXFPrism
{
    public partial class App : PrismApplication
    {
        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
        }

        public App(IPlatformInitializer initializer = null) : base(initializer)
        {
        }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterType<IButterfliesService, ButterfliesService>(new ContainerControlledLifetimeManager());

            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<DetailPage, DetailViewModel>();
        }
    }
}