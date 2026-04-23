using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Values;

[Token(Token = "0x20005DA")]
public class Gradient : IValue
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40021A1")]
	[SerializeField]
	private UnityEngine.Gradient m_Result;

	[Token(Token = "0x1700055B")]
	public object result
	{
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		[Token(Token = "0x60039EC")]
		get
		{
			return null;
		}
		[Address(RVA = "0x97C580", Offset = "0x97AD80", Length = "0x90")]
		[Token(Token = "0x60039ED")]
		set
		{
		}
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60039EE")]
	public Gradient()
	{
	}
}
