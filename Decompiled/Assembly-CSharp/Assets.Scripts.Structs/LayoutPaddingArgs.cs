using System;
using Cpp2ILInjected;
using UnityEngine.UI;

namespace Assets.Scripts.Structs;

[Serializable]
[Token(Token = "0x2000576")]
public struct LayoutPaddingArgs
{
	[Token(Token = "0x400203A")]
	[FieldOffset(Offset = "0x0")]
	public int left;

	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400203B")]
	public int right;

	[Token(Token = "0x400203C")]
	[FieldOffset(Offset = "0x8")]
	public int top;

	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400203D")]
	public int bottom;

	[Token(Token = "0x17000522")]
	public bool isValid
	{
		[Address(RVA = "0x656DF0", Offset = "0x6555F0", Length = "0x1C")]
		[Token(Token = "0x6003860")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600385D")]
	[Address(RVA = "0x656DD0", Offset = "0x6555D0", Length = "0x12")]
	public LayoutPaddingArgs(int l, int r, int t, int b)
	{
	}

	[Token(Token = "0x600385E")]
	[Address(RVA = "0x656E10", Offset = "0x655610", Length = "0x3D")]
	public static bool operator ==(LayoutPaddingArgs l, LayoutPaddingArgs r)
	{
		return default(bool);
	}

	[Token(Token = "0x600385F")]
	[Address(RVA = "0x656E50", Offset = "0x655650", Length = "0x3F")]
	public static bool operator !=(LayoutPaddingArgs l, LayoutPaddingArgs r)
	{
		return default(bool);
	}

	[Address(RVA = "0x656CF0", Offset = "0x6554F0", Length = "0xD8")]
	[Token(Token = "0x6003861")]
	public void SetGridLayout(LayoutGroup layout)
	{
	}
}
