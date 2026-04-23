using System;
using Cpp2ILInjected;

namespace Rewired;

[Token(Token = "0x20001E9")]
public sealed class HOTASTemplate : ControllerTemplate, IHOTASTemplate, IControllerTemplate
{
	[Token(Token = "0x4000C32")]
	public static readonly Guid typeGuid;

	[Token(Token = "0x4000C33")]
	public const int elementId_stickX = 0;

	[Token(Token = "0x4000C34")]
	public const int elementId_stickY = 1;

	[Token(Token = "0x4000C35")]
	public const int elementId_stickRotate = 2;

	[Token(Token = "0x4000C36")]
	public const int elementId_stickMiniStick1X = 78;

	[Token(Token = "0x4000C37")]
	public const int elementId_stickMiniStick1Y = 79;

	[Token(Token = "0x4000C38")]
	public const int elementId_stickMiniStick1Press = 80;

	[Token(Token = "0x4000C39")]
	public const int elementId_stickMiniStick2X = 81;

	[Token(Token = "0x4000C3A")]
	public const int elementId_stickMiniStick2Y = 82;

	[Token(Token = "0x4000C3B")]
	public const int elementId_stickMiniStick2Press = 83;

	[Token(Token = "0x4000C3C")]
	public const int elementId_stickTrigger = 3;

	[Token(Token = "0x4000C3D")]
	public const int elementId_stickTriggerStage2 = 4;

	[Token(Token = "0x4000C3E")]
	public const int elementId_stickPinkyButton = 5;

	[Token(Token = "0x4000C3F")]
	public const int elementId_stickPinkyTrigger = 154;

	[Token(Token = "0x4000C40")]
	public const int elementId_stickButton1 = 6;

	[Token(Token = "0x4000C41")]
	public const int elementId_stickButton2 = 7;

	[Token(Token = "0x4000C42")]
	public const int elementId_stickButton3 = 8;

	[Token(Token = "0x4000C43")]
	public const int elementId_stickButton4 = 9;

	[Token(Token = "0x4000C44")]
	public const int elementId_stickButton5 = 10;

	[Token(Token = "0x4000C45")]
	public const int elementId_stickButton6 = 11;

	[Token(Token = "0x4000C46")]
	public const int elementId_stickButton7 = 12;

	[Token(Token = "0x4000C47")]
	public const int elementId_stickButton8 = 13;

	[Token(Token = "0x4000C48")]
	public const int elementId_stickButton9 = 14;

	[Token(Token = "0x4000C49")]
	public const int elementId_stickButton10 = 15;

	[Token(Token = "0x4000C4A")]
	public const int elementId_stickBaseButton1 = 18;

	[Token(Token = "0x4000C4B")]
	public const int elementId_stickBaseButton2 = 19;

	[Token(Token = "0x4000C4C")]
	public const int elementId_stickBaseButton3 = 20;

	[Token(Token = "0x4000C4D")]
	public const int elementId_stickBaseButton4 = 21;

	[Token(Token = "0x4000C4E")]
	public const int elementId_stickBaseButton5 = 22;

	[Token(Token = "0x4000C4F")]
	public const int elementId_stickBaseButton6 = 23;

	[Token(Token = "0x4000C50")]
	public const int elementId_stickBaseButton7 = 24;

	[Token(Token = "0x4000C51")]
	public const int elementId_stickBaseButton8 = 25;

	[Token(Token = "0x4000C52")]
	public const int elementId_stickBaseButton9 = 26;

	[Token(Token = "0x4000C53")]
	public const int elementId_stickBaseButton10 = 27;

	[Token(Token = "0x4000C54")]
	public const int elementId_stickBaseButton11 = 161;

	[Token(Token = "0x4000C55")]
	public const int elementId_stickBaseButton12 = 162;

	[Token(Token = "0x4000C56")]
	public const int elementId_stickHat1Up = 28;

	[Token(Token = "0x4000C57")]
	public const int elementId_stickHat1UpRight = 29;

	[Token(Token = "0x4000C58")]
	public const int elementId_stickHat1Right = 30;

	[Token(Token = "0x4000C59")]
	public const int elementId_stickHat1DownRight = 31;

	[Token(Token = "0x4000C5A")]
	public const int elementId_stickHat1Down = 32;

