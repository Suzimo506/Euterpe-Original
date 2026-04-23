using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Demos.GamepadTemplateUI;

[Attribute(Name = "RequireComponent", RVA = "0x156A0", Offset = "0x14AA0")]
[Token(Token = "0x2000227")]
public class ControllerUIEffect : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000F97")]
	private Color _highlightColor;

	[Token(Token = "0x4000F98")]
	[FieldOffset(Offset = "0x28")]
	private Image _image;

	[Token(Token = "0x4000F99")]
	[FieldOffset(Offset = "0x30")]
	private Color _color;

	[Token(Token = "0x4000F9A")]
	[FieldOffset(Offset = "0x40")]
	private Color _origColor;

	[Token(Token = "0x4000F9B")]
	[FieldOffset(Offset = "0x50")]
	private bool _isActive;

	[Token(Token = "0x4000F9C")]
	[FieldOffset(Offset = "0x54")]
	private float _highlightAmount;

	[Token(Token = "0x6001485")]
	[Address(RVA = "0xF8EA80", Offset = "0xF8D280", Length = "0x83")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001486")]
	[Address(RVA = "0xF8E990", Offset = "0xF8D190", Length = "0xEC")]
	public void Activate(float amount)
	{
	}

	[Address(RVA = "0xF8EB10", Offset = "0xF8D310", Length = "0x6A")]
	[Token(Token = "0x6001487")]
	public void Deactivate()
	{
	}

	[Token(Token = "0x6001488")]
	[Address(RVA = "0xF8EB80", Offset = "0xF8D380", Length = "0x4F")]
	private void RedrawImage()
	{
	}

	[Token(Token = "0x6001489")]
	[Address(RVA = "0xF8EBD0", Offset = "0xF8D3D0", Length = "0x2B")]
	public ControllerUIEffect()
	{
	}
}
