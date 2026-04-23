using System;
using Assets.Scripts.GameCore.GameObjectLogics.GameObjectControl.Impls;
using Cpp2ILInjected;
using GameLogic;
using Spine.Unity;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000033")]
public class WisadelGameEnemyVertigoEffectController : INoteExObjectController
{
	[Token(Token = "0x4000150")]
	[FieldOffset(Offset = "0x10")]
	public BoneFollower boneFollowerComponent;

	[Token(Token = "0x4000151")]
	[FieldOffset(Offset = "0x18")]
	private BaseEnemyObjectController m_ParentEnemyObj;

	[Token(Token = "0x4000152")]
	[FieldOffset(Offset = "0x20")]
	private ParticleSystem m_FxVertigoState;

	[Token(Token = "0x4000153")]
	[FieldOffset(Offset = "0x28")]
	private MusicData m_MusicData;

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x4AD470", Offset = "0x4ABC70", Length = "0x30")]
	public WisadelGameEnemyVertigoEffectController(BaseEnemyObjectController parent)
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0xD32FD0", Offset = "0xD317D0", Length = "0x204")]
	public void Init()
	{
	}

	[Address(RVA = "0xD33260", Offset = "0xD31A60", Length = "0xD1")]
	[Token(Token = "0x6000120")]
	public void OnAppear()
	{
	}

	[Address(RVA = "0xD33340", Offset = "0xD31B40", Length = "0x56")]
	[Token(Token = "0x6000121")]
	public void OnDisappear()
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void OnNoteMissed()
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void OnPause()
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void OnResume()
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xD33440", Offset = "0xD31C40", Length = "0x148")]
	public void Release()
	{
	}

	[Address(RVA = "0xD333A0", Offset = "0xD31BA0", Length = "0x9D")]
	[Token(Token = "0x6000126")]
	public void OnNoteBeAttacked(int noteHitResult)
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xD32A20", Offset = "0xD31220", Length = "0x271")]
	private void CreateObjs()
	{
	}

	[Address(RVA = "0xD32EA0", Offset = "0xD316A0", Length = "0x127")]
	[Token(Token = "0x6000128")]
	private void InitBoneFollowerComponent()
	{
	}

	[Address(RVA = "0xD32CA0", Offset = "0xD314A0", Length = "0x1F2")]
	[Token(Token = "0x6000129")]
	private void CreateVertigoStateObjs()
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0xD33590", Offset = "0xD31D90", Length = "0x20F")]
	private void ResetObjTransform(ref GameObject fxInstance)
	{
	}

	[Address(RVA = "0xD33340", Offset = "0xD31B40", Length = "0x56")]
	[Token(Token = "0x600012B")]
	private void VertigoEffectOff()
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0xD337A0", Offset = "0xD31FA0", Length = "0x56")]
	private void VertigoEffectOn()
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0xD331E0", Offset = "0xD319E0", Length = "0x75")]
	private bool IsEffectAvailable()
	{
		return default(bool);
	}
}
