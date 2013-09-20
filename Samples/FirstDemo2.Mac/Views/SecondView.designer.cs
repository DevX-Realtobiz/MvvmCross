
namespace FirstDemo2.Mac
{
	// Should subclass MonoMac.AppKit.NSView
	[MonoMac.Foundation.Register("SecondView")]
	public partial class SecondView
	{
	}
	// Should subclass MonoMac.AppKit.NSViewController
	[MonoMac.Foundation.Register("FirstView")]
	public partial class FirstView
	{
	}
}

