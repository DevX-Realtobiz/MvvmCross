// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoMac.Foundation;
using System.CodeDom.Compiler;

namespace Cats.Mac
{
	[Register ("CatsViewController")]
	partial class CatsViewController
	{
		[Outlet]
		MonoMac.AppKit.NSTableView CatsTableView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (CatsTableView != null) {
				CatsTableView.Dispose ();
				CatsTableView = null;
			}
		}
	}

	[Register ("CatsView")]
	partial class CatsView
	{
		
		void ReleaseDesignerOutlets ()
		{
		}
	}
}
