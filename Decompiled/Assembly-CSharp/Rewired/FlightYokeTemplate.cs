using System;
using Cpp2ILInjected;

namespace Rewired;

[Token(Token = "0x20001EA")]
public sealed class FlightYokeTemplate : ControllerTemplate, IFlightYokeTemplate, IControllerTemplate
{
	[Token(Token = "0x4000CDB")]
	public static readonly Guid typeGuid;

	[Token(Token = "0x4000CDC")]
	public const int elementId_rotateYoke = 0;

	[Token(Token = "0x4000CDD")]
	public const int elementId_yokeZ = 1;

	[Token(Token = "0x4000CDE")]
	public const int elementId_leftPaddle = 59;

	[Token(Token = "0x4000CDF")]
	public const int elementId_rightPaddle = 60;

	[Token(Token = "0x4000CE0")]
	public const int elementId_lever1Axis = 2;

	[Token(Token = "0x4000CE1")]
	public const int elementId_lever1MinDetent = 64;

	[Token(Token = "0x4000CE2")]
	public const int elementId_lever2Axis = 3;

	[Token(Token = "0x4000CE3")]
	public const int elementId_lever2MinDetent = 65;

	[Token(Token = "0x4000CE4")]
	public const int elementId_lever3Axis = 4;

	[Token(Token = "0x4000CE5")]
	public const int elementId_lever3MinDetent = 66;

	[Token(Token = "0x4000CE6")]
	public const int elementId_lever4Axis = 5;

	[Token(Token = "0x4000CE7")]
	public const int elementId_lever4MinDetent = 67;

	[Token(Token = "0x4000CE8")]
	public const int elementId_lever5Axis = 6;

	[Token(Token = "0x4000CE9")]
	public const int elementId_lever5MinDetent = 68;

	[Token(Token = "0x4000CEA")]
	public const int elementId_leftGripButton1 = 7;

	[Token(Token = "0x4000CEB")]
	public const int elementId_leftGripButton2 = 8;

	[Token(Token = "0x4000CEC")]
	public const int elementId_leftGripButton3 = 9;

	[Token(Token = "0x4000CED")]
	public const int elementId_leftGripButton4 = 10;

	[Token(Token = "0x4000CEE")]
	public const int elementId_leftGripButton5 = 11;

	[Token(Token = "0x4000CEF")]
	public const int elementId_leftGripButton6 = 12;

	[Token(Token = "0x4000CF0")]
	public const int elementId_rightGripButton1 = 13;

	[Token(Token = "0x4000CF1")]
	public const int elementId_rightGripButton2 = 14;

	[Token(Token = "0x4000CF2")]
	public const int elementId_rightGripButton3 = 15;

	[Token(Token = "0x4000CF3")]
	public const int elementId_rightGripButton4 = 16;

	[Token(Token = "0x4000CF4")]
	public const int elementId_rightGripButton5 = 17;

	[Token(Token = "0x4000CF5")]
	public const int elementId_rightGripButton6 = 18;

	[Token(Token = "0x4000CF6")]
	public const int elementId_centerButton1 = 19;

	[Token(Token = "0x4000CF7")]
	public const int elementId_centerButton2 = 20;

	[Token(Token = "0x4000CF8")]
	public const int elementId_centerButton3 = 21;

	[Token(Token = "0x4000CF9")]
	public const int elementId_centerButton4 = 22;

	[Token(Token = "0x4000CFA")]
	public const int elementId_centerButton5 = 23;

	[Token(Token = "0x4000CFB")]
	public const int elementId_centerButton6 = 24;

	[Token(Token = "0x4000CFC")]
	public const int elementId_centerButton7 = 25;

	[Token(Token = "0x4000CFD")]
	public const int elementId_centerButton8 = 26;

	[Token(Token = "0x4000CFE")]
	public const int elementId_wheel1Up = 53;

	[Token(Token = "0x4000CFF")]
	public const int elementId_wheel1Down = 54;

	[Token(Token = "0x4000D00")]
	public const int elementId_wheel1Press = 55;

	[Token(Token = "0x4000D01")]
	public const int elementId_wheel2Up = 56;

	[Token(Token = "0x4000D02")]
	public const int elementId_wheel2Down = 57;

	[Token(Token = "0x4000D03")]
	public const int elementId_wheel2Press = 58;

