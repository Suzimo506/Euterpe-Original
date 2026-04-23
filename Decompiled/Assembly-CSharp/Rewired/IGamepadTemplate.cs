using Cpp2ILInjected;

namespace Rewired;

[Token(Token = "0x20001E1")]
public interface IGamepadTemplate : IControllerTemplate
{
	[Token(Token = "0x17000110")]
	IControllerTemplateButton actionBottomRow1
	{
		[Token(Token = "0x6000DBC")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x17000111")]
	IControllerTemplateButton a
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6000DBD")]
		get;
	}

	[Token(Token = "0x17000112")]
	IControllerTemplateButton actionBottomRow2
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6000DBE")]
		get;
	}

	[Token(Token = "0x17000113")]
	IControllerTemplateButton b
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6000DBF")]
		get;
	}

	[Token(Token = "0x17000114")]
	IControllerTemplateButton actionBottomRow3
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6000DC0")]
		get;
	}

	[Token(Token = "0x17000115")]
	IControllerTemplateButton c
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6000DC1")]
		get;
	}

	[Token(Token = "0x17000116")]
	IControllerTemplateButton actionTopRow1
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6000DC2")]
		get;
	}

	[Token(Token = "0x17000117")]
	IControllerTemplateButton x
	{
		[Token(Token = "0x6000DC3")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x17000118")]
	IControllerTemplateButton actionTopRow2
	{
		[Token(Token = "0x6000DC4")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x17000119")]
	IControllerTemplateButton y
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6000DC5")]
		get;
	}

	[Token(Token = "0x1700011A")]
	IControllerTemplateButton actionTopRow3
	{
		[Token(Token = "0x6000DC6")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x1700011B")]
	IControllerTemplateButton z
	{
		[Token(Token = "0x6000DC7")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x1700011C")]
	IControllerTemplateButton leftShoulder1
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6000DC8")]
		get;
	}

	[Token(Token = "0x1700011D")]
	IControllerTemplateButton leftBumper
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6000DC9")]
		get;
	}

	[Token(Token = "0x1700011E")]
	IControllerTemplateAxis leftShoulder2
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6000DCA")]
		get;
	}

	[Token(Token = "0x1700011F")]
	IControllerTemplateAxis leftTrigger
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6000DCB")]
		get;
	}

	[Token(Token = "0x17000120")]
	IControllerTemplateButton rightShoulder1
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6000DCC")]
		get;
	}

	[Token(Token = "0x17000121")]
	IControllerTemplateButton rightBumper
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6000DCD")]
		get;
	}

	[Token(Token = "0x17000122")]
	IControllerTemplateAxis rightShoulder2
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6000DCE")]
		get;
	}

	[Token(Token = "0x17000123")]
	IControllerTemplateAxis rightTrigger
	{
		[Token(Token = "0x6000DCF")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x17000124")]
	IControllerTemplateButton center1
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6000DD0")]
		get;
	}

	[Token(Token = "0x17000125")]
	IControllerTemplateButton back
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6000DD1")]
		get;
	}

	[Token(Token = "0x17000126")]
	IControllerTemplateButton center2
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6000DD2")]
		get;
	}

	[Token(Token = "0x17000127")]
	IControllerTemplateButton start
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6000DD3")]
		get;
	}

	[Token(Token = "0x17000128")]
	IControllerTemplateButton center3
	{
		[Token(Token = "0x6000DD4")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x17000129")]
	IControllerTemplateButton guide
	{
		[Token(Token = "0x6000DD5")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x1700012A")]
	IControllerTemplateThumbStick leftStick
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6000DD6")]
		get;
	}

	[Token(Token = "0x1700012B")]
	IControllerTemplateThumbStick rightStick
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6000DD7")]
		get;
	}

	[Token(Token = "0x1700012C")]
	IControllerTemplateDPad dPad
	{
		[Token(Token = "0x6000DD8")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}
}
