using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Values;

[Token(Token = "0x20005DF")]
public class Transform : IValue
{
	[SerializeField]
	[Token(Token = "0x40021A6")]
	[FieldOffset(Offset = "0x10")]
	private UnityEngine.Transform m_Result;

	[Token(Token = "0x17000560")]
	public object result
	{
		[Token(Token = "0x60039FC")]
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		get
		{
			return null;
		}
		[Address(RVA = "0x985C20", Offset = "0x984420", Length = "0x90")]
		[Token(Token = "0x60039FD")]
		set
		{
		}
	}

	[Token(Token = "0x60039FE")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public Transform()
	{
	}
}
