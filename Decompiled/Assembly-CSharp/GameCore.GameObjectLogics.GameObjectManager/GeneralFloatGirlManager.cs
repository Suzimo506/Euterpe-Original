using Assets.Scripts.GameCore.Managers;
using Cpp2ILInjected;
using FormulaBase;

namespace GameCore.GameObjectLogics.GameObjectManager;

[Token(Token = "0x2000474")]
public class GeneralFloatGirlManager : AbstractGirlManager
{
	[Address(RVA = "0x8428B0", Offset = "0x8410B0", Length = "0xB3")]
	[Token(Token = "0x6003342")]
	public override void AwakeInit()
	{
	}

	[Address(RVA = "0x8432E0", Offset = "0x841AE0", Length = "0xB3")]
	[Token(Token = "0x6003343")]
	public override void Release()
	{
	}

	[Token(Token = "0x6003344")]
	[Address(RVA = "0x842B70", Offset = "0x841370", Length = "0xDB")]
	private void OnJumpStateChange(bool jumpState)
	{
	}

	[Token(Token = "0x6003345")]
	[Address(RVA = "0x842970", Offset = "0x841170", Length = "0x1F7")]
	public override void Hurt()
	{
	}

	[Token(Token = "0x6003346")]
	[Address(RVA = "0x842EF0", Offset = "0x8416F0", Length = "0x3E5")]
	public override void PlayRandomHitNothingAnim()
	{
	}

	[Token(Token = "0x6003347")]
	[Address(RVA = "0x841BC0", Offset = "0x8403C0", Length = "0xCC8")]
	public override void AutoPlay(TimeNodeOrder tno, ref decimal ts, ref bool oneHint)
	{
	}

	[Address(RVA = "0x842C50", Offset = "0x841450", Length = "0x9C")]
	[Token(Token = "0x6003348")]
	public override void PlayLongEndAnimator(bool isAir)
	{
	}

	[Token(Token = "0x6003349")]
	[Address(RVA = "0x842CF0", Offset = "0x8414F0", Length = "0x1FF")]
	public override void PlayLongPressAnimator(bool isPress, bool isAir)
	{
	}

	[Address(RVA = "0x6DEFD0", Offset = "0x6DD7D0", Length = "0x7")]
	[Token(Token = "0x600334A")]
	public GeneralFloatGirlManager()
	{
	}
}