	[Token(Token = "0x4000C5B")]
	public const int elementId_stickHat1DownLeft = 33;

	[Token(Token = "0x4000C5C")]
	public const int elementId_stickHat1Left = 34;

	[Token(Token = "0x4000C5D")]
	public const int elementId_stickHat1Up_Left = 35;

	[Token(Token = "0x4000C5E")]
	public const int elementId_stickHat2Up = 36;

	[Token(Token = "0x4000C5F")]
	public const int elementId_stickHat2Up_right = 37;

	[Token(Token = "0x4000C60")]
	public const int elementId_stickHat2Right = 38;

	[Token(Token = "0x4000C61")]
	public const int elementId_stickHat2Down_Right = 39;

	[Token(Token = "0x4000C62")]
	public const int elementId_stickHat2Down = 40;

	[Token(Token = "0x4000C63")]
	public const int elementId_stickHat2Down_Left = 41;

	[Token(Token = "0x4000C64")]
	public const int elementId_stickHat2Left = 42;

	[Token(Token = "0x4000C65")]
	public const int elementId_stickHat2Up_Left = 43;

	[Token(Token = "0x4000C66")]
	public const int elementId_stickHat3Up = 84;

	[Token(Token = "0x4000C67")]
	public const int elementId_stickHat3Up_Right = 85;

	[Token(Token = "0x4000C68")]
	public const int elementId_stickHat3Right = 86;

	[Token(Token = "0x4000C69")]
	public const int elementId_stickHat3Down_Right = 87;

	[Token(Token = "0x4000C6A")]
	public const int elementId_stickHat3Down = 88;

	[Token(Token = "0x4000C6B")]
	public const int elementId_stickHat3Down_Left = 89;

	[Token(Token = "0x4000C6C")]
	public const int elementId_stickHat3Left = 90;

	[Token(Token = "0x4000C6D")]
	public const int elementId_stickHat3Up_Left = 91;

	[Token(Token = "0x4000C6E")]
	public const int elementId_stickHat4Up = 92;

	[Token(Token = "0x4000C6F")]
	public const int elementId_stickHat4Up_Right = 93;

	[Token(Token = "0x4000C70")]
	public const int elementId_stickHat4Right = 94;

	[Token(Token = "0x4000C71")]
	public const int elementId_stickHat4Down_Right = 95;

	[Token(Token = "0x4000C72")]
	public const int elementId_stickHat4Down = 96;

	[Token(Token = "0x4000C73")]
	public const int elementId_stickHat4Down_Left = 97;

	[Token(Token = "0x4000C74")]
	public const int elementId_stickHat4Left = 98;

	[Token(Token = "0x4000C75")]
	public const int elementId_stickHat4Up_Left = 99;

	[Token(Token = "0x4000C76")]
	public const int elementId_mode1 = 44;

	[Token(Token = "0x4000C77")]
	public const int elementId_mode2 = 45;

	[Token(Token = "0x4000C78")]
	public const int elementId_mode3 = 46;

	[Token(Token = "0x4000C79")]
	public const int elementId_throttle1Axis = 49;

	[Token(Token = "0x4000C7A")]
	public const int elementId_throttle2Axis = 155;

	[Token(Token = "0x4000C7B")]
	public const int elementId_throttle1MinDetent = 166;

	[Token(Token = "0x4000C7C")]
	public const int elementId_throttle2MinDetent = 167;

	[Token(Token = "0x4000C7D")]
	public const int elementId_throttleButton1 = 50;

	[Token(Token = "0x4000C7E")]
	public const int elementId_throttleButton2 = 51;

	[Token(Token = "0x4000C7F")]
	public const int elementId_throttleButton3 = 52;

	[Token(Token = "0x4000C80")]
	public const int elementId_throttleButton4 = 53;

	[Token(Token = "0x4000C81")]
	public const int elementId_throttleButton5 = 54;

	[Token(Token = "0x4000C82")]
	public const int elementId_throttleButton6 = 55;

	[Token(Token = "0x4000C83")]
	public const int elementId_throttleButton7 = 56;

	[Token(Token = "0x4000C84")]
	public const int elementId_throttleButton8 = 57;

	[Token(Token = "0x4000C85")]
	public const int elementId_throttleButton9 = 58;

