using MvCrossTestingOne.Core.Models;
using MvvmCross;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MvCrossTestingOne.Core.ViewModels
{
    public class TestTwoViewModel : MvxViewModel
    {
		private string _testString;
		private readonly IMvxNavigationService _navigationService;
		public IMvxCommand TestButton { get; set; }
		public string TestString
		{
			get { return _testString; }
			set { _testString = value; }
		}

		public TestTwoViewModel(IMvxNavigationService mvxNavigationService)
		{
			_navigationService = mvxNavigationService;
			
			
			TestString = "This is Test Sting for View Two";
			TestButton = new MvxCommand(TestButtonPressed);

		}

		private void TestButtonPressed()
		{
			System.Diagnostics.Debug.Write("This is test button pressed.");
			Dish dish = new Dish();
			dish.Name = "TestiRuoka";
			_navigationService.Navigate<TestOneViewModel, Dish>(dish);
		}

	}
}
