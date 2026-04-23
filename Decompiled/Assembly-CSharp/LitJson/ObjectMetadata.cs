using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace LitJson;

[Token(Token = "0x20003F8")]
internal struct ObjectMetadata
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001618")]
	private Type element_type;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001619")]
	private bool is_dictionary;

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400161A")]
	private IDictionary<string, PropertyMetadata> properties;

	[Token(Token = "0x17000448")]
	public Type ElementType
	{
		[Address(RVA = "0x8CB450", Offset = "0x8C9C50", Length = "0xA1")]
		[Token(Token = "0x6003058")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003059")]
		[Address(RVA = "0x5BCBA0", Offset = "0x5BB3A0", Length = "0x8")]
		set
		{
		}
	}

	[Token(Token = "0x17000449")]
	public bool IsDictionary
	{
		[Address(RVA = "0x5BCB80", Offset = "0x5BB380", Length = "0x5")]
		[Token(Token = "0x600305A")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x5BCBB0", Offset = "0x5BB3B0", Length = "0x4")]
		[Token(Token = "0x600305B")]
		set
		{
		}
	}

	[Token(Token = "0x1700044A")]
	public IDictionary<string, PropertyMetadata> Properties
	{
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		[Token(Token = "0x600305C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600305D")]
		[Address(RVA = "0x4894E0", Offset = "0x487CE0", Length = "0xC")]
		set
		{
		}
	}
}
