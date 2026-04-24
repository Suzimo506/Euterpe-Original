using Cpp2ILInjected;

namespace Rewired;

[Token(Token = "0x20001E2")]
public interface IRacingWheelTemplate : IControllerTemplate
{
	[Token(Token = "0x1700012D")]
	IControllerTemplateAxis wheel
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6000DD9")]
		get;
	}

	[Token(Token = "0x1700012E")]
	IControllerTemplateAxis accelerator
	{
		[Token(Token = "0x6000DDA")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x1700012F")]
	IControllerTemplateAxis brake
	{
		[Token(Token = "0x6000DDB")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x17000130")]
	IControllerTemplateAxis clutch
	{
		[Token(Token = "0x6000DDC")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x17000131")]
	IControllerTemplateButton shiftDown
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6000DDD")]
		get;
	}

	[Token(Token = "0x17000132")]
	IControllerTemplateButton shiftUp
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6000DDE")]
		get;
	}

	[Token(Token = "0x17000133")]
	IControllerTemplateButton wheelButton1
	{
		[Token(Token = "0x6000DDF")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x17000134")]
	IControllerTemplateButton wheelButton2
	{
		[Token(Token = "0x6000DE0")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x17000135")]
	IControllerTemplateButton wheelButton3
	{
		[Token(Token = "0x6000DE1")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x17000136")]
	IControllerTemplateButton wheelButton4
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6000DE2")]
		get;
	}

	[Token(Token = "0x17000137")]
	IControllerTemplateButton wheelButton5
	{
		[Token(Token = "0x6000DE3")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x17000138")]
	IControllerTemplateButton wheelButton6
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6000DE4")]
		get;
	}

	[Token(Token = "0x17000139")]
	IControllerTemplateButton wheelButton7
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6000DE5")]
		get;
	}

	[Token(Token = "0x1700013A")]
	IControllerTemplateButton wheelButton8
	{
		[Token(Token = "0x6000DE6")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x1700013B")]
	IControllerTemplateButton wheelButton9
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6000DE7")]
		get;
	}

	[Token(Token = "0x1700013C")]
	IControllerTemplateButton wheelButton10
	{
		[Token(Token = "0x6000DE8")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x1700013D")]
	IControllerTemplateButton consoleButton1
	{
		[Token(Token = "0x6000DE9")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x1700013E")]
	IControllerTemplateButton consoleButton2
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6000DEA")]
		get;
	}

	[Token(Token = "0x1700013F")]
	IControllerTemplateButton consoleButton3
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6000DEB")]
		get;
	}

	[Token(Token = "0x17000140")]
	IControllerTemplateButton consoleButton4
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6000DEC")]
		get;
	}

	[Token(Token = "0x17000141")]
	IControllerTemplateButton consoleButton5
	{
		[Token(Token = "0x6000DED")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x17000142")]
	IControllerTemplateButton consoleButton6
	{
		[Token(Token = "0x6000DEE")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x17000143")]
	IControllerTemplateButton consoleButton7
	{
		[Token(Token = "0x6000DEF")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x17000144")]
	IControllerTemplateButton consoleButton8
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6000DF0")]
		get;
	}

	[Token(Token = "0x17000145")]
	IControllerTemplateButton consoleButton9
	{
		[Token(Token = "0x6000DF1")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x17000146")]
	IControllerTemplateButton consoleButton10
	{
		[Token(Token = "0x6000DF2")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x17000147")]
	IControllerTemplateButton shifter1
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6000DF3")]
		get;
	}

	[Token(Token = "0x17000148")]
	IControllerTemplateButton shifter2
	{
		[Token(Token = "0x6000DF4")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x17000149")]
	IControllerTemplateButton shifter3
	{
		[Token(Token = "0x6000DF5")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x1700014A")]
	IControllerTemplateButton shifter4
	{
		[Token(Token = "0x6000DF6")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x1700014B")]
	IControllerTemplateButton shifter5
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6000DF7")]
		get;
	}

	[Token(Token = "0x1700014C")]
	IControllerTemplateButton shifter6
	{
		[Token(Token = "0x6000DF8")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x1700014D")]
	IControllerTemplateButton shifter7
	{
		[Token(Token = "0x6000DF9")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x1700014E")]
	IControllerTemplateButton shifter8
	{
		[Token(Token = "0x6000DFA")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x1700014F")]
	IControllerTemplateButton shifter9
	{
		[Token(Token = "0x6000DFB")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x17000150")]
	IControllerTemplateButton shifter10
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6000DFC")]
		get;
	}

	[Token(Token = "0x17000151")]
	IControllerTemplateButton reverseGear
	{
		[Token(Token = "0x6000DFD")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x17000152")]
	IControllerTemplateButton select
	{
		[Token(Token = "0x6000DFE")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x17000153")]
	IControllerTemplateButton start
	{
		[Token(Token = "0x6000DFF")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x17000154")]
	IControllerTemplateButton systemButton
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6000E00")]
		get;
	}

	[Token(Token = "0x17000155")]
	IControllerTemplateButton horn
	{
		[Token(Token = "0x6000E01")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x17000156")]
	IControllerTemplateDPad dPad
	{
		[Token(Token = "0x6000E02")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}
}
