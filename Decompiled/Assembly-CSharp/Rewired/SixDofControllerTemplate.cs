using System;
using Cpp2ILInjected;

namespace Rewired;

[Token(Token = "0x20001EC")]
public sealed class SixDofControllerTemplate : ControllerTemplate, ISixDofControllerTemplate, IControllerTemplate
{
	[Token(Token = "0x4000D2D")]
	public static readonly Guid typeGuid;

	[Token(Token = "0x4000D2E")]
	public const int elementId_positionX = 1;

	[Token(Token = "0x4000D2F")]
	public const int elementId_positionY = 2;

	[Token(Token = "0x4000D30")]
	public const int elementId_positionZ = 0;

	[Token(Token = "0x4000D31")]
	public const int elementId_rotationX = 3;

	[Token(Token = "0x4000D32")]
	public const int elementId_rotationY = 5;

	[Token(Token = "0x4000D33")]
	public const int elementId_rotationZ = 4;

	[Token(Token = "0x4000D34")]
	public const int elementId_throttle1Axis = 6;

	[Token(Token = "0x4000D35")]
	public const int elementId_throttle1MinDetent = 50;

	[Token(Token = "0x4000D36")]
	public const int elementId_throttle2Axis = 7;

	[Token(Token = "0x4000D37")]
	public const int elementId_throttle2MinDetent = 51;

	[Token(Token = "0x4000D38")]
	public const int elementId_extraAxis1 = 8;

	[Token(Token = "0x4000D39")]
	public const int elementId_extraAxis2 = 9;

	[Token(Token = "0x4000D3A")]
	public const int elementId_extraAxis3 = 10;

	[Token(Token = "0x4000D3B")]
	public const int elementId_extraAxis4 = 11;

	[Token(Token = "0x4000D3C")]
	public const int elementId_button1 = 12;

	[Token(Token = "0x4000D3D")]
	public const int elementId_button2 = 13;

	[Token(Token = "0x4000D3E")]
	public const int elementId_button3 = 14;

	[Token(Token = "0x4000D3F")]
	public const int elementId_button4 = 15;

	[Token(Token = "0x4000D40")]
	public const int elementId_button5 = 16;

	[Token(Token = "0x4000D41")]
	public const int elementId_button6 = 17;

	[Token(Token = "0x4000D42")]
	public const int elementId_button7 = 18;

	[Token(Token = "0x4000D43")]
	public const int elementId_button8 = 19;

	[Token(Token = "0x4000D44")]
	public const int elementId_button9 = 20;

	[Token(Token = "0x4000D45")]
	public const int elementId_button10 = 21;

	[Token(Token = "0x4000D46")]
	public const int elementId_button11 = 22;

	[Token(Token = "0x4000D47")]
	public const int elementId_button12 = 23;

	[Token(Token = "0x4000D48")]
	public const int elementId_button13 = 24;

	[Token(Token = "0x4000D49")]
	public const int elementId_button14 = 25;

	[Token(Token = "0x4000D4A")]
	public const int elementId_button15 = 26;

	[Token(Token = "0x4000D4B")]
	public const int elementId_button16 = 27;

	[Token(Token = "0x4000D4C")]
	public const int elementId_button17 = 28;

	[Token(Token = "0x4000D4D")]
	public const int elementId_button18 = 29;

	[Token(Token = "0x4000D4E")]
	public const int elementId_button19 = 30;

	[Token(Token = "0x4000D4F")]
	public const int elementId_button20 = 31;

	[Token(Token = "0x4000D50")]
	public const int elementId_button21 = 55;

	[Token(Token = "0x4000D51")]
	public const int elementId_button22 = 56;

	[Token(Token = "0x4000D52")]
	public const int elementId_button23 = 57;

	[Token(Token = "0x4000D53")]
	public const int elementId_button24 = 58;

	[Token(Token = "0x4000D54")]
	public const int elementId_button25 = 59;

	[Token(Token = "0x4000D55")]
	public const int elementId_button26 = 60;

	[Token(Token = "0x4000D56")]
	public const int elementId_button27 = 61;

	[Token(Token = "0x4000D57")]
	public const int elementId_button28 = 62;

	[Token(Token = "0x4000D58")]
	public const int elementId_button29 = 63;

	[Token(Token = "0x4000D59")]
	public const int elementId_button30 = 64;

	[Token(Token = "0x4000D5A")]
	public const int elementId_button31 = 65;

	[Token(Token = "0x4000D5B")]
	public const int elementId_button32 = 66;

	[Token(Token = "0x4000D5C")]
	public const int elementId_hat1Up = 32;

	[Token(Token = "0x4000D5D")]
	public const int elementId_hat1UpRight = 33;

	[Token(Token = "0x4000D5E")]
	public const int elementId_hat1Right = 34;

	[Token(Token = "0x4000D5F")]
	public const int elementId_hat1DownRight = 35;

