using Assets.Scripts.GameCore.GameObjectLogics.GameObjectControl.Impls;
using Cpp2ILInjected;
using GameLogic;
using Spine.Unity;
using UnityEngine;

namespace GameCore.GameObjectLogics.ExtraControl.BloodheirExControl;

[Token(Token = "0x2000494")]
public class BloodHeirSpEnemyController : INoteExObjectController
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40018BD")]
	public BoneFollower boneFollowerComponent;

	[Token(Token = "0x40018BE")]
	[FieldOffset(Offset = "0x18")]
	private BaseEnemyObjectController m_ParentEnemyObj;

	[Token(Token = "0x40018BF")]
	[FieldOffset(Offset = "0x20")]
	private GameObject m_BloodEffectInstance;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40018C0")]
	private MusicData m_MusicData;

	[Token(Token = "0x40018C1")]
	[FieldOffset(Offset = "0x188")]
	private BloodHeirSkillDataModel m_DataModel;

	[Token(Token = "0x40018C2")]
	[FieldOffset(Offset = "0x190")]
	private Animator m_NoteAlphaCtrl;

	[Token(Token = "0x40018C3")]
	[FieldOffset(Offset = "0x198")]
	private int m_GhostNoteSpeed;

	[Address(RVA = "0x4AD470", Offset = "0x4ABC70", Length = "0x30")]
	[Token(Token = "0x6003461")]
	public BloodHeirSpEnemyController(BaseEnemyObjectController parent)
	{
	}

	[Address(RVA = "0x83B950", Offset = "0x83A150", Length = "0x267")]
	[Token(Token = "0x6003462")]
	public void Init()
	{
	}

	[Token(Token = "0x6003463")]
	[Address(RVA = "0x83BD90", Offset = "0x83A590", Length = "0x362")]
	public void OnNoteBeAttacked(int hitResult)
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6003464")]
	public void OnNoteMissed()
	{
	}

	[Address(RVA = "0x83BBC0", Offset = "0x83A3C0", Length = "0x19B")]
	[Token(Token = "0x6003465")]
	public void OnAppear()
	{
	}

	[Address(RVA = "0x83BD60", Offset = "0x83A560", Length = "0x2F")]
	[Token(Token = "0x6003466")]
	public void OnDisappear()
	{
	}

	[Address(RVA = "0x83C100", Offset = "0x83A900", Length = "0x9C")]
	[Token(Token = "0x6003467")]
	public void OnPause()
	{
	}

	[Address(RVA = "0x83C1A0", Offset = "0x83A9A0", Length = "0xA1")]
	[Token(Token = "0x6003468")]
	public void OnResume()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6003469")]
	public void Release()
	{
	}

	[Address(RVA = "0x83C250", Offset = "0x83AA50", Length = "0x66D")]
	[Token(Token = "0x600346A")]
	private void OnSpecialBloodRecovery()
	{
	}

	[Address(RVA = "0x83B420", Offset = "0x839C20", Length = "0x16B")]
	[Token(Token = "0x600346B")]
	private void CreateObjs()
	{
	}

	[Address(RVA = "0x83B740", Offset = "0x839F40", Length = "0x20A")]
	[Token(Token = "0x600346C")]
	private void InitBoneFollowerComponent()
	{
	}

	[Token(Token = "0x600346D")]
	[Address(RVA = "0x83B590", Offset = "0x839D90", Length = "0xEE")]
	private void CreateVampireSpecialBloodObjs()
	{
	}

	[Address(RVA = "0x83B680", Offset = "0x839E80", Length = "0xB4")]
	[Token(Token = "0x600346E")]
	private void EnableAnimator()
	{
	}

	[Address(RVA = "0x83B2E0", Offset = "0x839AE0", Length = "0x13D")]
	[Token(Token = "0x600346F")]
	private void CheckGhostNoteMoveSpeed()
	{
	}

	[Token(Token = "0x6003470")]
	[Address(RVA = "0x83C8C0", Offset = "0x83B0C0", Length = "0x1BE")]
	private void ResetObjTransform(ref GameObject fxInstance)
	{
	}
}
