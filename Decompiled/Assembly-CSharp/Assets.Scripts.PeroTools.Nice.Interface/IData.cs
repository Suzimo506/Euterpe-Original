using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Nice.Interface;

[Token(Token = "0x20005E6")]
[Attribute(Name = "DefaultMemberAttribute", RVA = "0x2060", Offset = "0x1460")]
public interface IData
{
	[Token(Token = "0x17000567")]
	Dictionary<string, IVariable> fields
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6003A11")]
		get;
	}

	[Token(Token = "0x17000568")]
	IVariable Item
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6003A12")]
		get;
		[Token(Token = "0x6003A13")]
		[Address(RVA = "0x0", Length = "0x0")]
		set;
	}
}
