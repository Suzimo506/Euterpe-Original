using System;
using Cpp2ILInjected;

namespace Rewired;

[Token(Token = "0x20001E8")]
public sealed class RacingWheelTemplate : ControllerTemplate, IRacingWheelTemplate, IControllerTemplate
{
	[Token(Token = "0x4000C03")]
	public static readonly Guid typeGuid;

	[Token(Token = "0x4000C04")]
	public const int elementId_wheel = 0;

	[Token(Token = "0x4000C05")]
	public const int elementId_accelerator = 1;

	[Token(Token = "0x4000C06")]
	public const int elementId_brake = 2;

	[Token(Token = "0x4000C07")]
	public const int elementId_clutch = 3;

	[Token(Token = "0x4000C08")]
	public const int elementId_shiftDown = 4;

	[Token(Token = "0x4000C09")]
	public const int elementId_shiftUp = 5;

	[Token(Token = "0x4000C0A")]
	public const int elementId_wheelButton1 = 6;

	[Token(Token = "0x4000C0B")]
	public const int elementId_wheelButton2 = 7;

	[Token(Token = "0x4000C0C")]
	public const int elementId_wheelButton3 = 8;

	[Token(Token = "0x4000C0D")]
	public const int elementId_wheelButton4 = 9;

	[Token(Token = "0x4000C0E")]
	public const int elementId_wheelButton5 = 10;

	[Token(Token = "0x4000C0F")]
	public const int elementId_wheelButton6 = 11;

	[Token(Token = "0x4000C10")]
	public const int elementId_wheelButton7 = 12;

	[Token(Token = "0x4000C11")]
	public const int elementId_wheelButton8 = 13;

	[Token(Token = "0x4000C12")]
	public const int elementId_wheelButton9 = 14;

	[Token(Token = "0x4000C13")]
	public const int elementId_wheelButton10 = 15;

	[Token(Token = "0x4000C14")]
	public const int elementId_consoleButton1 = 16;

	[Token(Token = "0x4000C15")]
	public const int elementId_consoleButton2 = 17;

	[Token(Token = "0x4000C16")]
	public const int elementId_consoleButton3 = 18;

	[Token(Token = "0x4000C17")]
	public const int elementId_consoleButton4 = 19;

	[Token(Token = "0x4000C18")]
	public const int elementId_consoleButton5 = 20;

	[Token(Token = "0x4000C19")]
	public const int elementId_consoleButton6 = 21;

	[Token(Token = "0x4000C1A")]
	public const int elementId_consoleButton7 = 22;

	[Token(Token = "0x4000C1B")]
	public const int elementId_consoleButton8 = 23;

	[Token(Token = "0x4000C1C")]
	public const int elementId_consoleButton9 = 24;

	[Token(Token = "0x4000C1D")]
	public const int elementId_consoleButton10 = 25;

	[Token(Token = "0x4000C1E")]
	public const int elementId_shifter1 = 26;

	[Token(Token = "0x4000C1F")]
	public const int elementId_shifter2 = 27;

	[Token(Token = "0x4000C20")]
	public const int elementId_shifter3 = 28;

	[Token(Token = "0x4000C21")]
	public const int elementId_shifter4 = 29;

	[Token(Token = "0x4000C22")]
	public const int elementId_shifter5 = 30;

	[Token(Token = "0x4000C23")]
	public const int elementId_shifter6 = 31;

	[Token(Token = "0x4000C24")]
	public const int elementId_shifter7 = 32;

	[Token(Token = "0x4000C25")]
	public const int elementId_shifter8 = 33;

	[Token(Token = "0x4000C26")]
	public const int elementId_shifter9 = 34;

	[Token(Token = "0x4000C27")]
	public const int elementId_shifter10 = 35;

	[Token(Token = "0x4000C28")]
	public const int elementId_reverseGear = 44;

	[Token(Token = "0x4000C29")]
	public const int elementId_select = 36;

	[Token(Token = "0x4000C2A")]
	public const int elementId_start = 37;

	[Token(Token = "0x4000C2B")]
	public const int elementId_systemButton = 38;

	[Token(Token = "0x4000C2C")]
	public const int elementId_horn = 43;

