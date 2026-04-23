using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Values;

[Token(Token = "0x20005D5")]
public class Rect : IValue
{
	[SerializeField]
	[Token(Token = "0x400219C")]
	[FieldOffset(Offset = "0x10")]
	private UnityEngine.Rect m_Result;

	[Token(Token = "0x17000556")]
	public object result
	{
		[Token(Token = "0x60039DD")]
		[Address(RVA = "0x982170", Offset = "0x980970", Length = "0x44")]
		get
		{
			return null;
		}
		[Address(RVA = "0x9821C0", Offset = "0x9809C0", Length = "0x69")]
		[Token(Token = "0x60039DE")]
		set
		{
		}
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60039DF")]
	public Rect()
	{
	}
}
