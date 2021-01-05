using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XamarinPrismTemp.Models;

namespace XamarinPrismTemp.ViewModels {
    public class MainPageViewModel : ViewModelBase {
        public MainPageViewModel(INavigationService navigationService, Lottery lottery)
            : base(navigationService) {
            LabelText = new ReactiveProperty<string>();
            LabelText = lottery.ObserveProperty(x => x.Name).ToReactiveProperty();
            LotteryCommand = new ReactiveCommand();
            LotteryCommand.Subscribe(_ => lottery.Action());
        }
        public ReactiveProperty<string> LabelText { get; }
        public ReactiveCommand LotteryCommand { get; }

    }
}
