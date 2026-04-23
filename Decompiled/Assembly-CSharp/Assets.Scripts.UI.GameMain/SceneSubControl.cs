using System;
using System.Collections.Generic;
using Assets.Scripts.Common.SceneEgg;
using Assets.Scripts.GameCore.Interface;
using Cpp2ILInjected;
using DG.Tweening;
using GameCore.Scene.Controllers;
using Spine.Unity;
using UnityEngine;

namespace Assets.Scripts.UI.GameMain;

[Token(Token = "0x200089C")]
public class SceneSubControl : MonoBehaviour, IRelease, IPause
{
	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002CC5")]
	private int m_SceneIdx;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002CC6")]
	public GameObject scenePoint;

	[Token(Token = "0x4002CC7")]
	[FieldOffset(Offset = "0x28")]
	private GameObject m_PointGameObject;

	[Token(Token = "0x4002CC8")]
	[FieldOffset(Offset = "0x30")]
	private Coroutine m_Coroutine;

	[Token(Token = "0x4002CC9")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x3CE30", Offset = "0x3C230")]
	[FieldOffset(Offset = "0x38")]
	public Animator djmaxMidB;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002CCA")]
	public Animator djmaxNearest;

	[Token(Token = "0x4002CCB")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x3CF50", Offset = "0x3C350")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private List<Transform> m_MikuAnimatorParentTransforms;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4002CCC")]
	private readonly List<Animator> m_MikuBossInAnimator;

