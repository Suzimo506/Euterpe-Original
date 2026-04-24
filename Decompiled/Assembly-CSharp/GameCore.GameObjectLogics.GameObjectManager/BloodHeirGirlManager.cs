using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.GameCore.Interface;
using Assets.Scripts.GameCore.Managers;
using Cpp2ILInjected;
using GameCore.GameObjectLogics.ExtraControl.BloodheirExControl;
using GameLogic;
using MEC;

namespace GameCore.GameObjectLogics.GameObjectManager;

[Token(Token = "0x2000471")]
public class BloodHeirGirlManager : GeneralGirlManager, IPause
{
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4001813")]
	private BloodHeirSpHpCreateController m_BloodHeirSpHpCreateCtrl;

	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4001814")]
	private BloodHeirSkillDataModel m_SkillDataModel;

	[Token(Token = "0x4001815")]
	[FieldOffset(Offset = "0xA8")]
	private BloodHeirSkillEffectController m_SkillEffectCtrl;

	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4001816")]
	private CoroutineHandle m_SkillOnReduceHpHandle;

	[Token(Token = "0x1700049A")]
	public BloodHeirSkillDataModel SkillDataModel
	{
		[Address(RVA = "0x48E690", Offset = "0x48CE90", Length = "0x8")]
		[Token(Token = "0x600332B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700049B")]
	public SpineActionController GirlSpiActCtrl
	{
		[Token(Token = "0x600332C")]
		[Address(RVA = "0x46EF20", Offset = "0x46D720", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700049C")]
	public bool IsGlobal
	{
		[CompilerGenerated]
		[Address(RVA = "0x83A6C0", Offset = "0x838EC0", Length = "0x8")]
		[Token(Token = "0x600333B")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600332D")]
	[Address(RVA = "0x838FB0", Offset = "0x8377B0", Length = "0x2B9")]
	public override void AwakeInit()
	{
	}

	[Address(RVA = "0x839560", Offset = "0x837D60", Length = "0x2F4")]
	[Token(Token = "0x600332E")]
	public override void InstanceGirl()
	{
	}

	[Address(RVA = "0x839860", Offset = "0x838060", Length = "0x337")]
	[Token(Token = "0x600332F")]
	public override void OnBgmPlayAndBattleStart()
	{
	}

	[Token(Token = "0x6003330")]
	[Address(RVA = "0x83A160", Offset = "0x838960", Length = "0x3DF")]
	public override void Release()
	{
	}

	[Token(Token = "0x6003331")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	private void OnSkillNoteMissed(MusicData md)
	{
	}

	[Token(Token = "0x6003332")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	private void OnSkillNoteHit(MusicData md, int hitResult)
	{
	}

	[Token(Token = "0x6003333")]
	[Address(RVA = "0x839E90", Offset = "0x838690", Length = "0x19C")]
	private void OnSkillOn(object sender, object reciever, object[] args)
	{
	}

	[Token(Token = "0x6003334")]
	[Address(RVA = "0x839530", Offset = "0x837D30", Length = "0x20")]
	private void OnShowVictory(object sender, object reciever, object[] args)
	{
	}

	[Token(Token = "0x6003335")]
	[Address(RVA = "0x839BA0", Offset = "0x8383A0", Length = "0x2EA")]
	private void OnSkillEnd(object sender, object reciever, object[] args)
	{
	}

	[Address(RVA = "0x839530", Offset = "0x837D30", Length = "0x20")]
	[Token(Token = "0x6003336")]
	private void GameOnFailed()
	{
	}

	[Address(RVA = "0x83A670", Offset = "0x838E70", Length = "0x4A")]
	[Token(Token = "0x6003337")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x3CE60", Offset = "0x3C260")]
	private IEnumerator<float> SkillHpReducing()
	{
		return null;
	}

	[Token(Token = "0x6003338")]
	[Address(RVA = "0x839270", Offset = "0x837A70", Length = "0x2B5")]
	private void ChangeCharacterShow(string turnShow)
	{
	}

	[Token(Token = "0x6003339")]
	[Address(RVA = "0x83A030", Offset = "0x838830", Length = "0x12F")]
	public void Pause(bool pauseCorountine)
	{
	}

	[Token(Token = "0x600333A")]
	[Address(RVA = "0x83A540", Offset = "0x838D40", Length = "0x12F")]
	public void Resume()
	{
	}

	[Token(Token = "0x600333C")]
	[Address(RVA = "0x6DEFD0", Offset = "0x6DD7D0", Length = "0x7")]
	public BloodHeirGirlManager()
	{
	}
}
