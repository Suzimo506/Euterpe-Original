using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Values;

[Token(Token = "0x20005D4")]
public class Vector4 : IValue
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x400219B")]
	private UnityEngine.Vector4 m_Result;

	[Token(Token = "0x17000555")]
	public object result
	{
		[Token(Token = "0x60039DA")]
		[Address(RVA = "0x9898B0", Offset = "0x9880B0", Length = "0x44")]
		get
		{
			return null;
		}
		[Token(Token = "0x60039DB")]
		[Address(RVA = "0x989900", Offset = "0x988100", Length = "0x69")]
		set
		{
		}
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60039DC")]
	public Vector4()
	{
	}
}