	[Token(Token = "0x4000C86")]
	public const int elementId_throttleButton10 = 59;

	[Token(Token = "0x4000C87")]
	public const int elementId_throttleBaseButton1 = 60;

	[Token(Token = "0x4000C88")]
	public const int elementId_throttleBaseButton2 = 61;

	[Token(Token = "0x4000C89")]
	public const int elementId_throttleBaseButton3 = 62;

	[Token(Token = "0x4000C8A")]
	public const int elementId_throttleBaseButton4 = 63;

	[Token(Token = "0x4000C8B")]
	public const int elementId_throttleBaseButton5 = 64;

	[Token(Token = "0x4000C8C")]
	public const int elementId_throttleBaseButton6 = 65;

	[Token(Token = "0x4000C8D")]
	public const int elementId_throttleBaseButton7 = 66;

	[Token(Token = "0x4000C8E")]
	public const int elementId_throttleBaseButton8 = 67;

	[Token(Token = "0x4000C8F")]
	public const int elementId_throttleBaseButton9 = 68;

	[Token(Token = "0x4000C90")]
	public const int elementId_throttleBaseButton10 = 69;

	[Token(Token = "0x4000C91")]
	public const int elementId_throttleBaseButton11 = 132;

	[Token(Token = "0x4000C92")]
	public const int elementId_throttleBaseButton12 = 133;

	[Token(Token = "0x4000C93")]
	public const int elementId_throttleBaseButton13 = 134;

	[Token(Token = "0x4000C94")]
	public const int elementId_throttleBaseButton14 = 135;

	[Token(Token = "0x4000C95")]
	public const int elementId_throttleBaseButton15 = 136;

	[Token(Token = "0x4000C96")]
	public const int elementId_throttleSlider1 = 70;

	[Token(Token = "0x4000C97")]
	public const int elementId_throttleSlider2 = 71;

	[Token(Token = "0x4000C98")]
	public const int elementId_throttleSlider3 = 72;

	[Token(Token = "0x4000C99")]
	public const int elementId_throttleSlider4 = 73;

	[Token(Token = "0x4000C9A")]
	public const int elementId_throttleDial1 = 74;

	[Token(Token = "0x4000C9B")]
	public const int elementId_throttleDial2 = 142;

	[Token(Token = "0x4000C9C")]
	public const int elementId_throttleDial3 = 143;

	[Token(Token = "0x4000C9D")]
	public const int elementId_throttleDial4 = 144;

	[Token(Token = "0x4000C9E")]
	public const int elementId_throttleMiniStickX = 75;

	[Token(Token = "0x4000C9F")]
	public const int elementId_throttleMiniStickY = 76;

	[Token(Token = "0x4000CA0")]
	public const int elementId_throttleMiniStickPress = 77;

	[Token(Token = "0x4000CA1")]
	public const int elementId_throttleWheel1Forward = 145;

	[Token(Token = "0x4000CA2")]
	public const int elementId_throttleWheel1Back = 146;

	[Token(Token = "0x4000CA3")]
	public const int elementId_throttleWheel1Press = 147;

	[Token(Token = "0x4000CA4")]
	public const int elementId_throttleWheel2Forward = 148;

	[Token(Token = "0x4000CA5")]
	public const int elementId_throttleWheel2Back = 149;

	[Token(Token = "0x4000CA6")]
	public const int elementId_throttleWheel2Press = 150;

	[Token(Token = "0x4000CA7")]
	public const int elementId_throttleWheel3Forward = 151;

	[Token(Token = "0x4000CA8")]
	public const int elementId_throttleWheel3Back = 152;

	[Token(Token = "0x4000CA9")]
	public const int elementId_throttleWheel3Press = 153;

	[Token(Token = "0x4000CAA")]
	public const int elementId_throttleHat1Up = 100;

	[Token(Token = "0x4000CAB")]
	public const int elementId_throttleHat1Up_Right = 101;

	[Token(Token = "0x4000CAC")]
	public const int elementId_throttleHat1Right = 102;

	[Token(Token = "0x4000CAD")]
	public const int elementId_throttleHat1Down_Right = 103;

	[Token(Token = "0x4000CAE")]
	public const int elementId_throttleHat1Down = 104;

