using MvCrossTestingOne.Core.Models;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.Presenters.Attributes;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvCrossTestingOne.Core.ViewModels
{
    public class TestThreeViewModel : MvxViewModel
    {
		public IMvxCommand TestButtonOne { get; set; }
		public IMvxCommand TestButtonTwo { get; set; }
		public IMvxCommand TestButtonThree { get; set; }

		private readonly IMvxNavigationService _navigationService;
		//public TestThreeViewModel()
		//{
		//	TestText = "This is Test view Three";
	
		//}
		private string _testText;

		public TestThreeViewModel(IMvxNavigationService mvxNavigationService)
		{
			_navigationService = mvxNavigationService;
			TestText = "This is Test view Three";
			TestButtonOne = new MvxCommand(TestButtonOnePressed);
			TestButtonTwo = new MvxCommand(TestButtonTwoPressed);
			
		}

		private void TestButtonOnePressed()
		{
			System.Diagnostics.Debug.WriteLine("This is test button one pressed.");
			_navigationService.Navigate<TestTwoViewModel>();
		}

		private void TestButtonTwoPressed()
		{
			System.Diagnostics.Debug.WriteLine("This is test button Two pressed.");
			_navigationService.Navigate<TestOneViewModel>();
		}


		public string TestText
		{
			get { return _testText; }
			set { _testText = value; }
		}

		
	}
}