	[Token(Token = "0x4000D60")]
	public const int elementId_hat1Down = 36;

	[Token(Token = "0x4000D61")]
	public const int elementId_hat1DownLeft = 37;

	[Token(Token = "0x4000D62")]
	public const int elementId_hat1Left = 38;

	[Token(Token = "0x4000D63")]
	public const int elementId_hat1UpLeft = 39;

	[Token(Token = "0x4000D64")]
	public const int elementId_hat2Up = 40;

	[Token(Token = "0x4000D65")]
	public const int elementId_hat2UpRight = 41;

	[Token(Token = "0x4000D66")]
	public const int elementId_hat2Right = 42;

	[Token(Token = "0x4000D67")]
	public const int elementId_hat2DownRight = 43;

	[Token(Token = "0x4000D68")]
	public const int elementId_hat2Down = 44;

	[Token(Token = "0x4000D69")]
	public const int elementId_hat2DownLeft = 45;

	[Token(Token = "0x4000D6A")]
	public const int elementId_hat2Left = 46;

	[Token(Token = "0x4000D6B")]
	public const int elementId_hat2UpLeft = 47;

	[Token(Token = "0x4000D6C")]
	public const int elementId_hat1 = 48;

	[Token(Token = "0x4000D6D")]
	public const int elementId_hat2 = 49;

	[Token(Token = "0x4000D6E")]
	public const int elementId_throttle1 = 52;

	[Token(Token = "0x4000D6F")]
	public const int elementId_throttle2 = 53;

	[Token(Token = "0x4000D70")]
	public const int elementId_stick = 54;

