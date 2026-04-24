using System;
using Cpp2ILInjected;
using UnityEngine.UI;

[Token(Token = "0x200008A")]
public class AmplitudePoint
{
	[Token(Token = "0x400038E")]
	[FieldOffset(Offset = "0x10")]
	public float time;

	[Token(Token = "0x400038F")]
	[FieldOffset(Offset = "0x14")]
	public float vaule;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000390")]
	public Slider slider;

	[Address(RVA = "0x5955A0", Offset = "0x593DA0", Length = "0x3A")]
	[Token(Token = "0x6000400")]
	public AmplitudePoint(float t, float v)
	{
	}

	[Address(RVA = "0x5953F0", Offset = "0x593BF0", Length = "0x117")]
	[Token(Token = "0x6000401")]
	public void OnSelect(Action onSelect)
	{
	}

	[Address(RVA = "0x595510", Offset = "0x593D10", Length = "0x83")]
	[Token(Token = "0x6000402")]
	public override string ToString()
	{
		return null;
	}
}
