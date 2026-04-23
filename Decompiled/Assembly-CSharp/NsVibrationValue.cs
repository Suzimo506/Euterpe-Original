using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000089")]
public class NsVibrationValue
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400038B")]
	public List<AmplitudePoint> lowAmplitude;

	[Token(Token = "0x400038C")]
	[FieldOffset(Offset = "0x18")]
	public List<AmplitudePoint> highAmplitude;

	[Token(Token = "0x400038D")]
	[FieldOffset(Offset = "0x20")]
	public float totalTime;

	[Address(RVA = "0x86DD70", Offset = "0x86C570", Length = "0xFA")]
	[Token(Token = "0x60003FC")]
	public NsVibrationValue(AmplitudePoint low, AmplitudePoint high, float time)
	{
	}

	[Address(RVA = "0x86DE70", Offset = "0x86C670", Length = "0x5F")]
	[Token(Token = "0x60003FD")]
	public NsVibrationValue(List<AmplitudePoint> low, List<AmplitudePoint> high, float time)
	{
	}

	[Address(RVA = "0x86DED0", Offset = "0x86C6D0", Length = "0x56")]
	[Token(Token = "0x60003FE")]
	public bool isEmpty()
	{
		return default(bool);
	}

	[Token(Token = "0x60003FF")]
	[Address(RVA = "0x86DBC0", Offset = "0x86C3C0", Length = "0x1A5")]
	public override string ToString()
	{
		return null;
	}
}
