using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Commons;

[Token(Token = "0x20006A0")]
public class GradientUtils
{
	[Address(RVA = "0x92CB30", Offset = "0x92B330", Length = "0xFF")]
	[Token(Token = "0x6003E6D")]
	public static float GetUnusedColorTime(Gradient gradient)
	{
		return default(float);
	}

	[Token(Token = "0x6003E6E")]
	[Address(RVA = "0x92CA30", Offset = "0x92B230", Length = "0xFF")]
	public static float GetUnusedAlphaTime(Gradient gradient)
	{
		return default(float);
	}

	[Token(Token = "0x6003E6F")]
	[Address(RVA = "0x92BF90", Offset = "0x92A790", Length = "0xA96")]
	public static Gradient BlendGradient(Gradient l, Gradient r, float percent)
	{
		return null;
	}

	[Token(Token = "0x6003E70")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public GradientUtils()
	{
	}
}
