using MvvmCross.ViewModels;
using MvvmCross.Navigation;
using MvvmCross.Logging;

using System;
using System.Collections.Generic;
using System.Text;

namespace MvCrossTestingOne.Core.ViewModels
{
    public class NavigationWindowViewModel : MvxNavigationViewModel
    {
        private static int _count;

        public static int Count
        {
            get { return _count; }
            set { _count = value; }
        }

        public NavigationWindowViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
            _count++;
           // var s = NavigationService.CanNavigate<TestOneViewModel>();
           NavigationService.Navigate<TestThreeViewModel>();
            
        }
    }
}
