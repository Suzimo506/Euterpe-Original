using System;
using Cpp2ILInjected;

namespace Rewired;

[Token(Token = "0x20001EB")]
public sealed class FlightPedalsTemplate : ControllerTemplate, IFlightPedalsTemplate, IControllerTemplate
{
	[Token(Token = "0x4000D29")]
	public static readonly Guid typeGuid;

	[Token(Token = "0x4000D2A")]
	public const int elementId_leftPedal = 0;

	[Token(Token = "0x4000D2B")]
	public const int elementId_rightPedal = 1;

	[Token(Token = "0x4000D2C")]
	public const int elementId_slide = 2;

	[Token(Token = "0x170002DC")]
	private IControllerTemplateAxis Rewired_002EIFlightPedalsTemplate_002EleftPedal
	{
		[Address(RVA = "0xF94660", Offset = "0xF92E60", Length = "0x3A")]
		[Token(Token = "0x6000F90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002DD")]
	private IControllerTemplateAxis Rewired_002EIFlightPedalsTemplate_002ErightPedal
	{
		[Address(RVA = "0xF946A0", Offset = "0xF92EA0", Length = "0x3D")]
		[Token(Token = "0x6000F91")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002DE")]
	private IControllerTemplateAxis Rewired_002EIFlightPedalsTemplate_002Eslide
	{
		[Address(RVA = "0xF946E0", Offset = "0xF92EE0", Length = "0x3D")]
		[Token(Token = "0x6000F92")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x89C3F0", Offset = "0x89ABF0", Length = "0x8")]
	[Token(Token = "0x6000F93")]
	public FlightPedalsTemplate(object payload)
		: base(null)
	{
	}
}
