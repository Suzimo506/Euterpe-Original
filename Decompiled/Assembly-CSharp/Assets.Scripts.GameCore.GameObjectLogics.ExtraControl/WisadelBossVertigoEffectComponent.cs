using Assets.Scripts.GameCore.GameObjectLogics.GameObjectControl.Impls;
using Cpp2ILInjected;
using GameLogic;
using Spine.Unity;
using UnityEngine;

namespace Assets.Scripts.GameCore.GameObjectLogics.ExtraControl;

[Token(Token = "0x2000771")]
public class WisadelBossVertigoEffectComponent : INoteExObjectController
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002763")]
	public BoneFollower boneFollowerComponent;

	[Token(Token = "0x4002764")]
	[FieldOffset(Offset = "0x18")]
	private readonly GameObject m_ParentEnemyObj;

	[Token(Token = "0x4002765")]
	[FieldOffset(Offset = "0x20")]
	private ParticleSystem m_FxVertigoState;

	[Token(Token = "0x4002766")]
	[FieldOffset(Offset = "0x28")]
	private MusicData m_MusicData;

	[Token(Token = "0x4002767")]
	[FieldOffset(Offset = "0x188")]
	private SkeletonRenderer m_BossSklRenderer;

	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4002768")]
	private string m_EffectAppearBone;

	[Token(Token = "0x60045B3")]
	[Address(RVA = "0x4AD470", Offset = "0x4ABC70", Length = "0x30")]
	public WisadelBossVertigoEffectComponent(GameObject parent)
	{
	}

	[Token(Token = "0x60045B4")]
	[Address(RVA = "0x4ACC80", Offset = "0x4AB480", Length = "0x12B")]
	public void Init()
	{
	}

	[Token(Token = "0x60045B5")]
	[Address(RVA = "0x4AD3A0", Offset = "0x4ABBA0", Length = "0x21")]
	public WisadelBossVertigoEffectComponent SetBone(string targetBoneName)
	{
		return null;
	}

	[Token(Token = "0x60045B6")]
	[Address(RVA = "0x4AC670", Offset = "0x4AAE70", Length = "0x4F")]
	public void CreateEffect()
	{
	}

	[Token(Token = "0x60045B7")]
	[Address(RVA = "0x4ACE50", Offset = "0x4AB650", Length = "0xEB")]
	public void OnAppear()
	{
	}

	[Token(Token = "0x60045B8")]
	[Address(RVA = "0x4ACF40", Offset = "0x4AB740", Length = "0x9D")]
	public void OnDisappear()
	{
	}

	[Token(Token = "0x60045B9")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void OnNoteBeAttacked(int noteHitResult)
	{
	}

	[Token(Token = "0x60045BA")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void OnNoteMissed()
	{
	}

	[Token(Token = "0x60045BB")]
	[Address(RVA = "0x4ACFE0", Offset = "0x4AB7E0", Length = "0x9E")]
	public void OnPause()
	{
	}

	[Token(Token = "0x60045BC")]
	[Address(RVA = "0x4AD080", Offset = "0x4AB880", Length = "0x9E")]
	public void OnResume()
	{
	}

	[Token(Token = "0x60045BD")]
	[Address(RVA = "0x4AD120", Offset = "0x4AB920", Length = "0x187")]
	public void Release()
	{
	}

	[Token(Token = "0x60045BE")]
	[Address(RVA = "0x4AC6C0", Offset = "0x4AAEC0", Length = "0x232")]
	private void CreateObjs()
	{
	}

	[Token(Token = "0x60045BF")]
	[Address(RVA = "0x4ACBA0", Offset = "0x4AB3A0", Length = "0xDA")]
	private void InitBoneFollowerComponent()
	{
	}

	[Address(RVA = "0x4AC900", Offset = "0x4AB100", Length = "0x29D")]
	[Token(Token = "0x60045C0")]
	private void CreateVertigoStateObjs()
	{
	}

	[Token(Token = "0x60045C1")]
	[Address(RVA = "0x4AD2B0", Offset = "0x4ABAB0", Length = "0xE3")]
	private void ResetObjTransform(ref GameObject fxInstance)
	{
	}

	[Address(RVA = "0x4ACF40", Offset = "0x4AB740", Length = "0x9D")]
	[Token(Token = "0x60045C2")]
	private void VertigoEffectOff()
	{
	}

	[Address(RVA = "0x4AD3D0", Offset = "0x4ABBD0", Length = "0x9D")]
	[Token(Token = "0x60045C3")]
	private void VertigoEffectOn()
	{
	}

	[Token(Token = "0x60045C4")]
	[Address(RVA = "0x4ACDB0", Offset = "0x4AB5B0", Length = "0x90")]
	private bool IsEffectAvailable()
	{
		return default(bool);
	}
}
