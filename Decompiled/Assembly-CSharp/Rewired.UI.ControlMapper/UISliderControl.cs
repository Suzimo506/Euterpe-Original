using System;
using Cpp2ILInjected;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper;

[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6530", Offset = "0x5930")]
[Token(Token = "0x200020F")]
public class UISliderControl : UIControl
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000EEC")]
	public Image iconImage;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000EED")]
	public Slider slider;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000EEE")]
	private bool _showIcon;

	[Token(Token = "0x4000EEF")]
	[FieldOffset(Offset = "0x39")]
	private bool _showSlider;

	[Token(Token = "0x170003FD")]
	public bool showIcon
	{
		[Address(RVA = "0x654CA0", Offset = "0x6534A0", Length = "0x5")]
		[Token(Token = "0x6001366")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0xDCE170", Offset = "0xDCC970", Length = "0xA0")]
		[Token(Token = "0x6001367")]
		set
		{
		}
	}

	[Token(Token = "0x170003FE")]
	public bool showSlider
	{
		[Address(RVA = "0x899A40", Offset = "0x898240", Length = "0x5")]
		[Token(Token = "0x6001368")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0xDCE220", Offset = "0xDCCA20", Length = "0xA0")]
		[Token(Token = "0x6001369")]
		set
		{
		}
	}

	[Address(RVA = "0xDCDE40", Offset = "0xDCC640", Length = "0x32F")]
	[Token(Token = "0x600136A")]
	public override void SetCancelCallback(Action cancelCallback)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x600136B")]
	public UISliderControl()
	{
	}
}
