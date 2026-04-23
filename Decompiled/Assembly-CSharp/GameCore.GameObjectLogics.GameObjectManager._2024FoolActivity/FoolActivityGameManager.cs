using System.Collections.Generic;
using Assets.Scripts.UI.GameMain;
using Cpp2ILInjected;
using FormulaBase;
using GameLogic;
using UnityEngine;

namespace GameCore.GameObjectLogics.GameObjectManager._2024FoolActivity;

[Token(Token = "0x2000487")]
public class FoolActivityGameManager
{
	[Token(Token = "0x4001882")]
	private static readonly List<string> s_FoolActSpecialNoteBmsId;

	[Token(Token = "0x4001883")]
	[FieldOffset(Offset = "0x10")]
	private SceneSubControl m_SceneSubControl;

	[Token(Token = "0x4001884")]
	[FieldOffset(Offset = "0x18")]
	private string m_CurSceneName;

	[Token(Token = "0x60033D3")]
	[Address(RVA = "0x8F5960", Offset = "0x8F4160", Length = "0x176")]
	public static List<string> GetResultSpineShowAssets()
	{
		return null;
	}

	[Address(RVA = "0x8F57F0", Offset = "0x8F3FF0", Length = "0x163")]
	[Token(Token = "0x60033D4")]
	public void GamePlayOnlyTouchGroundNote(TimeNodeOrder tno, ref bool isRoadActivation, ref bool isAirActivation)
	{
	}

	[Address(RVA = "0x8F5AE0", Offset = "0x8F42E0", Length = "0x145")]
	[Token(Token = "0x60033D5")]
	public void PlayNoteShowAudio(MusicData md)
	{
	}

	[Token(Token = "0x60033D6")]
	[Address(RVA = "0x8F5770", Offset = "0x8F3F70", Length = "0x7D")]
	public bool CheckShowFoolActResultPanel(float accuracy)
	{
		return default(bool);
	}

	[Address(RVA = "0x8F5D00", Offset = "0x8F4500", Length = "0x213")]
	[Token(Token = "0x60033D7")]
	public void ResetHitEffectPosition(Transform fxTransform)
	{
	}

	[Address(RVA = "0x8F5C70", Offset = "0x8F4470", Length = "0x8A")]
	[Token(Token = "0x60033D8")]
	public void ResetEffectRootPosition(Transform effectParentTransform)
	{
	}

	[Address(RVA = "0x8F5C30", Offset = "0x8F4430", Length = "0x33")]
	[Token(Token = "0x60033D9")]
	public void ReleaseReferences()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60033DA")]
	public FoolActivityGameManager()
	{
	}
}
