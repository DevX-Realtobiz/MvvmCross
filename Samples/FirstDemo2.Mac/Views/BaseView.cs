using System;
using System.Collections.Generic;
using System.Linq;
using MonoMac.Foundation;
using MonoMac.AppKit;
using Cirrious.MvvmCross.Binding.Mac.Views;
using System.Drawing;

namespace FirstDemo2.Mac
{
	public partial class BaseView : MvxView
	{
		#region Constructors
		// Called when created from unmanaged code
		public BaseView (IntPtr handle) : base (handle)
		{
			Initialize ();
		}
		// Called when created directly from a XIB file
		[Export ("initWithCoder:")]
		public BaseView (NSCoder coder) : base (coder)
		{
			Initialize ();
		}

		[Export("initWithFrame:")]
		public BaseView(RectangleF bounds)
			: base(bounds)
		{
			Initialize();
		}

		// Shared initialization code
		void Initialize ()
		{
		}
		#endregion
	}
}

