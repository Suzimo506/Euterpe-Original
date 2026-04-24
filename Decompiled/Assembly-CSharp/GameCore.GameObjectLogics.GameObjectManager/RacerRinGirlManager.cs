using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.GameCore.GameObjectLogics.ExtraControl;
using Assets.Scripts.GameCore.Managers;
using Assets.Scripts.UI.Effects;
using Cpp2ILInjected;
using Spine;
using Spine.Unity;
using UnityEngine;

namespace GameCore.GameObjectLogics.GameObjectManager;

[Token(Token = "0x2000477")]
public class RacerRinGirlManager : GeneralGirlManager
{
	[Token(Token = "0x4001820")]
	private const string character_skin_normal = "Normal";

	[Token(Token = "0x4001821")]
	private const string character_skin_mad = "Mad";

	[Token(Token = "0x4001822")]
	private const string character_hurt_voice_prefix = "berserk";

	[Token(Token = "0x4001823")]
	private const string character_flame_fx_parent_bone_name = "head_particle";

	[Token(Token = "0x4001824")]
	private const float camera_shake_impact_force = 6f;

	[Token(Token = "0x4001825")]
	private const string game_start_and_boom_sfx_asset = "char_racer_in_boom";

	[Token(Token = "0x4001826")]
	[FieldOffset(Offset = "0x98")]
	private SkeletonAnimation m_MainSkAnimation;

	[Token(Token = "0x4001827")]
	[FieldOffset(Offset = "0xA0")]
	private SkeletonAnimation m_GhostSkAnimation;

	[Token(Token = "0x4001828")]
	[FieldOffset(Offset = "0xA8")]
	private List<string> m_NormalHurtVoices;

	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4001829")]
	private List<string> m_MadHurtVoices;

	[Token(Token = "0x400182A")]
	[FieldOffset(Offset = "0xB8")]
	private GameObject m_FlameVfxObj;

	[Token(Token = "0x400182B")]
	[FieldOffset(Offset = "0xC0")]
	private Bone m_GirlSpineFxBone;

	[Token(Token = "0x400182C")]
	[FieldOffset(Offset = "0xC8")]
	private GameInstanceEffectController m_CharaEffectCtrl;

	[Token(Token = "0x400182D")]
	[FieldOffset(Offset = "0xD0")]
	private bool m_PlayHurtVoiceInMad;

	[Token(Token = "0x400182E")]
	[FieldOffset(Offset = "0xD4")]
	private float m_PlayHurtVoiceInMadDuration;

	[Address(RVA = "0x90B300", Offset = "0x909B00", Length = "0x284")]
	[Token(Token = "0x6003352")]
	public override void AwakeInit()
	{
	}

	[Token(Token = "0x6003353")]
	[Address(RVA = "0x90BDF0", Offset = "0x90A5F0", Length = "0x404")]
	public override void InstanceGirl()
	{
	}

	[Token(Token = "0x6003354")]
	[Address(RVA = "0x90C5B0", Offset = "0x90ADB0", Length = "0x183")]
	public override void Release()
	{
	}

	[Token(Token = "0x6003355")]
	[Address(RVA = "0x90BA60", Offset = "0x90A260", Length = "0x94")]
	public override void Dead()
	{
	}

	[Token(Token = "0x6003356")]
	[Address(RVA = "0x90B590", Offset = "0x909D90", Length = "0x14F")]
	public override void BeAttackEffect()
	{
	}

	[Token(Token = "0x6003357")]
	[Address(RVA = "0x90BC00", Offset = "0x90A400", Length = "0x1EE")]
	protected override void HurtOnlyAudio()
	{
	}

	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x3F2C0", Offset = "0x3E6C0")]
	[Token(Token = "0x6003358")]
	[Address(RVA = "0x90B290", Offset = "0x909A90", Length = "0x65")]
	protected override IEnumerator AfterComeOut()
	{
		return null;
	}

	[Token(Token = "0x6003359")]
	[Address(RVA = "0x90BB00", Offset = "0x90A300", Length = "0xF6")]
	private void FrameEventHandler(TrackEntry trackEntry, Spine.Event evt)
	{
	}

	[Token(Token = "0x600335A")]
	[Address(RVA = "0x90B960", Offset = "0x90A160", Length = "0xF6")]
	private void ChangeSkinWhenComeIn(float timeStep)
	{
	}

	[Address(RVA = "0x90C200", Offset = "0x90AA00", Length = "0x11B")]
	[Token(Token = "0x600335B")]
	private void OnHpRateChange(object sender, object reciever, object[] args)
	{
	}

	[Token(Token = "0x600335C")]
	[Address(RVA = "0x90C320", Offset = "0x90AB20", Length = "0x28A")]
	private void PlayRacerHurtEffect()
	{
	}

	[Token(Token = "0x600335D")]
	[Address(RVA = "0x90B6E0", Offset = "0x909EE0", Length = "0x27B")]
	private void ChangeInitialSkin(RoleType compType, string characterSkin)
	{
	}

	[Token(Token = "0x600335E")]
	[Address(RVA = "0x90CB50", Offset = "0x90B350", Length = "0x11")]
	public RacerRinGirlManager()
	{
	}
}
