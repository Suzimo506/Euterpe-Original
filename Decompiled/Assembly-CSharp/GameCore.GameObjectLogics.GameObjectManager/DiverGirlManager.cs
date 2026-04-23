using System.Collections;
using Assets.Scripts.GameCore.Managers;
using Cpp2ILInjected;

namespace GameCore.GameObjectLogics.GameObjectManager;

[Token(Token = "0x2000473")]
public class DiverGirlManager : GeneralGirlManager
{
	[Token(Token = "0x600333F")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x3D8F0", Offset = "0x3CCF0")]
	[Address(RVA = "0x83E240", Offset = "0x83CA40", Length = "0x65")]
	protected override IEnumerator AfterComeOut()
	{
		return null;
	}

	[Token(Token = "0x6003340")]
	[Address(RVA = "0x83E2B0", Offset = "0x83CAB0", Length = "0x94")]
	public override void Dead()
	{
	}

	[Token(Token = "0x6003341")]
	[Address(RVA = "0x6DEFD0", Offset = "0x6DD7D0", Length = "0x7")]
	public DiverGirlManager()
	{
	}
}
