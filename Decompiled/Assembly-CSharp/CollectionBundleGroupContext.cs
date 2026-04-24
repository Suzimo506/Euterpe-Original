using System;
using Cpp2ILInjected;
using FancyScrollView;

[Token(Token = "0x2000100")]
public class CollectionBundleGroupContext : FancyGridViewContext
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400064C")]
	public int selectedIndex;

	[Token(Token = "0x400064D")]
	[FieldOffset(Offset = "0x48")]
	public Action<int> OnCellClicked;

	[Token(Token = "0x400064E")]
	[FieldOffset(Offset = "0x50")]
	public CollectionBundleShowItem selectShowItem;

	[Address(RVA = "0x441AE0", Offset = "0x4402E0", Length = "0x7")]
	[Token(Token = "0x6000781")]
	public CollectionBundleGroupContext()
	{
	}
}
