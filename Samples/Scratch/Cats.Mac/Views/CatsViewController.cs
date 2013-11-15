using System;
using System.Collections.Generic;
using System.Linq;
using MonoMac.Foundation;
using MonoMac.AppKit;
using Cirrious.MvvmCross.Mac.Views;
using Cirrious.MvvmCross.ViewModels;
using Cats.Core.ViewModels;

namespace Cats.Mac
{
	[MvxViewFor(typeof(CatsViewModel))]
	public partial class CatsViewController : MvxViewController
	{

		#region Constructors

		// Called when created from unmanaged code
		public CatsViewController (IntPtr handle) : base (handle)
		{
			Initialize ();
		}
		// Called when created directly from a XIB file
		[Export ("initWithCoder:")]
		public CatsViewController (NSCoder coder) : base (coder)
		{
			Initialize ();
		}
		// Call to load from the XIB/NIB file
		public CatsViewController () : base ("CatsView", NSBundle.MainBundle)
		{
			Initialize ();
		}
		// Shared initialization code
		void Initialize ()
		{
		}

		#endregion



		//strongly typed view accessor
		public new CatsView View {
			get {
				return (CatsView)base.View;
			}
		}
	}
}

