using Prism;
using Prism.Ioc;
using Prism.Unity;
using System.Collections.Generic;
using Unity;
using Unity.Injection;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;
using XamarinPrismTemp.Models;
using XamarinPrismTemp.ViewModels;
using XamarinPrismTemp.Views;

namespace XamarinPrismTemp {
    public partial class App {
        public App(IPlatformInitializer initializer)
            : base(initializer) {
        }

        protected override async void OnInitialized() {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry) {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();

            var container = containerRegistry.GetContainer();
            container.RegisterType<Lottery>(new InjectionConstructor(new List<string>() { "‰Jƒ–èÎ“ø", "‹ãğ—ÑŒç", "”’”TƒNƒƒ~", "Œ‹–Úƒ†ƒC", "Šª”T‚à‚È‚©" }, "’Š‘I"));
        }
    }
}
