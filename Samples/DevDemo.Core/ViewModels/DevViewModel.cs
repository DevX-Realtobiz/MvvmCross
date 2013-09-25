using Cirrious.MvvmCross.ViewModels;

namespace DevDemo.Core.ViewModels
{
	public class DevViewModel 
		: MvxViewModel
	{
		private string _text = "Hello MvvmCross";
		public string Text
		{ 
			get { return _text; }
			set { _text = value; RaisePropertyChanged(() => Text); }
		}

		private string _bigText = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
		public string BigText
		{
			get { return _bigText; }
			set { _bigText = value;
				RaisePropertyChanged (() => BigText); }
		}

		private double _sliderVal;
		public double SliderVal
		{ 
			get { return _sliderVal; }
			set { _sliderVal = value; 
				RaisePropertyChanged(() => SliderVal);
				RaisePropertyChanged(() => SliderText);
			}
		}

		public string SliderText
		{
			get { return _sliderVal.ToString(); }
		}
	}
}