	[Token(Token = "0x4000CAF")]
	public const int elementId_throttleHat1Down_Left = 105;

	[Token(Token = "0x4000CB0")]
	public const int elementId_throttleHat1Left = 106;

	[Token(Token = "0x4000CB1")]
	public const int elementId_throttleHat1Up_Left = 107;

	[Token(Token = "0x4000CB2")]
	public const int elementId_throttleHat2Up = 108;

	[Token(Token = "0x4000CB3")]
	public const int elementId_throttleHat2Up_Right = 109;

	[Token(Token = "0x4000CB4")]
	public const int elementId_throttleHat2Right = 110;

	[Token(Token = "0x4000CB5")]
	public const int elementId_throttleHat2Down_Right = 111;

	[Token(Token = "0x4000CB6")]
	public const int elementId_throttleHat2Down = 112;

	[Token(Token = "0x4000CB7")]
	public const int elementId_throttleHat2Down_Left = 113;

	[Token(Token = "0x4000CB8")]
	public const int elementId_throttleHat2Left = 114;

	[Token(Token = "0x4000CB9")]
	public const int elementId_throttleHat2Up_Left = 115;

	[Token(Token = "0x4000CBA")]
	public const int elementId_throttleHat3Up = 116;

	[Token(Token = "0x4000CBB")]
	public const int elementId_throttleHat3Up_Right = 117;

	[Token(Token = "0x4000CBC")]
	public const int elementId_throttleHat3Right = 118;

	[Token(Token = "0x4000CBD")]
	public const int elementId_throttleHat3Down_Right = 119;

	[Token(Token = "0x4000CBE")]
	public const int elementId_throttleHat3Down = 120;

	[Token(Token = "0x4000CBF")]
	public const int elementId_throttleHat3Down_Left = 121;

	[Token(Token = "0x4000CC0")]
	public const int elementId_throttleHat3Left = 122;

	[Token(Token = "0x4000CC1")]
	public const int elementId_throttleHat3Up_Left = 123;

	[Token(Token = "0x4000CC2")]
	public const int elementId_throttleHat4Up = 124;

	[Token(Token = "0x4000CC3")]
	public const int elementId_throttleHat4Up_Right = 125;

	[Token(Token = "0x4000CC4")]
	public const int elementId_throttleHat4Right = 126;

	[Token(Token = "0x4000CC5")]
	public const int elementId_throttleHat4Down_Right = 127;

	[Token(Token = "0x4000CC6")]
	public const int elementId_throttleHat4Down = 128;

	[Token(Token = "0x4000CC7")]
	public const int elementId_throttleHat4Down_Left = 129;

	[Token(Token = "0x4000CC8")]
	public const int elementId_throttleHat4Left = 130;

	[Token(Token = "0x4000CC9")]
	public const int elementId_throttleHat4Up_Left = 131;

	[Token(Token = "0x4000CCA")]
	public const int elementId_leftPedal = 168;

	[Token(Token = "0x4000CCB")]
	public const int elementId_rightPedal = 169;

	[Token(Token = "0x4000CCC")]
	public const int elementId_slidePedals = 170;

	[Token(Token = "0x4000CCD")]
	public const int elementId_stick = 171;

	[Token(Token = "0x4000CCE")]
	public const int elementId_stickMiniStick1 = 172;

	[Token(Token = "0x4000CCF")]
	public const int elementId_stickMiniStick2 = 173;

	[Token(Token = "0x4000CD0")]
	public const int elementId_stickHat1 = 174;

	[Token(Token = "0x4000CD1")]
	public const int elementId_stickHat2 = 175;

	[Token(Token = "0x4000CD2")]
	public const int elementId_stickHat3 = 176;

	[Token(Token = "0x4000CD3")]
	public const int elementId_stickHat4 = 177;

	[Token(Token = "0x4000CD4")]
	public const int elementId_throttle1 = 178;

	[Token(Token = "0x4000CD5")]
	public const int elementId_throttle2 = 179;

	[Token(Token = "0x4000CD6")]
	public const int elementId_throttleMiniStick = 180;

	[Token(Token = "0x4000CD7")]
	public const int elementId_throttleHat1 = 181;

	[Token(Token = "0x4000CD8")]
	public const int elementId_throttleHat2 = 182;

