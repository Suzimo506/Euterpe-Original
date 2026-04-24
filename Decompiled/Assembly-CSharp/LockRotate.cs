using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000069")]
public class LockRotate : Singleton<LockRotate>
{
	[Token(Token = "0x40002F2")]
	[FieldOffset(Offset = "0x10")]
	private ScreenOrientation m_PlayerRotate;

	[Address(RVA = "0x8BC8C0", Offset = "0x8BB0C0", Length = "0x3F")]
	[Token(Token = "0x600031F")]
	public void BattleStartLockRotate()
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0x8BC900", Offset = "0x8BB100", Length = "0x2E")]
	public void BattleStartUnlockRotate()
	{
	}

	[Address(RVA = "0x8BC930", Offset = "0x8BB130", Length = "0x38")]
	[Token(Token = "0x6000321")]
	public LockRotate()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