	[Token(Token = "0x4000D04")]
	public const int elementId_leftGripHatUp = 27;

	[Token(Token = "0x4000D05")]
	public const int elementId_leftGripHatUpRight = 28;

	[Token(Token = "0x4000D06")]
	public const int elementId_leftGripHatRight = 29;

	[Token(Token = "0x4000D07")]
	public const int elementId_leftGripHatDownRight = 30;

	[Token(Token = "0x4000D08")]
	public const int elementId_leftGripHatDown = 31;

	[Token(Token = "0x4000D09")]
	public const int elementId_leftGripHatDownLeft = 32;

	[Token(Token = "0x4000D0A")]
	public const int elementId_leftGripHatLeft = 33;

	[Token(Token = "0x4000D0B")]
	public const int elementId_leftGripHatUpLeft = 34;

	[Token(Token = "0x4000D0C")]
	public const int elementId_rightGripHatUp = 35;

	[Token(Token = "0x4000D0D")]
	public const int elementId_rightGripHatUpRight = 36;

	[Token(Token = "0x4000D0E")]
	public const int elementId_rightGripHatRight = 37;

	[Token(Token = "0x4000D0F")]
	public const int elementId_rightGripHatDownRight = 38;

	[Token(Token = "0x4000D10")]
	public const int elementId_rightGripHatDown = 39;

	[Token(Token = "0x4000D11")]
	public const int elementId_rightGripHatDownLeft = 40;

	[Token(Token = "0x4000D12")]
	public const int elementId_rightGripHatLeft = 41;

	[Token(Token = "0x4000D13")]
	public const int elementId_rightGripHatUpLeft = 42;

	[Token(Token = "0x4000D14")]
	public const int elementId_consoleButton1 = 43;

	[Token(Token = "0x4000D15")]
	public const int elementId_consoleButton2 = 44;

	[Token(Token = "0x4000D16")]
	public const int elementId_consoleButton3 = 45;

	[Token(Token = "0x4000D17")]
	public const int elementId_consoleButton4 = 46;

	[Token(Token = "0x4000D18")]
	public const int elementId_consoleButton5 = 47;

	[Token(Token = "0x4000D19")]
	public const int elementId_consoleButton6 = 48;

	[Token(Token = "0x4000D1A")]
	public const int elementId_consoleButton7 = 49;

	[Token(Token = "0x4000D1B")]
	public const int elementId_consoleButton8 = 50;

	[Token(Token = "0x4000D1C")]
	public const int elementId_consoleButton9 = 51;

	[Token(Token = "0x4000D1D")]
	public const int elementId_consoleButton10 = 52;

	[Token(Token = "0x4000D1E")]
	public const int elementId_mode1 = 61;

	[Token(Token = "0x4000D1F")]
	public const int elementId_mode2 = 62;

	[Token(Token = "0x4000D20")]
	public const int elementId_mode3 = 63;

	[Token(Token = "0x4000D21")]
	public const int elementId_yoke = 69;

	[Token(Token = "0x4000D22")]
	public const int elementId_lever1 = 70;

	[Token(Token = "0x4000D23")]
	public const int elementId_lever2 = 71;

	[Token(Token = "0x4000D24")]
	public const int elementId_lever3 = 72;

	[Token(Token = "0x4000D25")]
	public const int elementId_lever4 = 73;

	[Token(Token = "0x4000D26")]
	public const int elementId_lever5 = 74;

	[Token(Token = "0x4000D27")]
	public const int elementId_leftGripHat = 75;

	[Token(Token = "0x4000D28")]
	public const int elementId_rightGripHat = 76;

