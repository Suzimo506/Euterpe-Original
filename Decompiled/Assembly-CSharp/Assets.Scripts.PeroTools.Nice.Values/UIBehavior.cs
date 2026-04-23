using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts.PeroTools.Nice.Values;

[Token(Token = "0x20005E3")]
public class UIBehavior : IValue
{
	[SerializeField]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40021AA")]
	private UIBehaviour m_Result;

	[Token(Token = "0x17000564")]
	public object result
	{
		[Token(Token = "0x6003A08")]
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003A09")]
		[Address(RVA = "0x988020", Offset = "0x986820", Length = "0x90")]
		set
		{
		}
	}

	[Token(Token = "0x6003A0A")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public UIBehavior()
	{
	}
}
