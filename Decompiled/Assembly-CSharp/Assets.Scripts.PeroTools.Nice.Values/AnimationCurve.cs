using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Values;

[Token(Token = "0x20005DB")]
public class AnimationCurve : IValue
{
	[Token(Token = "0x40021A2")]
	[SerializeField]
	[FieldOffset(Offset = "0x10")]
	private UnityEngine.AnimationCurve m_Result;

	[Token(Token = "0x1700055C")]
	public object result
	{
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		[Token(Token = "0x60039EF")]
		get
		{
			return null;
		}
		[Address(RVA = "0x973620", Offset = "0x971E20", Length = "0x90")]
		[Token(Token = "0x60039F0")]
		set
		{
		}
	}

	[Address(RVA = "0x9735B0", Offset = "0x971DB0", Length = "0x64")]
	[Token(Token = "0x60039F1")]
	public AnimationCurve()
	{
	}
}