	[Token(Token = "0x170002AB")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EleftPaddle
	{
		[Address(RVA = "0xF94DC0", Offset = "0xF935C0", Length = "0x3D")]
		[Token(Token = "0x6000F5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002AC")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002ErightPaddle
	{
		[Token(Token = "0x6000F5E")]
		[Address(RVA = "0xF951C0", Offset = "0xF939C0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002AD")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EleftGripButton1
	{
		[Address(RVA = "0xF94C00", Offset = "0xF93400", Length = "0x3D")]
		[Token(Token = "0x6000F5F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002AE")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EleftGripButton2
	{
		[Token(Token = "0x6000F60")]
		[Address(RVA = "0xF94C40", Offset = "0xF93440", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002AF")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EleftGripButton3
	{
		[Token(Token = "0x6000F61")]
		[Address(RVA = "0xF94C80", Offset = "0xF93480", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002B0")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EleftGripButton4
	{
		[Token(Token = "0x6000F62")]
		[Address(RVA = "0xF94CC0", Offset = "0xF934C0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002B1")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EleftGripButton5
	{
		[Address(RVA = "0xF94D00", Offset = "0xF93500", Length = "0x3D")]
		[Token(Token = "0x6000F63")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002B2")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EleftGripButton6
	{
		[Token(Token = "0x6000F64")]
		[Address(RVA = "0xF94D40", Offset = "0xF93540", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002B3")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002ErightGripButton1
	{
		[Address(RVA = "0xF95000", Offset = "0xF93800", Length = "0x3D")]
		[Token(Token = "0x6000F65")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002B4")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002ErightGripButton2
	{
		[Address(RVA = "0xF95040", Offset = "0xF93840", Length = "0x3D")]
		[Token(Token = "0x6000F66")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002B5")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002ErightGripButton3
	{
		[Address(RVA = "0xF95080", Offset = "0xF93880", Length = "0x3D")]
		[Token(Token = "0x6000F67")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002B6")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002ErightGripButton4
	{
		[Token(Token = "0x6000F68")]
		[Address(RVA = "0xF950C0", Offset = "0xF938C0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002B7")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002ErightGripButton5
	{
		[Token(Token = "0x6000F69")]
		[Address(RVA = "0xF95100", Offset = "0xF93900", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002B8")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002ErightGripButton6
	{
		[Token(Token = "0x6000F6A")]
		[Address(RVA = "0xF95140", Offset = "0xF93940", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002B9")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EcenterButton1
	{
		[Token(Token = "0x6000F6B")]
		[Address(RVA = "0xF94780", Offset = "0xF92F80", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002BA")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EcenterButton2
	{
		[Address(RVA = "0xF947C0", Offset = "0xF92FC0", Length = "0x3D")]
		[Token(Token = "0x6000F6C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002BB")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EcenterButton3
	{
		[Address(RVA = "0xF94800", Offset = "0xF93000", Length = "0x3D")]
		[Token(Token = "0x6000F6D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002BC")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EcenterButton4
	{
		[Address(RVA = "0xF94840", Offset = "0xF93040", Length = "0x3D")]
		[Token(Token = "0x6000F6E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002BD")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EcenterButton5
	{
		[Token(Token = "0x6000F6F")]
		[Address(RVA = "0xF94880", Offset = "0xF93080", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002BE")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EcenterButton6
	{
		[Token(Token = "0x6000F70")]
		[Address(RVA = "0xF948C0", Offset = "0xF930C0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002BF")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EcenterButton7
	{
		[Token(Token = "0x6000F71")]
		[Address(RVA = "0xF94900", Offset = "0xF93100", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002C0")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EcenterButton8
	{
		[Token(Token = "0x6000F72")]
		[Address(RVA = "0xF94940", Offset = "0xF93140", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002C1")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002Ewheel1Up
	{
		[Token(Token = "0x6000F73")]
		[Address(RVA = "0xF95280", Offset = "0xF93A80", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002C2")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002Ewheel1Down
	{
		[Address(RVA = "0xF95200", Offset = "0xF93A00", Length = "0x3D")]
		[Token(Token = "0x6000F74")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002C3")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002Ewheel1Press
	{
		[Address(RVA = "0xF95240", Offset = "0xF93A40", Length = "0x3D")]
		[Token(Token = "0x6000F75")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002C4")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002Ewheel2Up
	{
		[Address(RVA = "0xF95340", Offset = "0xF93B40", Length = "0x3D")]
		[Token(Token = "0x6000F76")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002C5")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002Ewheel2Down
	{
		[Token(Token = "0x6000F77")]
		[Address(RVA = "0xF952C0", Offset = "0xF93AC0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002C6")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002Ewheel2Press
	{
		[Token(Token = "0x6000F78")]
		[Address(RVA = "0xF95300", Offset = "0xF93B00", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002C7")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton1
	{
		[Token(Token = "0x6000F79")]
		[Address(RVA = "0xF949C0", Offset = "0xF931C0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002C8")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton2
	{
		[Token(Token = "0x6000F7A")]
		[Address(RVA = "0xF94A00", Offset = "0xF93200", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002C9")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton3
	{
		[Address(RVA = "0xF94A40", Offset = "0xF93240", Length = "0x3D")]
		[Token(Token = "0x6000F7B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002CA")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton4
	{
		[Token(Token = "0x6000F7C")]
		[Address(RVA = "0xF94A80", Offset = "0xF93280", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002CB")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton5
	{
		[Address(RVA = "0xF94AC0", Offset = "0xF932C0", Length = "0x3D")]
		[Token(Token = "0x6000F7D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002CC")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton6
	{
		[Address(RVA = "0xF94B00", Offset = "0xF93300", Length = "0x3D")]
		[Token(Token = "0x6000F7E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002CD")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton7
	{
		[Address(RVA = "0xF94B40", Offset = "0xF93340", Length = "0x3D")]
		[Token(Token = "0x6000F7F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002CE")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton8
	{
		[Token(Token = "0x6000F80")]
		[Address(RVA = "0xF94B80", Offset = "0xF93380", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002CF")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton9
	{
		[Token(Token = "0x6000F81")]
		[Address(RVA = "0xF94BC0", Offset = "0xF933C0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002D0")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton10
	{
		[Token(Token = "0x6000F82")]
		[Address(RVA = "0xF94980", Offset = "0xF93180", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002D1")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002Emode1
	{
		[Address(RVA = "0xF94F40", Offset = "0xF93740", Length = "0x3D")]
		[Token(Token = "0x6000F83")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002D2")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002Emode2
	{
		[Token(Token = "0x6000F84")]
		[Address(RVA = "0xF94F80", Offset = "0xF93780", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002D3")]
	private IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002Emode3
	{
		[Address(RVA = "0xF94FC0", Offset = "0xF937C0", Length = "0x3D")]
		[Token(Token = "0x6000F85")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002D4")]
	private IControllerTemplateYoke Rewired_002EIFlightYokeTemplate_002Eyoke
	{
		[Token(Token = "0x6000F86")]
		[Address(RVA = "0xF95380", Offset = "0xF93B80", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002D5")]
	private IControllerTemplateThrottle Rewired_002EIFlightYokeTemplate_002Elever1
	{
		[Address(RVA = "0xF94E00", Offset = "0xF93600", Length = "0x3D")]
		[Token(Token = "0x6000F87")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002D6")]
	private IControllerTemplateThrottle Rewired_002EIFlightYokeTemplate_002Elever2
	{
		[Token(Token = "0x6000F88")]
		[Address(RVA = "0xF94E40", Offset = "0xF93640", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002D7")]
	private IControllerTemplateThrottle Rewired_002EIFlightYokeTemplate_002Elever3
	{
		[Address(RVA = "0xF94E80", Offset = "0xF93680", Length = "0x3D")]
		[Token(Token = "0x6000F89")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002D8")]
	private IControllerTemplateThrottle Rewired_002EIFlightYokeTemplate_002Elever4
	{
		[Token(Token = "0x6000F8A")]
		[Address(RVA = "0xF94EC0", Offset = "0xF936C0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002D9")]
	private IControllerTemplateThrottle Rewired_002EIFlightYokeTemplate_002Elever5
	{
		[Address(RVA = "0xF94F00", Offset = "0xF93700", Length = "0x3D")]
		[Token(Token = "0x6000F8B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002DA")]
	private IControllerTemplateHat Rewired_002EIFlightYokeTemplate_002EleftGripHat
	{
		[Address(RVA = "0xF94D80", Offset = "0xF93580", Length = "0x3D")]
		[Token(Token = "0x6000F8C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002DB")]
	private IControllerTemplateHat Rewired_002EIFlightYokeTemplate_002ErightGripHat
	{
		[Address(RVA = "0xF95180", Offset = "0xF93980", Length = "0x3D")]
		[Token(Token = "0x6000F8D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000F8E")]
	[Address(RVA = "0x89C3F0", Offset = "0x89ABF0", Length = "0x8")]
	public FlightYokeTemplate(object payload)
		: base(null)
	{
	}
}
