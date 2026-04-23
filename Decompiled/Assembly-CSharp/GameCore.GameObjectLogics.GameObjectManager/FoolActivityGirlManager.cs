using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.GameCore.Managers;
using Cpp2ILInjected;
using GameCore.GameObjectLogics.GameObjectControl;
using GameCore.GameObjectLogics.GameObjectManager._2024FoolActivity;
using GameLogic;

namespace GameCore.GameObjectLogics.GameObjectManager;

[Token(Token = "0x200046F")]
public class FoolActivityGirlManager : GeneralGirlManager
{
	[Token(Token = "0x4001809")]
	public const string note_show_audio_name = "fool_note_show_strong";

	[Token(Token = "0x400180A")]
	private const int role_action_animation_track_idx = 0;

	[Token(Token = "0x400180B")]
	private const int role_face_animation_track_idx = 1;

	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400180C")]
	public List<SubSpineController> subGirlSubSpineControllers;

	[Token(Token = "0x400180D")]
	[FieldOffset(Offset = "0xA0")]
	private FoolAcitivityRoleAssetConfig m_ActConfig;

	[Token(Token = "0x6003314")]
	[Address(RVA = "0x83E3C0", Offset = "0x83CBC0", Length = "0x5E")]
	public override void AwakeInit()
	{
	}

	[Token(Token = "0x6003315")]
	[Address(RVA = "0x83E6B0", Offset = "0x83CEB0", Length = "0x4E2")]
	public override void InstanceGirl()
	{
	}

	[Address(RVA = "0x83E350", Offset = "0x83CB50", Length = "0x65")]
	[Token(Token = "0x6003316")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x3C6D0", Offset = "0x3BAD0")]
	protected override IEnumerator AfterComeOut()
	{
		return null;
	}

	[Token(Token = "0x6003317")]
	[Address(RVA = "0x83EBA0", Offset = "0x83D3A0", Length = "0x341")]
	public override void PlayRandomHitNothingAnim()
	{
	}

	[Address(RVA = "0x83EFB0", Offset = "0x83D7B0", Length = "0x2E3")]
	[Token(Token = "0x6003318")]
	public void ShowAttackActionAccordingToNote(MusicData md, uint result)
	{
	}

	[Token(Token = "0x6003319")]
	[Address(RVA = "0x83F470", Offset = "0x83DC70", Length = "0x1BC")]
	public void ShowFaceAction(bool showDefault = false)
	{
	}

	[Address(RVA = "0x83E420", Offset = "0x83CC20", Length = "0x21F")]
	[Token(Token = "0x600331A")]
	public override void BeMissed()
	{
	}

	[Token(Token = "0x600331B")]
	[Address(RVA = "0x83E640", Offset = "0x83CE40", Length = "0x6B")]
	private void ClearAnimationTrack(int trackIdx)
	{
	}

	[Address(RVA = "0x83F2A0", Offset = "0x83DAA0", Length = "0x1C6")]
	[Token(Token = "0x600331C")]
	private void ShowAttackAction(string baseActionName, uint noteResult)
	{
	}

	[Address(RVA = "0x83EEF0", Offset = "0x83D6F0", Length = "0xB3")]
	[Token(Token = "0x600331D")]
	private void ResetToDefaultAction()
	{
	}

	[Address(RVA = "0x6DEFD0", Offset = "0x6DD7D0", Length = "0x7")]
	[Token(Token = "0x600331E")]
	public FoolActivityGirlManager()
	{
	}
}
