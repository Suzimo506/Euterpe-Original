using Assets.Scripts.Database;
using Assets.Scripts.GameCore.GameObjectLogics.GameObjectControl.Impls;
using Cpp2ILInjected;
using GameLogic;
using Spine.Unity;
using UnityEngine;

namespace GameCore.GameObjectLogics.ExtraControl.DiverExControl;

[Token(Token = "0x2000492")]
public class DaveFishEnemyController : INoteExObjectController
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40018AB")]
	public BoneFollower boneFollowerComponent;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40018AC")]
	private BaseEnemyObjectController m_ParentEnemyObj;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40018AD")]
	private GameObject m_DaveFishEffectInstance;

	[Token(Token = "0x40018AE")]
	[FieldOffset(Offset = "0x28")]
	private MusicData m_MusicData;

	[Token(Token = "0x40018AF")]
	[FieldOffset(Offset = "0x188")]
	private DaveFishData m_DaveFishData;

	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x40018B0")]
	private DiverSkillDataModel m_DataModel;

	[Token(Token = "0x40018B1")]
	[FieldOffset(Offset = "0x198")]
	private Animator m_NoteAlphaCtrl;

	[Token(Token = "0x40018B2")]
	[FieldOffset(Offset = "0x1A0")]
	private int m_GhostNoteSpeed;

	[Token(Token = "0x40018B3")]
	[FieldOffset(Offset = "0x1A8")]
	private AudioClip m_DaveFishAudioClip;

	[Address(RVA = "0x83E1F0", Offset = "0x83C9F0", Length = "0x4F")]
	[Token(Token = "0x6003445")]
	public DaveFishEnemyController(BaseEnemyObjectController parent, DaveFishData diveFishData)
	{
	}

	[Token(Token = "0x6003446")]
	[Address(RVA = "0x83DB00", Offset = "0x83C300", Length = "0x170")]
	public void Init()
	{
	}

	[Token(Token = "0x6003447")]
	[Address(RVA = "0x83DC80", Offset = "0x83C480", Length = "0xA4")]
	public void OnAppear()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6003448")]
	public void OnDisappear()
	{
	}

	[Token(Token = "0x6003449")]
	[Address(RVA = "0x83DD30", Offset = "0x83C530", Length = "0x199")]
	public void OnNoteBeAttacked(int noteHitResult)
	{
	}

	[Token(Token = "0x600344A")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void OnNoteMissed()
	{
	}

	[Token(Token = "0x600344B")]
	[Address(RVA = "0x83DED0", Offset = "0x83C6D0", Length = "0x9C")]
	public void OnPause()
	{
	}

	[Address(RVA = "0x83DF70", Offset = "0x83C770", Length = "0xA1")]
	[Token(Token = "0x600344C")]
	public void OnResume()
	{
	}

	[Token(Token = "0x600344D")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void Release()
	{
	}

	[Token(Token = "0x600344E")]
	[Address(RVA = "0x83D460", Offset = "0x83BC60", Length = "0x289")]
	private void CreateObjs()
	{
	}

	[Token(Token = "0x600344F")]
	[Address(RVA = "0x83D9D0", Offset = "0x83C1D0", Length = "0x127")]
	private void InitBoneFollowerComponent()
	{
	}

	[Address(RVA = "0x83D6F0", Offset = "0x83BEF0", Length = "0x217")]
	[Token(Token = "0x6003450")]
	private void CreateSpecialDaveFishObjs()
	{
	}

	[Address(RVA = "0x83D910", Offset = "0x83C110", Length = "0xB4")]
	[Token(Token = "0x6003451")]
	private void EnableAnimator()
	{
	}

	[Token(Token = "0x6003452")]
	[Address(RVA = "0x83D320", Offset = "0x83BB20", Length = "0x13D")]
	private void CheckGhostNoteMoveSpeed()
	{
	}

	[Address(RVA = "0x83E020", Offset = "0x83C820", Length = "0x150")]
	[Token(Token = "0x6003453")]
	private void ResetObjTransform(ref GameObject fxInstance)
	{
	}
}