	[Token(Token = "0x4000CD9")]
	public const int elementId_throttleHat3 = 183;

	[Token(Token = "0x4000CDA")]
	public const int elementId_throttleHat4 = 184;

	[Token(Token = "0x17000253")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickTrigger
	{
		[Address(RVA = "0xF98790", Offset = "0xF96F90", Length = "0x3D")]
		[Token(Token = "0x6000F03")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000254")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickTriggerStage2
	{
		[Address(RVA = "0xF98750", Offset = "0xF96F50", Length = "0x3D")]
		[Token(Token = "0x6000F04")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000255")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickPinkyButton
	{
		[Address(RVA = "0xF986D0", Offset = "0xF96ED0", Length = "0x3D")]
		[Token(Token = "0x6000F05")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000256")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickPinkyTrigger
	{
		[Token(Token = "0x6000F06")]
		[Address(RVA = "0xF98710", Offset = "0xF96F10", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000257")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickButton1
	{
		[Address(RVA = "0xF98310", Offset = "0xF96B10", Length = "0x3D")]
		[Token(Token = "0x6000F07")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000258")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickButton2
	{
		[Token(Token = "0x6000F08")]
		[Address(RVA = "0xF98350", Offset = "0xF96B50", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000259")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickButton3
	{
		[Address(RVA = "0xF98390", Offset = "0xF96B90", Length = "0x3D")]
		[Token(Token = "0x6000F09")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700025A")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickButton4
	{
		[Address(RVA = "0xF983D0", Offset = "0xF96BD0", Length = "0x3D")]
		[Token(Token = "0x6000F0A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700025B")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickButton5
	{
		[Address(RVA = "0xF98410", Offset = "0xF96C10", Length = "0x3D")]
		[Token(Token = "0x6000F0B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700025C")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickButton6
	{
		[Address(RVA = "0xF98450", Offset = "0xF96C50", Length = "0x3D")]
		[Token(Token = "0x6000F0C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700025D")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickButton7
	{
		[Token(Token = "0x6000F0D")]
		[Address(RVA = "0xF98490", Offset = "0xF96C90", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700025E")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickButton8
	{
		[Address(RVA = "0xF984D0", Offset = "0xF96CD0", Length = "0x3D")]
		[Token(Token = "0x6000F0E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700025F")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickButton9
	{
		[Address(RVA = "0xF98510", Offset = "0xF96D10", Length = "0x3D")]
		[Token(Token = "0x6000F0F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000260")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickButton10
	{
		[Address(RVA = "0xF982D0", Offset = "0xF96AD0", Length = "0x3D")]
		[Token(Token = "0x6000F10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000261")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickBaseButton1
	{
		[Token(Token = "0x6000F11")]
		[Address(RVA = "0xF98090", Offset = "0xF96890", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000262")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickBaseButton2
	{
		[Address(RVA = "0xF980D0", Offset = "0xF968D0", Length = "0x3D")]
		[Token(Token = "0x6000F12")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000263")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickBaseButton3
	{
		[Address(RVA = "0xF98110", Offset = "0xF96910", Length = "0x3D")]
		[Token(Token = "0x6000F13")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000264")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickBaseButton4
	{
		[Address(RVA = "0xF98150", Offset = "0xF96950", Length = "0x3D")]
		[Token(Token = "0x6000F14")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000265")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickBaseButton5
	{
		[Address(RVA = "0xF98190", Offset = "0xF96990", Length = "0x3D")]
		[Token(Token = "0x6000F15")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000266")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickBaseButton6
	{
		[Token(Token = "0x6000F16")]
		[Address(RVA = "0xF981D0", Offset = "0xF969D0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000267")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickBaseButton7
	{
		[Address(RVA = "0xF98210", Offset = "0xF96A10", Length = "0x3D")]
		[Token(Token = "0x6000F17")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000268")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickBaseButton8
	{
		[Token(Token = "0x6000F18")]
		[Address(RVA = "0xF98250", Offset = "0xF96A50", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000269")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickBaseButton9
	{
		[Address(RVA = "0xF98290", Offset = "0xF96A90", Length = "0x3D")]
		[Token(Token = "0x6000F19")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700026A")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickBaseButton10
	{
		[Address(RVA = "0xF97FD0", Offset = "0xF967D0", Length = "0x3D")]
		[Token(Token = "0x6000F1A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700026B")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickBaseButton11
	{
		[Address(RVA = "0xF98010", Offset = "0xF96810", Length = "0x3D")]
		[Token(Token = "0x6000F1B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700026C")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickBaseButton12
	{
		[Token(Token = "0x6000F1C")]
		[Address(RVA = "0xF98050", Offset = "0xF96850", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700026D")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002Emode1
	{
		[Token(Token = "0x6000F1D")]
		[Address(RVA = "0xF97E90", Offset = "0xF96690", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700026E")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002Emode2
	{
		[Token(Token = "0x6000F1E")]
		[Address(RVA = "0xF97ED0", Offset = "0xF966D0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700026F")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002Emode3
	{
		[Address(RVA = "0xF97F10", Offset = "0xF96710", Length = "0x3D")]
		[Token(Token = "0x6000F1F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000270")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleButton1
	{
		[Token(Token = "0x6000F20")]
		[Address(RVA = "0xF98C90", Offset = "0xF97490", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000271")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleButton2
	{
		[Token(Token = "0x6000F21")]
		[Address(RVA = "0xF98CD0", Offset = "0xF974D0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000272")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleButton3
	{
		[Token(Token = "0x6000F22")]
		[Address(RVA = "0xF98D10", Offset = "0xF97510", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000273")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleButton4
	{
		[Token(Token = "0x6000F23")]
		[Address(RVA = "0xF98D50", Offset = "0xF97550", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000274")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleButton5
	{
		[Token(Token = "0x6000F24")]
		[Address(RVA = "0xF98D90", Offset = "0xF97590", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000275")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleButton6
	{
		[Token(Token = "0x6000F25")]
		[Address(RVA = "0xF98DD0", Offset = "0xF975D0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000276")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleButton7
	{
		[Address(RVA = "0xF98E10", Offset = "0xF97610", Length = "0x3D")]
		[Token(Token = "0x6000F26")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000277")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleButton8
	{
		[Address(RVA = "0xF98E50", Offset = "0xF97650", Length = "0x3D")]
		[Token(Token = "0x6000F27")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000278")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleButton9
	{
		[Token(Token = "0x6000F28")]
		[Address(RVA = "0xF98E90", Offset = "0xF97690", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000279")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleButton10
	{
		[Token(Token = "0x6000F29")]
		[Address(RVA = "0xF98C50", Offset = "0xF97450", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700027A")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton1
	{
		[Token(Token = "0x6000F2A")]
		[Address(RVA = "0xF98A10", Offset = "0xF97210", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700027B")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton2
	{
		[Token(Token = "0x6000F2B")]
		[Address(RVA = "0xF98A50", Offset = "0xF97250", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700027C")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton3
	{
		[Token(Token = "0x6000F2C")]
		[Address(RVA = "0xF98A90", Offset = "0xF97290", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700027D")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton4
	{
		[Address(RVA = "0xF98AD0", Offset = "0xF972D0", Length = "0x3D")]
		[Token(Token = "0x6000F2D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700027E")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton5
	{
		[Address(RVA = "0xF98B10", Offset = "0xF97310", Length = "0x3D")]
		[Token(Token = "0x6000F2E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700027F")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton6
	{
		[Token(Token = "0x6000F2F")]
		[Address(RVA = "0xF98B50", Offset = "0xF97350", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000280")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton7
	{
		[Token(Token = "0x6000F30")]
		[Address(RVA = "0xF98B90", Offset = "0xF97390", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000281")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton8
	{
		[Address(RVA = "0xF98BD0", Offset = "0xF973D0", Length = "0x3D")]
		[Token(Token = "0x6000F31")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000282")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton9
	{
		[Address(RVA = "0xF98C10", Offset = "0xF97410", Length = "0x3D")]
		[Token(Token = "0x6000F32")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000283")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton10
	{
		[Token(Token = "0x6000F33")]
		[Address(RVA = "0xF98890", Offset = "0xF97090", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000284")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton11
	{
		[Token(Token = "0x6000F34")]
		[Address(RVA = "0xF988D0", Offset = "0xF970D0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000285")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton12
	{
		[Token(Token = "0x6000F35")]
		[Address(RVA = "0xF98910", Offset = "0xF97110", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000286")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton13
	{
		[Token(Token = "0x6000F36")]
		[Address(RVA = "0xF98950", Offset = "0xF97150", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000287")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton14
	{
		[Token(Token = "0x6000F37")]
		[Address(RVA = "0xF98990", Offset = "0xF97190", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000288")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton15
	{
		[Address(RVA = "0xF989D0", Offset = "0xF971D0", Length = "0x3D")]
		[Token(Token = "0x6000F38")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000289")]
	private IControllerTemplateAxis Rewired_002EIHOTASTemplate_002EthrottleSlider1
	{
		[Token(Token = "0x6000F39")]
		[Address(RVA = "0xF99110", Offset = "0xF97910", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700028A")]
	private IControllerTemplateAxis Rewired_002EIHOTASTemplate_002EthrottleSlider2
	{
		[Token(Token = "0x6000F3A")]
		[Address(RVA = "0xF99150", Offset = "0xF97950", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700028B")]
	private IControllerTemplateAxis Rewired_002EIHOTASTemplate_002EthrottleSlider3
	{
		[Token(Token = "0x6000F3B")]
		[Address(RVA = "0xF99190", Offset = "0xF97990", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700028C")]
	private IControllerTemplateAxis Rewired_002EIHOTASTemplate_002EthrottleSlider4
	{
		[Token(Token = "0x6000F3C")]
		[Address(RVA = "0xF991D0", Offset = "0xF979D0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700028D")]
	private IControllerTemplateAxis Rewired_002EIHOTASTemplate_002EthrottleDial1
	{
		[Address(RVA = "0xF98ED0", Offset = "0xF976D0", Length = "0x3D")]
		[Token(Token = "0x6000F3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700028E")]
	private IControllerTemplateAxis Rewired_002EIHOTASTemplate_002EthrottleDial2
	{
		[Token(Token = "0x6000F3E")]
		[Address(RVA = "0xF98F10", Offset = "0xF97710", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700028F")]
	private IControllerTemplateAxis Rewired_002EIHOTASTemplate_002EthrottleDial3
	{
		[Token(Token = "0x6000F3F")]
		[Address(RVA = "0xF98F50", Offset = "0xF97750", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000290")]
	private IControllerTemplateAxis Rewired_002EIHOTASTemplate_002EthrottleDial4
	{
		[Token(Token = "0x6000F40")]
		[Address(RVA = "0xF98F90", Offset = "0xF97790", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000291")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleWheel1Forward
	{
		[Token(Token = "0x6000F41")]
		[Address(RVA = "0xF99250", Offset = "0xF97A50", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000292")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleWheel1Back
	{
		[Token(Token = "0x6000F42")]
		[Address(RVA = "0xF99210", Offset = "0xF97A10", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000293")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleWheel1Press
	{
		[Token(Token = "0x6000F43")]
		[Address(RVA = "0xF99290", Offset = "0xF97A90", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000294")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleWheel2Forward
	{
		[Address(RVA = "0xF99310", Offset = "0xF97B10", Length = "0x3D")]
		[Token(Token = "0x6000F44")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000295")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleWheel2Back
	{
		[Address(RVA = "0xF992D0", Offset = "0xF97AD0", Length = "0x3D")]
		[Token(Token = "0x6000F45")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000296")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleWheel2Press
	{
		[Address(RVA = "0xF99350", Offset = "0xF97B50", Length = "0x3D")]
		[Token(Token = "0x6000F46")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000297")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleWheel3Forward
	{
		[Token(Token = "0x6000F47")]
		[Address(RVA = "0xF993D0", Offset = "0xF97BD0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000298")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleWheel3Back
	{
		[Address(RVA = "0xF99390", Offset = "0xF97B90", Length = "0x3D")]
		[Token(Token = "0x6000F48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000299")]
	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleWheel3Press
	{
		[Token(Token = "0x6000F49")]
		[Address(RVA = "0xF99410", Offset = "0xF97C10", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700029A")]
	private IControllerTemplateAxis Rewired_002EIHOTASTemplate_002EleftPedal
	{
		[Address(RVA = "0xF97E50", Offset = "0xF96650", Length = "0x3D")]
		[Token(Token = "0x6000F4A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700029B")]
	private IControllerTemplateAxis Rewired_002EIHOTASTemplate_002ErightPedal
	{
		[Address(RVA = "0xF97F50", Offset = "0xF96750", Length = "0x3D")]
		[Token(Token = "0x6000F4B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700029C")]
	private IControllerTemplateAxis Rewired_002EIHOTASTemplate_002EslidePedals
	{
		[Address(RVA = "0xF97F90", Offset = "0xF96790", Length = "0x3D")]
		[Token(Token = "0x6000F4C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700029D")]
	private IControllerTemplateStick Rewired_002EIHOTASTemplate_002Estick
	{
		[Token(Token = "0x6000F4D")]
		[Address(RVA = "0xF987D0", Offset = "0xF96FD0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700029E")]
	private IControllerTemplateThumbStick Rewired_002EIHOTASTemplate_002EstickMiniStick1
	{
		[Token(Token = "0x6000F4E")]
		[Address(RVA = "0xF98650", Offset = "0xF96E50", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700029F")]
	private IControllerTemplateThumbStick Rewired_002EIHOTASTemplate_002EstickMiniStick2
	{
		[Token(Token = "0x6000F4F")]
		[Address(RVA = "0xF98690", Offset = "0xF96E90", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002A0")]
	private IControllerTemplateHat Rewired_002EIHOTASTemplate_002EstickHat1
	{
		[Address(RVA = "0xF98550", Offset = "0xF96D50", Length = "0x3D")]
		[Token(Token = "0x6000F50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002A1")]
	private IControllerTemplateHat Rewired_002EIHOTASTemplate_002EstickHat2
	{
		[Token(Token = "0x6000F51")]
		[Address(RVA = "0xF98590", Offset = "0xF96D90", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002A2")]
	private IControllerTemplateHat Rewired_002EIHOTASTemplate_002EstickHat3
	{
		[Address(RVA = "0xF985D0", Offset = "0xF96DD0", Length = "0x3D")]
		[Token(Token = "0x6000F52")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002A3")]
	private IControllerTemplateHat Rewired_002EIHOTASTemplate_002EstickHat4
	{
		[Token(Token = "0x6000F53")]
		[Address(RVA = "0xF98610", Offset = "0xF96E10", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002A4")]
	private IControllerTemplateThrottle Rewired_002EIHOTASTemplate_002Ethrottle1
	{
		[Token(Token = "0x6000F54")]
		[Address(RVA = "0xF98810", Offset = "0xF97010", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002A5")]
	private IControllerTemplateThrottle Rewired_002EIHOTASTemplate_002Ethrottle2
	{
		[Address(RVA = "0xF98850", Offset = "0xF97050", Length = "0x3D")]
		[Token(Token = "0x6000F55")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002A6")]
	private IControllerTemplateThumbStick Rewired_002EIHOTASTemplate_002EthrottleMiniStick
	{
		[Address(RVA = "0xF990D0", Offset = "0xF978D0", Length = "0x3D")]
		[Token(Token = "0x6000F56")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002A7")]
	private IControllerTemplateHat Rewired_002EIHOTASTemplate_002EthrottleHat1
	{
		[Token(Token = "0x6000F57")]
		[Address(RVA = "0xF98FD0", Offset = "0xF977D0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002A8")]
	private IControllerTemplateHat Rewired_002EIHOTASTemplate_002EthrottleHat2
	{
		[Address(RVA = "0xF99010", Offset = "0xF97810", Length = "0x3D")]
		[Token(Token = "0x6000F58")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002A9")]
	private IControllerTemplateHat Rewired_002EIHOTASTemplate_002EthrottleHat3
	{
		[Address(RVA = "0xF99050", Offset = "0xF97850", Length = "0x3D")]
		[Token(Token = "0x6000F59")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002AA")]
	private IControllerTemplateHat Rewired_002EIHOTASTemplate_002EthrottleHat4
	{
		[Address(RVA = "0xF99090", Offset = "0xF97890", Length = "0x3D")]
		[Token(Token = "0x6000F5A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000F5B")]
	[Address(RVA = "0x89C3F0", Offset = "0x89ABF0", Length = "0x8")]
	public HOTASTemplate(object payload)
		: base(null)
	{
	}
}
