using MvCrossTestingOne.Core.ViewModels;
using MvvmCross.ViewModels;
using MvvmCross;
using MvCrossTestingOne.Core.Services;
using System.Collections.Generic;
using System.Text;

namespace MvCrossTestingOne.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            //When interface is registered here. It will create a new StringMonster class
            //When ever IStringMonster is needed in constructor. Chekck TestViewModel.
            Mvx.IoCProvider.RegisterType<IStringMonster, StringMonster>();

            //RegisterAppStart<TestTwoViewModel>();
            RegisterAppStart<TestThreeViewModel>();

            RegisterAppStart<NavigationWindowViewModel>();
        }
    }
}
