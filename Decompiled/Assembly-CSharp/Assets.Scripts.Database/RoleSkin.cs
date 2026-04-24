using System.Collections.Generic;
using Cpp2ILInjected;
using Newtonsoft.Json;

namespace Assets.Scripts.Database;

[Token(Token = "0x200079B")]
public class RoleSkin
{
	[Token(Token = "0x400282D")]
	[FieldOffset(Offset = "0x10")]
	public int index;

	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400282E")]
	public int albumJsonIndex;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400282F")]
	public string mainShow;

	[Token(Token = "0x4002830")]
	[FieldOffset(Offset = "0x20")]
	public string battleShow;

	[Token(Token = "0x4002831")]
	[FieldOffset(Offset = "0x28")]
	public List<string> battleSubShow;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002832")]
	public string victoryShow;

	[Token(Token = "0x4002833")]
	[FieldOffset(Offset = "0x38")]
	public string failShow;

	[Token(Token = "0x4002834")]
	[FieldOffset(Offset = "0x40")]
	public string chipName;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4002835")]
	public bool free;

	[Token(Token = "0x4002836")]
	[FieldOffset(Offset = "0x49")]
	public bool hide;

	[Token(Token = "0x4002837")]
	[FieldOffset(Offset = "0x4A")]
	public bool exchange;

	[FieldOffset(Offset = "0x4B")]
	[Token(Token = "0x4002838")]
	public bool hexie;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4002839")]
	public string headName;

	[Token(Token = "0x400283A")]
	[FieldOffset(Offset = "0x58")]
	public string headNameHexie;

	[Token(Token = "0x400283B")]
	[FieldOffset(Offset = "0x60")]
	public string achShow;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400283C")]
	public string achShowHexie;

	[Token(Token = "0x400283D")]
	[FieldOffset(Offset = "0x70")]
	public string recordShow;

	[Token(Token = "0x400283E")]
	[FieldOffset(Offset = "0x78")]
	public string recordShowHexie;

	[Token(Token = "0x400283F")]
	[FieldOffset(Offset = "0x80")]
	public string recordShow_Vic;

	[Token(Token = "0x4002840")]
	[FieldOffset(Offset = "0x88")]
	public string recordShowHexie_Vic;

	[Token(Token = "0x170006C2")]
	[JsonIgnore]
	public bool isCat
	{
		[Address(RVA = "0x4A48E0", Offset = "0x4A30E0", Length = "0x46")]
		[Token(Token = "0x60046DC")]
		get
		{
			return default(bool);
		}
	}

	[JsonIgnore]
	[Token(Token = "0x170006C3")]
	public RoleSkinType skinType
	{
		[Address(RVA = "0x42CB40", Offset = "0x42B340", Length = "0x4")]
		[Token(Token = "0x60046DD")]
		get
		{
			return default(RoleSkinType);
		}
	}

	[Token(Token = "0x60046DE")]
	[Address(RVA = "0x4A46A0", Offset = "0x4A2EA0", Length = "0xD1")]
	public string GetHeadImgName()
	{
		return null;
	}

	[Token(Token = "0x60046DF")]
	[Address(RVA = "0x4A45C0", Offset = "0x4A2DC0", Length = "0xD1")]
	public string GetAchShowImgName()
	{
		return null;
	}

	[Token(Token = "0x60046E0")]
	[Address(RVA = "0x4A4780", Offset = "0x4A2F80", Length = "0x150")]
	public string GetRecordShowImgName(bool isVic = false)
	{
		return null;
	}

	[Token(Token = "0x60046E1")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public RoleSkin()
	{
	}
}
