using System;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.CrossCore.IoC;
using Cats.Core.ViewModels;

namespace Cats.Core
{
	public class App : MvxApplication
	{
		public override void Initialize ()
		{
			CreatableTypes ()
				.EndingWith ("Service")
				.AsInterfaces ()
				.RegisterAsLazySingleton ();
			RegisterAppStart<CatsViewModel> ();
		}
	}
}

