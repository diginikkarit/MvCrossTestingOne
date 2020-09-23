using MvCrossTestingOne.Core.Models;
using MvCrossTestingOne.Core.Services;
using MvvmCross.Commands;
using MvvmCross.Core;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MvCrossTestingOne.Core.ViewModels
{

	public class TestOneViewModel : MvxViewModel<Dish>
    {
		private Dish _currentDish;

		private string _testString;
		//To Add buttons, make IMVXCommand to hold the actual method.
		public IMvxCommand TestButton { get; set; }
		private IStringMonster strMonster;
		public TestOneViewModel(IStringMonster stringMonster)
		{
			TestString = "Test String";
			strMonster = stringMonster;
			TestButton = new MvxCommand(TestButtonPressed);	
		}

		public override void Prepare(Dish dish)
		{
			_currentDish = dish;
			TestString = dish.Name;
		}

		//This is run after construction
		//Check MVVM Cross life cycle
		public override async Task Initialize()
		{
			await base.Initialize();
			TestString = strMonster.MonsterString(TestString);
	
		}
		public void TestButtonPressed()
		{
			System.Diagnostics.Debug.WriteLine("Test Button Pressed");

		}


		public string TestString
		{
			get { return _testString; }
			set { 
				_testString = value;
				SetProperty(ref _testString, value);
			}
		}
	}
}
