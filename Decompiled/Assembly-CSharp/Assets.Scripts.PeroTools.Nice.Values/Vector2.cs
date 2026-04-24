using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Values;

[Token(Token = "0x20005D2")]
public class Vector2 : IValue
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002199")]
	[SerializeField]
	private UnityEngine.Vector2 m_Result;

	[Token(Token = "0x17000553")]
	public object result
	{
		[Token(Token = "0x60039D4")]
		[Address(RVA = "0x989710", Offset = "0x987F10", Length = "0x46")]
		get
		{
			return null;
		}
		[Token(Token = "0x60039D5")]
		[Address(RVA = "0x989760", Offset = "0x987F60", Length = "0x75")]
		set
		{
		}
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60039D6")]
	public Vector2()
	{
	}
}
