using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Values;

[Token(Token = "0x20005E1")]
public class Texture2D : IValue
{
	[Token(Token = "0x40021A8")]
	[SerializeField]
	[FieldOffset(Offset = "0x10")]
	private UnityEngine.Texture2D m_Result;

	[Token(Token = "0x17000562")]
	public object result
	{
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		[Token(Token = "0x6003A02")]
		get
		{
			return null;
		}
		[Address(RVA = "0x985A70", Offset = "0x984270", Length = "0x66")]
		[Token(Token = "0x6003A03")]
		set
		{
		}
	}

	[Token(Token = "0x6003A04")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public Texture2D()
	{
	}
}
