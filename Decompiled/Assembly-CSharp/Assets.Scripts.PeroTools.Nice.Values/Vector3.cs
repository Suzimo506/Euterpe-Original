using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Values;

[Token(Token = "0x20005D3")]
public class Vector3 : IValue
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x400219A")]
	private UnityEngine.Vector3 m_Result;

	[Token(Token = "0x17000554")]
	public object result
	{
		[Address(RVA = "0x9897E0", Offset = "0x987FE0", Length = "0x4D")]
		[Token(Token = "0x60039D7")]
		get
		{
			return null;
		}
		[Address(RVA = "0x989830", Offset = "0x988030", Length = "0x71")]
		[Token(Token = "0x60039D8")]
		set
		{
		}
	}

	[Token(Token = "0x60039D9")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public Vector3()
	{
	}
}