	[Token(Token = "0x4002CCD")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x3D090", Offset = "0x3C490")]
	private List<Animator> m_Animators;

	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4002CCE")]
	private List<SkeletonAnimation> m_SkeletonAnimations;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4002CCF")]
	[SerializeField]
	private List<ParticleSystem> m_ParticleSystems;

	[SerializeField]
	[Token(Token = "0x4002CD0")]
	[FieldOffset(Offset = "0x70")]
	private DOTweenAnimation[] m_DoTweenAnimations;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4002CD1")]
	[SerializeField]
	private SceneScrollableControl m_SceneScrollableControl;

	[Token(Token = "0x4002CD2")]
	[FieldOffset(Offset = "0x80")]
	private bool m_IsFreezeFlag;

	[Token(Token = "0x4002CD3")]
	[FieldOffset(Offset = "0x81")]
	private bool m_IsPauseed;

	[Token(Token = "0x4002CD4")]
	[FieldOffset(Offset = "0x82")]
	private bool m_IsPause;

	[SerializeField]
	[Token(Token = "0x4002CD5")]
	[FieldOffset(Offset = "0x88")]
	private SceneEggAbstractController m_SceneSurpriseController;

	[Token(Token = "0x17000879")]
	public int sceneIndex
	{
		[Token(Token = "0x6004DF8")]
		[Address(RVA = "0x44A0E0", Offset = "0x4488E0", Length = "0x4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700087A")]
	public bool freezeFlag
	{
		[Token(Token = "0x6004DF9")]
		[Address(RVA = "0x5B7310", Offset = "0x5B5B10", Length = "0x8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700087B")]
	public bool pauseed
	{
		[Token(Token = "0x6004DFA")]
		[Address(RVA = "0x5B7330", Offset = "0x5B5B30", Length = "0x8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700087C")]
	public bool isPause
	{
		[Token(Token = "0x6004DFB")]
		[Address(RVA = "0x5B7320", Offset = "0x5B5B20", Length = "0x8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700087D")]
	public bool IsGlobal
	{
		[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
		[Token(Token = "0x6004E04")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004DFC")]
	[Address(RVA = "0x5B7070", Offset = "0x5B5870", Length = "0x1F3")]
	private void UpdateAllData()
	{
	}

	[Token(Token = "0x6004DFD")]
	[Address(RVA = "0x5B56B0", Offset = "0x5B3EB0", Length = "0x386")]
	private void AddAllAdditiveComponents()
	{
	}

	[Token(Token = "0x6004DFE")]
	[Address(RVA = "0x5B5BC0", Offset = "0x5B43C0", Length = "0x5E3")]
	public void Init()
	{
	}

	[Token(Token = "0x6004DFF")]
	[Address(RVA = "0x5B6470", Offset = "0x5B4C70", Length = "0xDF")]
	private void PlayDjmax(bool isIn, float time = 0f)
	{
	}

	[Obsolete]
	[Token(Token = "0x6004E00")]
	[Address(RVA = "0x5B6550", Offset = "0x5B4D50", Length = "0x106")]
	private void PlayMiku(bool isIn, float time = 0f)
	{
	}

	[Token(Token = "0x6004E01")]
	[Address(RVA = "0x5B5A40", Offset = "0x5B4240", Length = "0xBE")]
	private void OnBossIn(object sender, object rev, params object[] pars)
	{
	}

	[Address(RVA = "0x5B5B00", Offset = "0x5B4300", Length = "0xBE")]
	[Token(Token = "0x6004E02")]
	private void OnBossOut(object sender, object rev, params object[] pars)
	{
	}

	[Address(RVA = "0x5B6660", Offset = "0x5B4E60", Length = "0x106")]
	[Token(Token = "0x6004E03")]
	public void Release(bool isEditor)
	{
	}

	[Address(RVA = "0x5B6770", Offset = "0x5B4F70", Length = "0x7B")]
	[Token(Token = "0x6004E05")]
	public void ResetScrollProgress()
	{
	}

	[Address(RVA = "0x5B6410", Offset = "0x5B4C10", Length = "0x50")]
	[Token(Token = "0x6004E06")]
	public void Pause(bool pauseCorountine)
	{
	}

	[Token(Token = "0x6004E07")]
	[Address(RVA = "0x5B67F0", Offset = "0x5B4FF0", Length = "0x50")]
	public void Resume()
	{
	}

	[Token(Token = "0x6004E08")]
	[Obsolete]
	[Address(RVA = "0x5B6290", Offset = "0x5B4A90", Length = "0x160")]
	private void MikuSceneBossInControlInit()
	{
	}

	[Obsolete]
	[Token(Token = "0x6004E09")]
	[Address(RVA = "0x5B61B0", Offset = "0x5B49B0", Length = "0xDA")]
	private void MikuGetAllChildAnimator(Transform parent)
	{
	}

	[Token(Token = "0x6004E0A")]
	[Address(RVA = "0x5B6B30", Offset = "0x5B5330", Length = "0x32D")]
	private void SetPause_Private(bool pause)
	{
	}

	[Token(Token = "0x6004E0B")]
	[Address(RVA = "0x5B6EF0", Offset = "0x5B56F0", Length = "0xC6")]
	private void SetSkeletonAnimationPause(bool pause)
	{
	}

	[Address(RVA = "0x5B5560", Offset = "0x5B3D60", Length = "0x6F")]
	[Token(Token = "0x6004E0C")]
	public void AddAdditiveSkeletonAnimation(SkeletonAnimation skeletonAnimation)
	{
	}

	[Token(Token = "0x6004E0D")]
	[Address(RVA = "0x5B6850", Offset = "0x5B5050", Length = "0xC6")]
	private void SetAnimatorPause(bool pause)
	{
	}

	[Token(Token = "0x6004E0E")]
	[Address(RVA = "0x5B55D0", Offset = "0x5B3DD0", Length = "0x6F")]
	public void AddAddtiveAnimator(Animator animator)
	{
	}

	[Token(Token = "0x6004E0F")]
	[Address(RVA = "0x5B5640", Offset = "0x5B3E40", Length = "0x6F")]
	public void AddAddtiveMikuBossAnimator(Animator animator)
	{
	}

	[Token(Token = "0x6004E10")]
	[Address(RVA = "0x5B6E60", Offset = "0x5B5660", Length = "0x82")]
	private void SetSceneScrollableControlPause(bool pause)
	{
	}

	[Token(Token = "0x6004E11")]
	[Address(RVA = "0x5B6A70", Offset = "0x5B5270", Length = "0xB6")]
	private void SetParticleSystemPause(bool pause)
	{
	}

	[Token(Token = "0x6004E12")]
	[Address(RVA = "0x5B54F0", Offset = "0x5B3CF0", Length = "0x6F")]
	public void AddAdditiveParticleSystem(ParticleSystem particleSystem)
	{
	}

	[Token(Token = "0x6004E13")]
	[Address(RVA = "0x5B6920", Offset = "0x5B5120", Length = "0xE0")]
	private void SetDotweenPause(bool pause)
	{
	}

	[Address(RVA = "0x5B6400", Offset = "0x5B4C00", Length = "0xF")]
	[Token(Token = "0x6004E14")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6004E15")]
	[Address(RVA = "0x5B6A10", Offset = "0x5B5210", Length = "0x53")]
	public void SetFreeze(bool freeze)
	{
	}

	[Token(Token = "0x6004E16")]
	[Address(RVA = "0x5B5A40", Offset = "0x5B4240", Length = "0xBE")]
	private void BossInTest()
	{
	}

	[Address(RVA = "0x5B5B00", Offset = "0x5B4300", Length = "0xBE")]
	[Token(Token = "0x6004E17")]
	private void BossOutTest()
	{
	}

	[Address(RVA = "0x5B7270", Offset = "0x5B5A70", Length = "0x96")]
	[Token(Token = "0x6004E18")]
	public SceneSubControl()
	{
	}
}
