using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Values;

[Token(Token = "0x20005CE")]
public class String : IValue
{
	[SerializeField]
	[Token(Token = "0x4002195")]
	[FieldOffset(Offset = "0x10")]
	private string m_Result;

	[Token(Token = "0x1700054F")]
	public object result
	{
		[Token(Token = "0x60039C8")]
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		get
		{
			return null;
		}
		[Address(RVA = "0x985210", Offset = "0x983A10", Length = "0x66")]
		[Token(Token = "0x60039C9")]
		set
		{
		}
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60039CA")]
	public String()
	{
	}
}
