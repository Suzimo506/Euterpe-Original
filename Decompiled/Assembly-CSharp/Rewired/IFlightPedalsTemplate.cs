using Cpp2ILInjected;

namespace Rewired;

[Token(Token = "0x20001E5")]
public interface IFlightPedalsTemplate : IControllerTemplate
{
	[Token(Token = "0x170001E0")]
	IControllerTemplateAxis leftPedal
	{
		[Token(Token = "0x6000E8C")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x170001E1")]
	IControllerTemplateAxis rightPedal
	{
		[Token(Token = "0x6000E8D")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x170001E2")]
	IControllerTemplateAxis slide
	{
		[Token(Token = "0x6000E8E")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}
}
