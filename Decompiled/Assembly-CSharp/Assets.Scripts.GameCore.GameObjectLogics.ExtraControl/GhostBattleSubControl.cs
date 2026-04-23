using Cpp2ILInjected;
using GameLogic;

namespace Assets.Scripts.GameCore.GameObjectLogics.ExtraControl;

[Token(Token = "0x200076C")]
public class GhostBattleSubControl : RoleBattleSubControl
{
	[Address(RVA = "0x49D550", Offset = "0x49BD50", Length = "0x178")]
	[Token(Token = "0x60045A1")]
	public override void Init()
	{
	}

	[Token(Token = "0x60045A2")]
	[Address(RVA = "0x49D770", Offset = "0x49BF70", Length = "0xA9")]
	public override void Release(bool isEditor)
	{
	}

	[Token(Token = "0x60045A3")]
	[Address(RVA = "0x49D6D0", Offset = "0x49BED0", Length = "0x93")]
	private void OnGhostAttack(string key, MusicData md)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x60045A4")]
	public GhostBattleSubControl()
	{
	}
}
