using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Values;

[Token(Token = "0x20005E4")]
public class Ref : IValue
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40021AB")]
	[SerializeField]
	private object m_Result;

	[Token(Token = "0x17000565")]
	public object result
	{
		[Token(Token = "0x6003A0B")]
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003A0C")]
		[Address(RVA = "0x4894E0", Offset = "0x487CE0", Length = "0xC")]
		set
		{
		}
	}

	[Token(Token = "0x6003A0D")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public Ref()
	{
	}
}
