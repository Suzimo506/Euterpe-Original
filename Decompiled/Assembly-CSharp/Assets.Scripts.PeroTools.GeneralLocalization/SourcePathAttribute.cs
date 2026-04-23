using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.GeneralLocalization;

[Token(Token = "0x2000663")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x97C0", Offset = "0x8BC0")]
public class SourcePathAttribute : Attribute
{
	[Token(Token = "0x170005C2")]
	public string path
	{
		[CompilerGenerated]
		[Token(Token = "0x6003D50")]
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		get
		{
			return null;
		}
		[Address(RVA = "0x4894E0", Offset = "0x487CE0", Length = "0xC")]
		[Token(Token = "0x6003D51")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170005C3")]
	public int order
	{
		[Address(RVA = "0x44A0E0", Offset = "0x4488E0", Length = "0x4")]
		[Token(Token = "0x6003D52")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003D53")]
		[Address(RVA = "0x44A0F0", Offset = "0x4488F0", Length = "0x4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Address(RVA = "0x762760", Offset = "0x760F60", Length = "0x41")]
	[Token(Token = "0x6003D54")]
	public SourcePathAttribute(string path, int order = 0)
	{
	}
}
