using Assets.Scripts.GameCore.Managers;
using Cpp2ILInjected;

namespace GameCore.GameObjectLogics.GameObjectManager;

[Token(Token = "0x2000472")]
public class DancerGirlManager : GeneralGirlManager
{
	[Token(Token = "0x600333D")]
	[Address(RVA = "0x83D2C0", Offset = "0x83BAC0", Length = "0x58")]
	public override void OnBgmPlayAndBattleStart()
	{
	}

	[Address(RVA = "0x6DEFD0", Offset = "0x6DD7D0", Length = "0x7")]
	[Token(Token = "0x600333E")]
	public DancerGirlManager()
	{
	}
}
