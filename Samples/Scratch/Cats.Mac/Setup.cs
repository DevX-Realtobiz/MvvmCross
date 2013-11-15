using System;
using Cirrious.MvvmCross.Mac.Platform;
using Cirrious.MvvmCross.Mac.Views.Presenters;
using Cirrious.MvvmCross.ViewModels;

namespace Cats.Mac
{
	public class Setup : MvxMacSetup
	{
		public Setup (MvxApplicationDelegate applicationDelegate, IMvxMacViewPresenter presenter)
			: base(applicationDelegate, presenter)
		{

		}

		protected override IMvxApplication CreateApp ()
		{
			return new Cats.Core.App ();
		}
	}
}

