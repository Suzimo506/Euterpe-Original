using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Demos.GamepadTemplateUI;

[Attribute(Name = "RequireComponent", RVA = "0x15960", Offset = "0x14D60")]
[Token(Token = "0x2000228")]
public class ControllerUIElement : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4000F9D")]
	[FieldOffset(Offset = "0x18")]
	private Color _highlightColor;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000F9E")]
	[SerializeField]
	private ControllerUIEffect _positiveUIEffect;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000F9F")]
	[SerializeField]
	private ControllerUIEffect _negativeUIEffect;

	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000FA0")]
	private Text _label;

	[Token(Token = "0x4000FA1")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Text _positiveLabel;

	[SerializeField]
	[Token(Token = "0x4000FA2")]
	[FieldOffset(Offset = "0x48")]
	private Text _negativeLabel;

	[SerializeField]
	[Token(Token = "0x4000FA3")]
	[FieldOffset(Offset = "0x50")]
	private ControllerUIElement[] _childElements;

	[Token(Token = "0x4000FA4")]
	[FieldOffset(Offset = "0x58")]
	private Image _image;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000FA5")]
	private Color _color;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000FA6")]
	private Color _origColor;

	[Token(Token = "0x4000FA7")]
	[FieldOffset(Offset = "0x80")]
	private bool _isActive;

	[Token(Token = "0x4000FA8")]
	[FieldOffset(Offset = "0x84")]
	private float _highlightAmount;

	[Token(Token = "0x17000415")]
	private bool hasEffects
	{
		[Address(RVA = "0xF8F6A0", Offset = "0xF8DEA0", Length = "0xA1")]
		[Token(Token = "0x600148A")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600148B")]
	[Address(RVA = "0xF8EF80", Offset = "0xF8D780", Length = "0x8C")]
	private void Awake()
	{
	}

	[Address(RVA = "0xF8EC00", Offset = "0xF8D400", Length = "0x37A")]
	[Token(Token = "0x600148C")]
	public void Activate(float amount)
	{
	}

	[Address(RVA = "0xF8F250", Offset = "0xF8DA50", Length = "0x1E9")]
	[Token(Token = "0x600148D")]
	public void Deactivate()
	{
	}

	[Address(RVA = "0xF8F480", Offset = "0xF8DC80", Length = "0x1A1")]
	[Token(Token = "0x600148E")]
	public void SetLabel(string text, AxisRange labelType)
	{
	}

	[Address(RVA = "0xF8F010", Offset = "0xF8D810", Length = "0x230")]
	[Token(Token = "0x600148F")]
	public void ClearLabels()
	{
	}

	[Address(RVA = "0xF8F440", Offset = "0xF8DC40", Length = "0x38")]
	[Token(Token = "0x6001490")]
	private void RedrawImage()
	{
	}

	[Address(RVA = "0xF8F630", Offset = "0xF8DE30", Length = "0x63")]
	[Token(Token = "0x6001491")]
	public ControllerUIElement()
	{
	}
}
