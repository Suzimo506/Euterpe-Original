using System;
using Cpp2ILInjected;
using FancyScrollView;

[Token(Token = "0x200010F")]
public class MusicPackageJumpGroupContext : FancyGridViewContext
{
	[Token(Token = "0x400069C")]
	[FieldOffset(Offset = "0x40")]
	public Action<int> OnCellClicked;

	[Address(RVA = "0x441AE0", Offset = "0x4402E0", Length = "0x7")]
	[Token(Token = "0x60007D3")]
	public MusicPackageJumpGroupContext()
	{
	}
}
