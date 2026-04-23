using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Values;

[Token(Token = "0x20005D9")]
public class Quaternion : IValue
{
	[Token(Token = "0x40021A0")]
	[SerializeField]
	[FieldOffset(Offset = "0x10")]
	private UnityEngine.Quaternion m_Result;

	[Token(Token = "0x1700055A")]
	public object result
	{
		[Token(Token = "0x60039E9")]
		[Address(RVA = "0x981FB0", Offset = "0x9807B0", Length = "0x44")]
		get
		{
			return null;
		}
		[Token(Token = "0x60039EA")]
		[Address(RVA = "0x982000", Offset = "0x980800", Length = "0x69")]
		set
		{
		}
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60039EB")]
	public Quaternion()
	{
	}
}