	[Token(Token = "0x4000C2D")]
	public const int elementId_dPadUp = 39;

	[Token(Token = "0x4000C2E")]
	public const int elementId_dPadRight = 40;

	[Token(Token = "0x4000C2F")]
	public const int elementId_dPadDown = 41;

	[Token(Token = "0x4000C30")]
	public const int elementId_dPadLeft = 42;

	[Token(Token = "0x4000C31")]
	public const int elementId_dPad = 45;

	[Token(Token = "0x17000229")]
	private IControllerTemplateAxis Rewired_002EIRacingWheelTemplate_002Ewheel
	{
		[Address(RVA = "0x89C350", Offset = "0x89AB50", Length = "0x3A")]
		[Token(Token = "0x6000ED7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700022A")]
	private IControllerTemplateAxis Rewired_002EIRacingWheelTemplate_002Eaccelerator
	{
		[Address(RVA = "0x89B910", Offset = "0x89A110", Length = "0x3D")]
		[Token(Token = "0x6000ED8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700022B")]
	private IControllerTemplateAxis Rewired_002EIRacingWheelTemplate_002Ebrake
	{
		[Token(Token = "0x6000ED9")]
		[Address(RVA = "0x89B950", Offset = "0x89A150", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700022C")]
	private IControllerTemplateAxis Rewired_002EIRacingWheelTemplate_002Eclutch
	{
		[Token(Token = "0x6000EDA")]
		[Address(RVA = "0x89B990", Offset = "0x89A190", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700022D")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EshiftDown
	{
		[Token(Token = "0x6000EDB")]
		[Address(RVA = "0x89BD50", Offset = "0x89A550", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700022E")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EshiftUp
	{
		[Token(Token = "0x6000EDC")]
		[Address(RVA = "0x89BD90", Offset = "0x89A590", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700022F")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EwheelButton1
	{
		[Address(RVA = "0x89C110", Offset = "0x89A910", Length = "0x3D")]
		[Token(Token = "0x6000EDD")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000230")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EwheelButton2
	{
		[Token(Token = "0x6000EDE")]
		[Address(RVA = "0x89C150", Offset = "0x89A950", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000231")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EwheelButton3
	{
		[Token(Token = "0x6000EDF")]
		[Address(RVA = "0x89C190", Offset = "0x89A990", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000232")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EwheelButton4
	{
		[Address(RVA = "0x89C1D0", Offset = "0x89A9D0", Length = "0x3D")]
		[Token(Token = "0x6000EE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000233")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EwheelButton5
	{
		[Token(Token = "0x6000EE1")]
		[Address(RVA = "0x89C210", Offset = "0x89AA10", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000234")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EwheelButton6
	{
		[Token(Token = "0x6000EE2")]
		[Address(RVA = "0x89C250", Offset = "0x89AA50", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000235")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EwheelButton7
	{
		[Address(RVA = "0x89C290", Offset = "0x89AA90", Length = "0x3D")]
		[Token(Token = "0x6000EE3")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000236")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EwheelButton8
	{
		[Address(RVA = "0x89C2D0", Offset = "0x89AAD0", Length = "0x3D")]
		[Token(Token = "0x6000EE4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000237")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EwheelButton9
	{
		[Token(Token = "0x6000EE5")]
		[Address(RVA = "0x89C310", Offset = "0x89AB10", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000238")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EwheelButton10
	{
		[Token(Token = "0x6000EE6")]
		[Address(RVA = "0x89C0D0", Offset = "0x89A8D0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000239")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EconsoleButton1
	{
		[Address(RVA = "0x89BA10", Offset = "0x89A210", Length = "0x3D")]
		[Token(Token = "0x6000EE7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700023A")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EconsoleButton2
	{
		[Token(Token = "0x6000EE8")]
		[Address(RVA = "0x89BA50", Offset = "0x89A250", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700023B")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EconsoleButton3
	{
		[Address(RVA = "0x89BA90", Offset = "0x89A290", Length = "0x3D")]
		[Token(Token = "0x6000EE9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700023C")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EconsoleButton4
	{
		[Token(Token = "0x6000EEA")]
		[Address(RVA = "0x89BAD0", Offset = "0x89A2D0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700023D")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EconsoleButton5
	{
		[Address(RVA = "0x89BB10", Offset = "0x89A310", Length = "0x3D")]
		[Token(Token = "0x6000EEB")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700023E")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EconsoleButton6
	{
		[Address(RVA = "0x89BB50", Offset = "0x89A350", Length = "0x3D")]
		[Token(Token = "0x6000EEC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700023F")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EconsoleButton7
	{
		[Address(RVA = "0x89BB90", Offset = "0x89A390", Length = "0x3D")]
		[Token(Token = "0x6000EED")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000240")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EconsoleButton8
	{
		[Address(RVA = "0x89BBD0", Offset = "0x89A3D0", Length = "0x3D")]
		[Token(Token = "0x6000EEE")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000241")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EconsoleButton9
	{
		[Token(Token = "0x6000EEF")]
		[Address(RVA = "0x89BC10", Offset = "0x89A410", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000242")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EconsoleButton10
	{
		[Token(Token = "0x6000EF0")]
		[Address(RVA = "0x89B9D0", Offset = "0x89A1D0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000243")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002Eshifter1
	{
		[Token(Token = "0x6000EF1")]
		[Address(RVA = "0x89BE10", Offset = "0x89A610", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000244")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002Eshifter2
	{
		[Token(Token = "0x6000EF2")]
		[Address(RVA = "0x89BE50", Offset = "0x89A650", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000245")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002Eshifter3
	{
		[Token(Token = "0x6000EF3")]
		[Address(RVA = "0x89BE90", Offset = "0x89A690", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000246")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002Eshifter4
	{
		[Address(RVA = "0x89BED0", Offset = "0x89A6D0", Length = "0x3D")]
		[Token(Token = "0x6000EF4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000247")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002Eshifter5
	{
		[Address(RVA = "0x89BF10", Offset = "0x89A710", Length = "0x3D")]
		[Token(Token = "0x6000EF5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000248")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002Eshifter6
	{
		[Token(Token = "0x6000EF6")]
		[Address(RVA = "0x89BF50", Offset = "0x89A750", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000249")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002Eshifter7
	{
		[Token(Token = "0x6000EF7")]
		[Address(RVA = "0x89BF90", Offset = "0x89A790", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700024A")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002Eshifter8
	{
		[Address(RVA = "0x89BFD0", Offset = "0x89A7D0", Length = "0x3D")]
		[Token(Token = "0x6000EF8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700024B")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002Eshifter9
	{
		[Token(Token = "0x6000EF9")]
		[Address(RVA = "0x89C010", Offset = "0x89A810", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700024C")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002Eshifter10
	{
		[Address(RVA = "0x89BDD0", Offset = "0x89A5D0", Length = "0x3D")]
		[Token(Token = "0x6000EFA")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700024D")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EreverseGear
	{
		[Address(RVA = "0x89BCD0", Offset = "0x89A4D0", Length = "0x3D")]
		[Token(Token = "0x6000EFB")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700024E")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002Eselect
	{
		[Address(RVA = "0x89BD10", Offset = "0x89A510", Length = "0x3D")]
		[Token(Token = "0x6000EFC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700024F")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002Estart
	{
		[Address(RVA = "0x89C050", Offset = "0x89A850", Length = "0x3D")]
		[Token(Token = "0x6000EFD")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000250")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EsystemButton
	{
		[Address(RVA = "0x89C090", Offset = "0x89A890", Length = "0x3D")]
		[Token(Token = "0x6000EFE")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000251")]
	private IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002Ehorn
	{
		[Address(RVA = "0x89BC90", Offset = "0x89A490", Length = "0x3D")]
		[Token(Token = "0x6000EFF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000252")]
	private IControllerTemplateDPad Rewired_002EIRacingWheelTemplate_002EdPad
	{
		[Address(RVA = "0x89BC50", Offset = "0x89A450", Length = "0x3D")]
		[Token(Token = "0x6000F00")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x89C3F0", Offset = "0x89ABF0", Length = "0x8")]
	[Token(Token = "0x6000F01")]
	public RacingWheelTemplate(object payload)
		: base(null)
	{
	}
}
