using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using FormulaBase;
using GameCore.GameObjectLogics.GameObjectControl.MutiGirlController;
using UnityEngine;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x2000732")]
public class RinLenDoubleManager : AbstractGirlManager
{
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40025D6")]
	public List<MultiGirlData> multGirlListDats;

	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40025D7")]
	public MultiGirlStateController stateCtrl;

	[Token(Token = "0x17000643")]
	public List<int> missedDoubleNotes
	{
		[Address(RVA = "0x46D010", Offset = "0x46B810", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60042E5")]
		get
		{
			return null;
		}
		[Address(RVA = "0x49A8F0", Offset = "0x4990F0", Length = "0xF")]
		[CompilerGenerated]
		[Token(Token = "0x60042E6")]
		set
		{
		}
	}

	[Token(Token = "0x60042E7")]
	[Address(RVA = "0x6DD8D0", Offset = "0x6DC0D0", Length = "0x9C")]
	public override void AwakeInit()
	{
	}

	[Token(Token = "0x60042E8")]
	[Address(RVA = "0x6DECD0", Offset = "0x6DD4D0", Length = "0x68")]
	public override void Release()
	{
	}

	[Token(Token = "0x60042E9")]
	[Address(RVA = "0x6DDF40", Offset = "0x6DC740", Length = "0x3CE")]
	public override void InstanceGirl()
	{
	}

	[Token(Token = "0x60042EA")]
	[Address(RVA = "0x6DE680", Offset = "0x6DCE80", Length = "0x5F4")]
	public override void PlayRandomHitNothingAnim()
	{
	}

	[Token(Token = "0x60042EB")]
	[Address(RVA = "0x6DCB30", Offset = "0x6DB330", Length = "0x340")]
	public override void AutoPlay(TimeNodeOrder tno, ref decimal ts, ref bool oneHint)
	{
	}

	[Address(RVA = "0x6DE310", Offset = "0x6DCB10", Length = "0x1EE")]
	[Token(Token = "0x60042EC")]
	public void MissNoteReach(uint result, float dt, int id = -1)
	{
	}

	[Token(Token = "0x60042ED")]
	[Address(RVA = "0x6DDA40", Offset = "0x6DC240", Length = "0x11F")]
	public override void ComeOut()
	{
	}

	[Token(Token = "0x60042EE")]
	[Address(RVA = "0x6DC7A0", Offset = "0x6DAFA0", Length = "0x386")]
	public override void AttacksWithoutExchange(uint result, string actKey = null, int id = -1)
	{
	}

	[Token(Token = "0x60042EF")]
	[Address(RVA = "0x6DED40", Offset = "0x6DD540", Length = "0x1C8")]
	private void SwitchMainSubActor()
	{
	}

	[Token(Token = "0x60042F0")]
	[Address(RVA = "0x6DDED0", Offset = "0x6DC6D0", Length = "0x62")]
	public override void Hurt()
	{
	}

	[Token(Token = "0x60042F1")]
	[Address(RVA = "0x6DC750", Offset = "0x6DAF50", Length = "0x49")]
	private void AfterHurt()
	{
	}

	[Token(Token = "0x60042F2")]
	[Address(RVA = "0x6DD970", Offset = "0x6DC170", Length = "0xC4")]
	public override void BeAttackEffect()
	{
	}

	[Token(Token = "0x60042F3")]
	[Address(RVA = "0x6DDE70", Offset = "0x6DC670", Length = "0x59")]
	public override void Dead()
	{
	}

	[Address(RVA = "0x6DE500", Offset = "0x6DCD00", Length = "0x57")]
	[Token(Token = "0x60042F4")]
	public override void PlayLongEndAnimator(bool isAir)
	{
	}

	[Token(Token = "0x60042F5")]
	[Address(RVA = "0x6DE560", Offset = "0x6DCD60", Length = "0x11A")]
	public override void PlayLongPressAnimator(bool isPress, bool isAir)
	{
	}

	[Token(Token = "0x60042F6")]
	[Address(RVA = "0x6DEC80", Offset = "0x6DD480", Length = "0x49")]
	public void PlayRoleInvicinbleState()
	{
	}

	[Token(Token = "0x60042F7")]
	[Address(RVA = "0x6DDB60", Offset = "0x6DC360", Length = "0x30C")]
	private MultiGirlData CreateMultiSpineInstance(GameObject girlObj)
	{
		return null;
	}

	[Token(Token = "0x60042F8")]
	[Address(RVA = "0x6DEFD0", Offset = "0x6DD7D0", Length = "0x7")]
	public RinLenDoubleManager()
	{
	}
}
