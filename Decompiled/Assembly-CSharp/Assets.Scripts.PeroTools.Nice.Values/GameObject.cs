using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Values;

[Token(Token = "0x20005DE")]
public class GameObject : IValue
{
	[SerializeField]
	[Token(Token = "0x40021A5")]
	[FieldOffset(Offset = "0x10")]
	private UnityEngine.GameObject m_Result;

	[Token(Token = "0x1700055F")]
	public object result
	{
		[Token(Token = "0x60039F8")]
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x60039F9")]
		[Address(RVA = "0x97C510", Offset = "0x97AD10", Length = "0x66")]
		set
		{
		}
	}

	[Token(Token = "0x60039FA")]
	[Address(RVA = "0x9CDF50", Offset = "0x9CC750", Length = "0x49")]
	public object GetComponent<T>()
	{
		return null;
	}

	[Token(Token = "0x60039FB")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public GameObject()
	{
	}
}