	[Token(Token = "0x170002DF")]
	private IControllerTemplateAxis Rewired_002EISixDofControllerTemplate_002EextraAxis1
	{
		[Address(RVA = "0x8A23B0", Offset = "0x8A0BB0", Length = "0x3D")]
		[Token(Token = "0x6000F95")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002E0")]
	private IControllerTemplateAxis Rewired_002EISixDofControllerTemplate_002EextraAxis2
	{
		[Token(Token = "0x6000F96")]
		[Address(RVA = "0x8A23F0", Offset = "0x8A0BF0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002E1")]
	private IControllerTemplateAxis Rewired_002EISixDofControllerTemplate_002EextraAxis3
	{
		[Token(Token = "0x6000F97")]
		[Address(RVA = "0x8A2430", Offset = "0x8A0C30", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002E2")]
	private IControllerTemplateAxis Rewired_002EISixDofControllerTemplate_002EextraAxis4
	{
		[Token(Token = "0x6000F98")]
		[Address(RVA = "0x8A2470", Offset = "0x8A0C70", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002E3")]
	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton1
	{
		[Address(RVA = "0x8A1E30", Offset = "0x8A0630", Length = "0x3D")]
		[Token(Token = "0x6000F99")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002E4")]
	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton2
	{
		[Address(RVA = "0x8A20F0", Offset = "0x8A08F0", Length = "0x3D")]
		[Token(Token = "0x6000F9A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002E5")]
	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton3
	{
		[Address(RVA = "0x8A21F0", Offset = "0x8A09F0", Length = "0x3D")]
		[Token(Token = "0x6000F9B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002E6")]
	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton4
	{
		[Token(Token = "0x6000F9C")]
		[Address(RVA = "0x8A2230", Offset = "0x8A0A30", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002E7")]
	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton5
	{
		[Address(RVA = "0x8A2270", Offset = "0x8A0A70", Length = "0x3D")]
		[Token(Token = "0x6000F9D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002E8")]
	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton6
	{
		[Token(Token = "0x6000F9E")]
		[Address(RVA = "0x8A22B0", Offset = "0x8A0AB0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002E9")]
	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton7
	{
		[Token(Token = "0x6000F9F")]
		[Address(RVA = "0x8A22F0", Offset = "0x8A0AF0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002EA")]
	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton8
	{
		[Address(RVA = "0x8A2330", Offset = "0x8A0B30", Length = "0x3D")]
		[Token(Token = "0x6000FA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002EB")]
	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton9
	{
		[Token(Token = "0x6000FA1")]
		[Address(RVA = "0x8A2370", Offset = "0x8A0B70", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002EC")]
	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton10
	{
		[Address(RVA = "0x8A1BB0", Offset = "0x8A03B0", Length = "0x3D")]
		[Token(Token = "0x6000FA2")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002ED")]
	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton11
	{
		[Address(RVA = "0x8A1BF0", Offset = "0x8A03F0", Length = "0x3D")]
		[Token(Token = "0x6000FA3")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002EE")]
	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton12
	{
		[Address(RVA = "0x8A1C30", Offset = "0x8A0430", Length = "0x3D")]
		[Token(Token = "0x6000FA4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002EF")]
	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton13
	{
		[Token(Token = "0x6000FA5")]
		[Address(RVA = "0x8A1C70", Offset = "0x8A0470", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002F0")]
	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton14
	{
		[Address(RVA = "0x8A1CB0", Offset = "0x8A04B0", Length = "0x3D")]
		[Token(Token = "0x6000FA6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002F1")]
	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton15
	{
		[Token(Token = "0x6000FA7")]
		[Address(RVA = "0x8A1CF0", Offset = "0x8A04F0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002F2")]
	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton16
	{
		[Address(RVA = "0x8A1D30", Offset = "0x8A0530", Length = "0x3D")]
		[Token(Token = "0x6000FA8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002F3")]
	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton17
	{
		[Address(RVA = "0x8A1D70", Offset = "0x8A0570", Length = "0x3D")]
		[Token(Token = "0x6000FA9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002F4")]
	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton18
	{
		[Address(RVA = "0x8A1DB0", Offset = "0x8A05B0", Length = "0x3D")]
		[Token(Token = "0x6000FAA")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002F5")]
	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton19
	{
		[Token(Token = "0x6000FAB")]
		[Address(RVA = "0x8A1DF0", Offset = "0x8A05F0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002F6")]
	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton20
	{
		[Address(RVA = "0x8A1E70", Offset = "0x8A0670", Length = "0x3D")]
		[Token(Token = "0x6000FAC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002F7")]
	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton21
	{
		[Token(Token = "0x6000FAD")]
		[Address(RVA = "0x8A1EB0", Offset = "0x8A06B0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002F8")]
	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton22
	{
		[Address(RVA = "0x8A1EF0", Offset = "0x8A06F0", Length = "0x3D")]
		[Token(Token = "0x6000FAE")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002F9")]
	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton23
	{
		[Token(Token = "0x6000FAF")]
		[Address(RVA = "0x8A1F30", Offset = "0x8A0730", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002FA")]
	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton24
	{
		[Token(Token = "0x6000FB0")]
		[Address(RVA = "0x8A1F70", Offset = "0x8A0770", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002FB")]
	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton25
	{
		[Token(Token = "0x6000FB1")]
		[Address(RVA = "0x8A1FB0", Offset = "0x8A07B0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002FC")]
	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton26
	{
		[Token(Token = "0x6000FB2")]
		[Address(RVA = "0x8A1FF0", Offset = "0x8A07F0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002FD")]
	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton27
	{
		[Token(Token = "0x6000FB3")]
		[Address(RVA = "0x8A2030", Offset = "0x8A0830", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002FE")]
	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton28
	{
		[Token(Token = "0x6000FB4")]
		[Address(RVA = "0x8A2070", Offset = "0x8A0870", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002FF")]
	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton29
	{
		[Token(Token = "0x6000FB5")]
		[Address(RVA = "0x8A20B0", Offset = "0x8A08B0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000300")]
	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton30
	{
		[Address(RVA = "0x8A2130", Offset = "0x8A0930", Length = "0x3D")]
		[Token(Token = "0x6000FB6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000301")]
	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton31
	{
		[Address(RVA = "0x8A2170", Offset = "0x8A0970", Length = "0x3D")]
		[Token(Token = "0x6000FB7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000302")]
	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton32
	{
		[Token(Token = "0x6000FB8")]
		[Address(RVA = "0x8A21B0", Offset = "0x8A09B0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000303")]
	private IControllerTemplateHat Rewired_002EISixDofControllerTemplate_002Ehat1
	{
		[Address(RVA = "0x8A24B0", Offset = "0x8A0CB0", Length = "0x3D")]
		[Token(Token = "0x6000FB9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000304")]
	private IControllerTemplateHat Rewired_002EISixDofControllerTemplate_002Ehat2
	{
		[Address(RVA = "0x8A24F0", Offset = "0x8A0CF0", Length = "0x3D")]
		[Token(Token = "0x6000FBA")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000305")]
	private IControllerTemplateThrottle Rewired_002EISixDofControllerTemplate_002Ethrottle1
	{
		[Token(Token = "0x6000FBB")]
		[Address(RVA = "0x8A2570", Offset = "0x8A0D70", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000306")]
	private IControllerTemplateThrottle Rewired_002EISixDofControllerTemplate_002Ethrottle2
	{
		[Token(Token = "0x6000FBC")]
		[Address(RVA = "0x8A25B0", Offset = "0x8A0DB0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000307")]
	private IControllerTemplateStick6D Rewired_002EISixDofControllerTemplate_002Estick
	{
		[Token(Token = "0x6000FBD")]
		[Address(RVA = "0x8A2530", Offset = "0x8A0D30", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000FBE")]
	[Address(RVA = "0x89C3F0", Offset = "0x89ABF0", Length = "0x8")]
	public SixDofControllerTemplate(object payload)
		: base(null)
	{
	}
}
