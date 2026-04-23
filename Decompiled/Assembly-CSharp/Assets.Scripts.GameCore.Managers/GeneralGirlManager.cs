using Cpp2ILInjected;
using FormulaBase;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x2000730")]
public class GeneralGirlManager : AbstractGirlManager
{
	[Token(Token = "0x40025CF")]
	[FieldOffset(Offset = "0x90")]
	private StaticSynhroObject m_StaticSynComponent;

	[Address(RVA = "0x791850", Offset = "0x790050", Length = "0xCA")]
	[Token(Token = "0x60042DA")]
	public override void InstanceGirl()
	{
	}

	[Token(Token = "0x60042DB")]
	[Address(RVA = "0x792130", Offset = "0x790930", Length = "0x94")]
	public override void Release()
	{
	}

	[Token(Token = "0x60042DC")]
	[Address(RVA = "0x791A10", Offset = "0x790210", Length = "0x71E")]
	public override void PlayRandomHitNothingAnim()
	{
	}

	[Token(Token = "0x60042DD")]
	[Address(RVA = "0x7900D0", Offset = "0x78E8D0", Length = "0xD20")]
	public override void AutoPlay(TimeNodeOrder tno, ref decimal ts, ref bool oneHint)
	{
	}

	[Token(Token = "0x60042DE")]
	[Address(RVA = "0x790E10", Offset = "0x78F610", Length = "0x60E")]
	public override void Dead()
	{
	}

	[Token(Token = "0x60042DF")]
	[Address(RVA = "0x791920", Offset = "0x790120", Length = "0xE8")]
	public override void PlayLongEndAnimator(bool isAir)
	{
	}

	[Token(Token = "0x60042E0")]
	[Address(RVA = "0x791420", Offset = "0x78FC20", Length = "0x424")]
	public override void Hurt()
	{
	}

	[Token(Token = "0x60042E1")]
	[Address(RVA = "0x786270", Offset = "0x784A70", Length = "0x70")]
	public GeneralGirlManager()
	{
	}
}
