using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.Demos;

[Token(Token = "0x2000214")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6530", Offset = "0x5930")]
public class CustomControllerDemo : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F19")]
	public int playerId;

	[Token(Token = "0x4000F1A")]
	[FieldOffset(Offset = "0x20")]
	public string controllerTag;

	[Token(Token = "0x4000F1B")]
	[FieldOffset(Offset = "0x28")]
	public bool useUpdateCallbacks;

	[Token(Token = "0x4000F1C")]
	[FieldOffset(Offset = "0x2C")]
	private int buttonCount;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000F1D")]
	private int axisCount;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000F1E")]
	private float[] axisValues;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000F1F")]
	private bool[] buttonValues;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000F20")]
	private TouchJoystickExample[] joysticks;

	[Token(Token = "0x4000F21")]
	[FieldOffset(Offset = "0x50")]
	private TouchButtonExample[] buttons;

	[Token(Token = "0x4000F22")]
	[FieldOffset(Offset = "0x58")]
	private CustomController controller;

	[NonSerialized]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000F23")]
	private bool initialized;

	[Address(RVA = "0xF8F750", Offset = "0xF8DF50", Length = "0x3A")]
	[Token(Token = "0x60013E1")]
	private void Awake()
	{
	}

	[Address(RVA = "0xF8F9D0", Offset = "0xF8E1D0", Length = "0x2DE")]
	[Token(Token = "0x60013E2")]
	private void Initialize()
	{
	}

	[Address(RVA = "0xF906B0", Offset = "0xF8EEB0", Length = "0xB7")]
	[Token(Token = "0x60013E3")]
	private void Update()
	{
	}

	[Token(Token = "0x60013E4")]
	[Address(RVA = "0xF8FCB0", Offset = "0xF8E4B0", Length = "0x2C0")]
	private void OnInputSourceUpdate()
	{
	}

	[Address(RVA = "0xF8F830", Offset = "0xF8E030", Length = "0x10B")]
	[Token(Token = "0x60013E5")]
	private void GetSourceAxisValues()
	{
	}

	[Address(RVA = "0xF8F940", Offset = "0xF8E140", Length = "0x8A")]
	[Token(Token = "0x60013E6")]
	private void GetSourceButtonValues()
	{
	}

	[Token(Token = "0x60013E7")]
	[Address(RVA = "0xF905A0", Offset = "0xF8EDA0", Length = "0x7D")]
	private void SetControllerAxisValues()
	{
	}

	[Address(RVA = "0xF90620", Offset = "0xF8EE20", Length = "0x80")]
	[Token(Token = "0x60013E8")]
	private void SetControllerButtonValues()
	{
	}

	[Token(Token = "0x60013E9")]
	[Address(RVA = "0xF8F790", Offset = "0xF8DF90", Length = "0x41")]
	private float GetAxisValueCallback(int index)
	{
		return default(float);
	}

	[Token(Token = "0x60013EA")]
	[Address(RVA = "0xF8F7E0", Offset = "0xF8DFE0", Length = "0x42")]
	private bool GetButtonValueCallback(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x60013EB")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public CustomControllerDemo()
	{
	}
}
