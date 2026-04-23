using System.Runtime.CompilerServices;
using Assets.Scripts.GameCore.Interface;
using Assets.Scripts.PeroTools.Managers;
using Cpp2ILInjected;
using GameCore.GameObjectLogics.GameObjectManager;
using Spine.Unity;
using UnityEngine;

namespace GameCore.GameObjectLogics.ExtraControl.BloodheirExControl;

[Token(Token = "0x2000493")]
public class BloodHeirSkillEffectController : IUpdate
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40018B4")]
	private ParticleSystem m_SkillOnParticles;

	[Token(Token = "0x40018B5")]
	[FieldOffset(Offset = "0x18")]
	private ParticleSystem m_StandbyPs;

	[Token(Token = "0x40018B6")]
	[FieldOffset(Offset = "0x20")]
	private ParticleSystem.MinMaxCurve m_InitStartSize;

	[Token(Token = "0x40018B7")]
	[FieldOffset(Offset = "0x40")]
	private BloodHeirSkillDataModel m_SkillDataModel;

	[Token(Token = "0x40018B8")]
	[FieldOffset(Offset = "0x48")]
	private BloodHeirGirlManager m_GirlMgr;

	[Token(Token = "0x40018B9")]
	[FieldOffset(Offset = "0x50")]
	private BloodheirShadowControl m_BloodheirShadow;

	[Token(Token = "0x40018BA")]
	[FieldOffset(Offset = "0x58")]
	private SkeletonAnimation m_SkillSpShadow;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40018BB")]
	private Renderer m_SkillSpShadowRenderer;

	[Token(Token = "0x170004BB")]
	public UnityGameManager.LoopType LoopType
	{
		[CompilerGenerated]
		[Address(RVA = "0x6EF3E0", Offset = "0x6EDBE0", Length = "0x4")]
		[Token(Token = "0x600345D")]
		get
		{
			return default(UnityGameManager.LoopType);
		}
	}

	[Token(Token = "0x6003455")]
	[Address(RVA = "0x83AAD0", Offset = "0x8392D0", Length = "0x156")]
	public void Init()
	{
	}

	[Address(RVA = "0x83AEB0", Offset = "0x8396B0", Length = "0x19C")]
	[Token(Token = "0x6003456")]
	public void PlayEffect()
	{
	}

	[Address(RVA = "0x83B110", Offset = "0x839910", Length = "0x196")]
	[Token(Token = "0x6003457")]
	public void StopEffect()
	{
	}

	[Address(RVA = "0x83AC30", Offset = "0x839430", Length = "0xCA")]
	[Token(Token = "0x6003458")]
	public void OnPause()
	{
	}

	[Token(Token = "0x6003459")]
	[Address(RVA = "0x83AD00", Offset = "0x839500", Length = "0xCA")]
	public void OnResume()
	{
	}

	[Address(RVA = "0x83B050", Offset = "0x839850", Length = "0xB4")]
	[Token(Token = "0x600345A")]
	public void Release()
	{
	}

	[Token(Token = "0x600345B")]
	[Address(RVA = "0x83A6D0", Offset = "0x838ED0", Length = "0x213")]
	private void CreateSkillSpShadow()
	{
	}

	[Address(RVA = "0x83A8F0", Offset = "0x8390F0", Length = "0x1D8")]
	[Token(Token = "0x600345C")]
	private void CreateSkillVfx()
	{
	}

	[Address(RVA = "0x83ADD0", Offset = "0x8395D0", Length = "0xD2")]
	[Token(Token = "0x600345E")]
	public void OnUpdate()
	{
	}

	[Token(Token = "0x600345F")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public BloodHeirSkillEffectController()
	{
	}
}
