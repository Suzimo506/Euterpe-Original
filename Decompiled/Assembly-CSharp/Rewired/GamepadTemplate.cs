using System;
using Cpp2ILInjected;

namespace Rewired;

[Token(Token = "0x20001E7")]
public sealed class GamepadTemplate : ControllerTemplate, IGamepadTemplate, IControllerTemplate
{
	[Token(Token = "0x4000BDB")]
	public static readonly Guid typeGuid;

	[Token(Token = "0x4000BDC")]
	public const int elementId_leftStickX = 0;

	[Token(Token = "0x4000BDD")]
	public const int elementId_leftStickY = 1;

	[Token(Token = "0x4000BDE")]
	public const int elementId_rightStickX = 2;

	[Token(Token = "0x4000BDF")]
	public const int elementId_rightStickY = 3;

	[Token(Token = "0x4000BE0")]
	public const int elementId_actionBottomRow1 = 4;

	[Token(Token = "0x4000BE1")]
	public const int elementId_a = 4;

	[Token(Token = "0x4000BE2")]
	public const int elementId_actionBottomRow2 = 5;

	[Token(Token = "0x4000BE3")]
	public const int elementId_b = 5;

	[Token(Token = "0x4000BE4")]
	public const int elementId_actionBottomRow3 = 6;

	[Token(Token = "0x4000BE5")]
	public const int elementId_c = 6;

	[Token(Token = "0x4000BE6")]
	public const int elementId_actionTopRow1 = 7;

	[Token(Token = "0x4000BE7")]
	public const int elementId_x = 7;

	[Token(Token = "0x4000BE8")]
	public const int elementId_actionTopRow2 = 8;

	[Token(Token = "0x4000BE9")]
	public const int elementId_y = 8;

	[Token(Token = "0x4000BEA")]
	public const int elementId_actionTopRow3 = 9;

	[Token(Token = "0x4000BEB")]
	public const int elementId_z = 9;

	[Token(Token = "0x4000BEC")]
	public const int elementId_leftShoulder1 = 10;

	[Token(Token = "0x4000BED")]
	public const int elementId_leftBumper = 10;

	[Token(Token = "0x4000BEE")]
	public const int elementId_leftShoulder2 = 11;

	[Token(Token = "0x4000BEF")]
	public const int elementId_leftTrigger = 11;

	[Token(Token = "0x4000BF0")]
	public const int elementId_rightShoulder1 = 12;

	[Token(Token = "0x4000BF1")]
	public const int elementId_rightBumper = 12;

	[Token(Token = "0x4000BF2")]
	public const int elementId_rightShoulder2 = 13;

	[Token(Token = "0x4000BF3")]
	public const int elementId_rightTrigger = 13;

	[Token(Token = "0x4000BF4")]
	public const int elementId_center1 = 14;

	[Token(Token = "0x4000BF5")]
	public const int elementId_back = 14;

	[Token(Token = "0x4000BF6")]
	public const int elementId_center2 = 15;

	[Token(Token = "0x4000BF7")]
	public const int elementId_start = 15;

	[Token(Token = "0x4000BF8")]
	public const int elementId_center3 = 16;

	[Token(Token = "0x4000BF9")]
	public const int elementId_guide = 16;

	[Token(Token = "0x4000BFA")]
	public const int elementId_leftStickButton = 17;

	[Token(Token = "0x4000BFB")]
	public const int elementId_rightStickButton = 18;

	[Token(Token = "0x4000BFC")]
	public const int elementId_dPadUp = 19;

	[Token(Token = "0x4000BFD")]
	public const int elementId_dPadRight = 20;

	[Token(Token = "0x4000BFE")]
	public const int elementId_dPadDown = 21;

	[Token(Token = "0x4000BFF")]
	public const int elementId_dPadLeft = 22;

	[Token(Token = "0x4000C00")]
	public const int elementId_leftStick = 23;

	[Token(Token = "0x4000C01")]
	public const int elementId_rightStick = 24;

	[Token(Token = "0x4000C02")]
	public const int elementId_dPad = 25;

