using System;
using Cpp2ILInjected;

namespace LitJson;

[Token(Token = "0x20003F7")]
internal struct ArrayMetadata
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001615")]
	private Type element_type;

	[Token(Token = "0x4001616")]
	[FieldOffset(Offset = "0x8")]
	private bool is_array;

	[Token(Token = "0x4001617")]
	[FieldOffset(Offset = "0x9")]
	private bool is_list;

	[Token(Token = "0x17000445")]
	public Type ElementType
	{
		[Address(RVA = "0x5BCAD0", Offset = "0x5BB2D0", Length = "0xA1")]
		[Token(Token = "0x6003052")]
		get
		{
			return null;
		}
		[Address(RVA = "0x5BCBA0", Offset = "0x5BB3A0", Length = "0x8")]
		[Token(Token = "0x6003053")]
		set
		{
		}
	}

	[Token(Token = "0x17000446")]
	public bool IsArray
	{
		[Address(RVA = "0x5BCB80", Offset = "0x5BB380", Length = "0x5")]
		[Token(Token = "0x6003054")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003055")]
		[Address(RVA = "0x5BCBB0", Offset = "0x5BB3B0", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x17000447")]
	public bool IsList
	{
		[Token(Token = "0x6003056")]
		[Address(RVA = "0x5BCB90", Offset = "0x5BB390", Length = "0x5")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003057")]
		[Address(RVA = "0x5BCBC0", Offset = "0x5BB3C0", Length = "0x4")]
		set
		{
		}
	}
}
