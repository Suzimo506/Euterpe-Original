using System;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;

namespace Assets.Scripts.UI.Specials;

[Serializable]
[Token(Token = "0x2000863")]
public class TroveItemData
{
	[Token(Token = "0x4002BCA")]
	[FieldOffset(Offset = "0x10")]
	public IData item;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002BCB")]
	public int itemIndex;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002BCC")]
	public string itemType;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002BCD")]
	public PnlTroveItem troveItem;

	[Token(Token = "0x17000866")]
	public int Count
	{
		[Token(Token = "0x6004CBB")]
		[Address(RVA = "0x61CE90", Offset = "0x61B690", Length = "0x61")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000867")]
	public bool IsNew
	{
		[Address(RVA = "0x61CF00", Offset = "0x61B700", Length = "0x61")]
		[Token(Token = "0x6004CBC")]
		get
		{
			return default(bool);
		}
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6004CB8")]
	public TroveItemData()
	{
	}

	[Token(Token = "0x6004CB9")]
	[Address(RVA = "0x61CD40", Offset = "0x61B540", Length = "0xF1")]
	public void Reset(int index)
	{
	}

	[Token(Token = "0x6004CBA")]
	[Address(RVA = "0x61CE40", Offset = "0x61B640", Length = "0x4B")]
	public void Reset(int itemIndex, string itemType)
	{
	}
}
