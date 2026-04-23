using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x200060E")]
public class Activate : Action
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002233")]
	[Attribute(Name = "VariableAttribute", RVA = "0xC770", Offset = "0xBB70")]
	[SerializeField]
	private IVariable m_Object;

	[Address(RVA = "0x73A0A0", Offset = "0x7388A0", Length = "0x147")]
	[Token(Token = "0x6003B37")]
	public override void Execute()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003B38")]
	public Activate()
	{
	}
}
