using System;
using System.Collections.Generic;
using System.Linq;
using MonoMac.Foundation;
using MonoMac.AppKit;
using Cirrious.MvvmCross.Mac.Views;
using FirstDemo.Core.ViewModels;
using Cirrious.MvvmCross.Binding.BindingContext;

namespace FirstDemo2.Mac
{
	public partial class FirstView : MvxViewController
	{
		#region Constructors
		// Called when created from unmanaged code
		public FirstView (IntPtr handle) : base (handle)
		{
			Initialize ();
		}
		// Called when created directly from a XIB file
		[Export ("initWithCoder:")]
		public FirstView (NSCoder coder) : base (coder)
		{
			Initialize ();
		}
		// Call to load from the XIB/NIB file
		public FirstView () : base ("UniveralView", NSBundle.MainBundle)
		{
			Initialize ();
		}
		// Shared initialization code
		void Initialize ()
		{	
			base.View = new UniversalView ();

			var textEditFirst = new NSTextField(new System.Drawing.RectangleF(0,0,320,40));
			View.AddSubview (textEditFirst);
			var textEditSecond = new NSTextField(new System.Drawing.RectangleF(0,50,320,40));
			View.AddSubview(textEditSecond);
			var labelFull = new NSTextField(new System.Drawing.RectangleF(0,100,320,40));
			View.AddSubview (labelFull);

			var set = this.CreateBindingSet<FirstView, FirstViewModel> ();
			set.Bind (textEditFirst).For(v => v.StringValue).To (vm => vm.FirstName);
			set.Bind (textEditSecond).For(v => v.StringValue).To (vm => vm.LastName);
			set.Bind (labelFull).For(v => v.StringValue).To (vm => vm.FullName);	
			set.Apply ();
		}
		#endregion
		//strongly typed view accessor
		public new UniversalView View {
			get {
				return (UniversalView)base.View;
			}
		}
	}
}

