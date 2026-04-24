using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x200063D")]
public class Wait : Action
{
	[SerializeField]
	[Attribute(Name = "VariableAttribute", RVA = "0x261C0", Offset = "0x255C0")]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002324")]
	private IVariable m_Duration;

	[Token(Token = "0x17000595")]
	public override float duration
	{
		[Address(RVA = "0x752680", Offset = "0x750E80", Length = "0x39")]
		[Token(Token = "0x6003BFA")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6003BFB")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public Wait()
	{
	}
}
