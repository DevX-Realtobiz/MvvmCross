
namespace Cats.Mac
{
	// Should subclass MonoMac.AppKit.NSView
	[MonoMac.Foundation.Register ("CatsView")]
	public partial class CatsView
	{
	}
	// Should subclass MonoMac.AppKit.NSViewController
	[MonoMac.Foundation.Register ("CatsViewController")]
	public partial class CatsViewController
	{
	}
}

