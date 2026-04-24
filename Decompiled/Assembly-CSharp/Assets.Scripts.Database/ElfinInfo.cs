using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007C3")]
public class ElfinInfo : BaseDataObject
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40028EB")]
	public string name;

	[Token(Token = "0x40028EC")]
	[FieldOffset(Offset = "0x28")]
	public List<ElfinSkin> skins;

	[Token(Token = "0x40028ED")]
	[FieldOffset(Offset = "0x30")]
	public string description;

	[Token(Token = "0x40028EE")]
	[FieldOffset(Offset = "0x38")]
	public string skill;

	[Token(Token = "0x40028EF")]
	[FieldOffset(Offset = "0x40")]
	public int chipAmount;

	[Token(Token = "0x40028F0")]
	[FieldOffset(Offset = "0x48")]
	public string prefab;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40028F1")]
	public string mainShow;

	[Token(Token = "0x40028F2")]
	[FieldOffset(Offset = "0x58")]
	public string chipName;

	[Token(Token = "0x40028F3")]
	[FieldOffset(Offset = "0x60")]
	public string chipDescription;

	[Token(Token = "0x40028F4")]
	[FieldOffset(Offset = "0x68")]
	public string chipImage;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40028F5")]
	public string rarity;

	[Token(Token = "0x40028F6")]
	[FieldOffset(Offset = "0x78")]
	public bool free;

	[Token(Token = "0x40028F7")]
	[FieldOffset(Offset = "0x7C")]
	public int order;

	[Token(Token = "0x40028F8")]
	[FieldOffset(Offset = "0x80")]
	public bool hide;

	[Token(Token = "0x40028F9")]
	[FieldOffset(Offset = "0x81")]
	public bool egg;

	[Token(Token = "0x40028FA")]
	[FieldOffset(Offset = "0x82")]
	public bool exchange;

	[Token(Token = "0x40028FB")]
	[FieldOffset(Offset = "0x83")]
	public bool special;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40028FC")]
	public string achShow;

	[Token(Token = "0x40028FD")]
	[FieldOffset(Offset = "0x90")]
	public string achShowHexie;

	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40028FE")]
	public string thumb;

	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40028FF")]
	public string thumbHexie;

	[Address(RVA = "0x49C610", Offset = "0x49AE10", Length = "0xDA")]
	[Token(Token = "0x6004794")]
	public string GetAchShowImgName()
	{
		return null;
	}

	[Address(RVA = "0x49C6F0", Offset = "0x49AEF0", Length = "0xDA")]
	[Token(Token = "0x6004795")]
	public string GetThumbImgName()
	{
		return null;
	}

	[Token(Token = "0x6004796")]
	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	public ElfinInfo()
	{
	}
}