	[Token(Token = "0x1700020C")]
	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002EactionBottomRow1
	{
		[Address(RVA = "0xF976F0", Offset = "0xF95EF0", Length = "0x3D")]
		[Token(Token = "0x6000EB8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700020D")]
	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002Ea
	{
		[Token(Token = "0x6000EB9")]
		[Address(RVA = "0xF976B0", Offset = "0xF95EB0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700020E")]
	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002EactionBottomRow2
	{
		[Address(RVA = "0xF97730", Offset = "0xF95F30", Length = "0x3D")]
		[Token(Token = "0x6000EBA")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700020F")]
	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002Eb
	{
		[Address(RVA = "0xF97870", Offset = "0xF96070", Length = "0x3D")]
		[Token(Token = "0x6000EBB")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000210")]
	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002EactionBottomRow3
	{
		[Address(RVA = "0xF97770", Offset = "0xF95F70", Length = "0x3D")]
		[Token(Token = "0x6000EBC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000211")]
	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002Ec
	{
		[Token(Token = "0x6000EBD")]
		[Address(RVA = "0xF978F0", Offset = "0xF960F0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000212")]
	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002EactionTopRow1
	{
		[Address(RVA = "0xF977B0", Offset = "0xF95FB0", Length = "0x3D")]
		[Token(Token = "0x6000EBE")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000213")]
	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002Ex
	{
		[Address(RVA = "0xF97D30", Offset = "0xF96530", Length = "0x3D")]
		[Token(Token = "0x6000EBF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000214")]
	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002EactionTopRow2
	{
		[Token(Token = "0x6000EC0")]
		[Address(RVA = "0xF977F0", Offset = "0xF95FF0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000215")]
	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002Ey
	{
		[Address(RVA = "0xF97D70", Offset = "0xF96570", Length = "0x3D")]
		[Token(Token = "0x6000EC1")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000216")]
	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002EactionTopRow3
	{
		[Token(Token = "0x6000EC2")]
		[Address(RVA = "0xF97830", Offset = "0xF96030", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000217")]
	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002Ez
	{
		[Address(RVA = "0xF97DB0", Offset = "0xF965B0", Length = "0x3D")]
		[Token(Token = "0x6000EC3")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000218")]
	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002EleftShoulder1
	{
		[Address(RVA = "0xF97AB0", Offset = "0xF962B0", Length = "0x3D")]
		[Token(Token = "0x6000EC4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000219")]
	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002EleftBumper
	{
		[Address(RVA = "0xF97A70", Offset = "0xF96270", Length = "0x3D")]
		[Token(Token = "0x6000EC5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700021A")]
	private IControllerTemplateAxis Rewired_002EIGamepadTemplate_002EleftShoulder2
	{
		[Token(Token = "0x6000EC6")]
		[Address(RVA = "0xF97AF0", Offset = "0xF962F0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700021B")]
	private IControllerTemplateAxis Rewired_002EIGamepadTemplate_002EleftTrigger
	{
		[Token(Token = "0x6000EC7")]
		[Address(RVA = "0xF97B70", Offset = "0xF96370", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700021C")]
	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002ErightShoulder1
	{
		[Address(RVA = "0xF97BF0", Offset = "0xF963F0", Length = "0x3D")]
		[Token(Token = "0x6000EC8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700021D")]
	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002ErightBumper
	{
		[Address(RVA = "0xF97BB0", Offset = "0xF963B0", Length = "0x3D")]
		[Token(Token = "0x6000EC9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700021E")]
	private IControllerTemplateAxis Rewired_002EIGamepadTemplate_002ErightShoulder2
	{
		[Address(RVA = "0xF97C30", Offset = "0xF96430", Length = "0x3D")]
		[Token(Token = "0x6000ECA")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700021F")]
	private IControllerTemplateAxis Rewired_002EIGamepadTemplate_002ErightTrigger
	{
		[Address(RVA = "0xF97CB0", Offset = "0xF964B0", Length = "0x3D")]
		[Token(Token = "0x6000ECB")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000220")]
	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002Ecenter1
	{
		[Token(Token = "0x6000ECC")]
		[Address(RVA = "0xF97930", Offset = "0xF96130", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000221")]
	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002Eback
	{
		[Token(Token = "0x6000ECD")]
		[Address(RVA = "0xF978B0", Offset = "0xF960B0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000222")]
	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002Ecenter2
	{
		[Address(RVA = "0xF97970", Offset = "0xF96170", Length = "0x3D")]
		[Token(Token = "0x6000ECE")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000223")]
	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002Estart
	{
		[Address(RVA = "0xF97CF0", Offset = "0xF964F0", Length = "0x3D")]
		[Token(Token = "0x6000ECF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000224")]
	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002Ecenter3
	{
		[Address(RVA = "0xF979B0", Offset = "0xF961B0", Length = "0x3D")]
		[Token(Token = "0x6000ED0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000225")]
	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002Eguide
	{
		[Address(RVA = "0xF97A30", Offset = "0xF96230", Length = "0x3D")]
		[Token(Token = "0x6000ED1")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000226")]
	private IControllerTemplateThumbStick Rewired_002EIGamepadTemplate_002EleftStick
	{
		[Address(RVA = "0xF97B30", Offset = "0xF96330", Length = "0x3D")]
		[Token(Token = "0x6000ED2")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000227")]
	private IControllerTemplateThumbStick Rewired_002EIGamepadTemplate_002ErightStick
	{
		[Token(Token = "0x6000ED3")]
		[Address(RVA = "0xF97C70", Offset = "0xF96470", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000228")]
	private IControllerTemplateDPad Rewired_002EIGamepadTemplate_002EdPad
	{
		[Token(Token = "0x6000ED4")]
		[Address(RVA = "0xF979F0", Offset = "0xF961F0", Length = "0x3D")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x89C3F0", Offset = "0x89ABF0", Length = "0x8")]
	[Token(Token = "0x6000ED5")]
	public GamepadTemplate(object payload)
		: base(null)
	{
	}
}
