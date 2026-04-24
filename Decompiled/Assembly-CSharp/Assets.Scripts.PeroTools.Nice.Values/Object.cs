using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Values;

[Token(Token = "0x20005DD")]
public class Object : IValue
{
	[SerializeField]
	[Token(Token = "0x40021A4")]
	[FieldOffset(Offset = "0x10")]
	private UnityEngine.Object m_Result;

	[Token(Token = "0x1700055E")]
	public object result
	{
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		[Token(Token = "0x60039F5")]
		get
		{
			return null;
		}
		[Address(RVA = "0x97F260", Offset = "0x97DA60", Length = "0x90")]
		[Token(Token = "0x60039F6")]
		set
		{
		}
	}

	[Token(Token = "0x60039F7")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public Object()
	{
	}
}
