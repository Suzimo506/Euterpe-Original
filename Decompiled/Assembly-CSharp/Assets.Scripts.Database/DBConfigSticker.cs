using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007F7")]
public class DBConfigSticker : BaseDBConfigObject
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400299D")]
	private List<StickerInfo> m_Items;

	[Token(Token = "0x17000738")]
	protected List<StickerInfo> list
	{
		[Token(Token = "0x600485C")]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
		[Address(RVA = "0x6F5B30", Offset = "0x6F4330", Length = "0x36")]
		[Token(Token = "0x600485D")]
		private set
		{
		}
	}

	[Token(Token = "0x600485E")]
	[Address(RVA = "0x6FF710", Offset = "0x6FDF10", Length = "0x7A")]
	public DBConfigSticker()
	{
	}

	[Token(Token = "0x600485F")]
	[Address(RVA = "0x6FF6A0", Offset = "0x6FDEA0", Length = "0x6B")]
	public StickerInfo GetStickerInfoByIndex(int targetIndex)
	{
		return null;
	}

	[Token(Token = "0x6004860")]
	[Address(RVA = "0x6FF570", Offset = "0x6FDD70", Length = "0x120")]
	public void GetAllAutoGetStickerImgName(List<int> listTemp)
	{
	}

	[Token(Token = "0x6004861")]
	[Address(RVA = "0x6FF460", Offset = "0x6FDC60", Length = "0x100")]
	public override void Deserialize(string str)
	{
	}
}
