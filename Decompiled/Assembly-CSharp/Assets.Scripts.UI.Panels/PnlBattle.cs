using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.GameCore.GameObjectLogics.GameObjectManager;
using Assets.Scripts.GameCore.Interface;
using Assets.Scripts.PeroTools.PreWarm;
using Assets.Scripts.Structs;
using Assets.Scripts.UI.GameMain;
using Cpp2ILInjected;
using DG.Tweening;
using Sirenix.OdinInspector;
using UI.Panels.PnlBattleCompSubControls;
using UnityEngine;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008D1")]
public class PnlBattle : SerializedMonoBehaviour, IPause, IPreWarm
{
	[Token(Token = "0x2000D5A")]
	private enum PnlBattleCompsType
	{
		[Token(Token = "0x4003F75")]
		Others,
		[Token(Token = "0x4003F76")]
		Reimu,
		[Token(Token = "0x4003F77")]
		Wisadel,
		[Token(Token = "0x4003F78")]
		Bloodheir,
		[Token(Token = "0x4003F79")]
		Djmax,
		[Token(Token = "0x4003F7A")]
		Count
	}

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002DFF")]
	private PnlBattleComps currentComps;

	[Token(Token = "0x4002E00")]
	[FieldOffset(Offset = "0x60")]
	public List<PnlBattleComps> pnlBattleComps;

	[Token(Token = "0x4002E01")]
	[FieldOffset(Offset = "0x68")]
	public PnlBattleCombos pnlBattleCombos;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4002E02")]
	public AttackEffectManager attackEffectManager;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4002E03")]
	public CountAnimator mulCountAnimator;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4002E04")]
	private Tweener m_TwnProgress;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4002E05")]
	private Sequence m_SeqGirlIn;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4002E06")]
	private Sequence m_SeqSongPlay;

	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4002E07")]
	private bool m_IsiPhoneX;

	[Token(Token = "0x4002E08")]
	[FieldOffset(Offset = "0x99")]
	private bool m_Interactable;

	[Token(Token = "0x4002E09")]
	private static PnlBattle m_Instance;

	[Token(Token = "0x4002E0A")]
	[FieldOffset(Offset = "0xA0")]
	public RectTransform[] iPhoneXTransforms;

	[Token(Token = "0x4002E0B")]
	[FieldOffset(Offset = "0xA8")]
	public RectTransform[] iPhoneXTransformsInverse;

	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4002E0C")]
	public Dictionary<RectTransform, Vector3> iPhoneXScale;

	[Token(Token = "0x4002E0D")]
	[FieldOffset(Offset = "0xB8")]
	public float offsetValue;

	[Token(Token = "0x4002E0E")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject pnlSkipTutorial;

	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4002E0F")]
	public GameObject pnlPause;

	[Token(Token = "0x4002E10")]
	[FieldOffset(Offset = "0xD0")]
	public DialogMasterControl dialogMasterControl;

	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4002E11")]
	private float gradientTime;

	[FieldOffset(Offset = "0xDC")]
	[Token(Token = "0x4002E12")]
	private Color m_Color;

	[Token(Token = "0x4002E13")]
	[FieldOffset(Offset = "0xF0")]
	private ButtonDisplay m_PauseButton;

	[Token(Token = "0x4002E14")]
	[FieldOffset(Offset = "0x100")]
	private WisadelSkillCounts m_WisadelSkillCounts;

	[Token(Token = "0x4002E15")]
	[FieldOffset(Offset = "0x108")]
	private PnlBloodHeirBattleCompSubControl m_PnlBloodHeirBattleCompSubControl;

	[Token(Token = "0x17000897")]
	public PnlBattleComps CurrentBattleUIComp
	{
		[Token(Token = "0x6004F62")]
		[Address(RVA = "0x429C40", Offset = "0x428440", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000898")]
	public bool isBtnActivity
	{
		[Address(RVA = "0x433F30", Offset = "0x432730", Length = "0x8")]
		[Token(Token = "0x6004F63")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x433F40", Offset = "0x432740", Length = "0x7")]
		[Token(Token = "0x6004F64")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000899")]
	public static PnlBattle instance
	{
		[Token(Token = "0x6004F65")]
		[Address(RVA = "0x433E90", Offset = "0x432690", Length = "0x9E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700089A")]
	public bool IsGlobal
	{
		[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
		[Token(Token = "0x6004F72")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004F66")]
	[Address(RVA = "0x431720", Offset = "0x42FF20", Length = "0xD4")]
	private void Awake()
	{
	}

	[Address(RVA = "0x432110", Offset = "0x430910", Length = "0x2EC")]
	[Token(Token = "0x6004F67")]
	private void IPhoneXOffset()
	{
	}

	[Address(RVA = "0x432F80", Offset = "0x431780", Length = "0x8E6")]
	[Token(Token = "0x6004F68")]
	private void SetPnlBattleUI()
	{
	}

	[Token(Token = "0x6004F69")]
	[Address(RVA = "0x431D80", Offset = "0x430580", Length = "0x381")]
	public void GameUiInit()
	{
	}

	[Token(Token = "0x6004F6A")]
	[Address(RVA = "0x432930", Offset = "0x431130", Length = "0x98")]
	private void OnPauseClicked()
	{
	}

	[Address(RVA = "0x432BE0", Offset = "0x4313E0", Length = "0x98")]
	[Token(Token = "0x6004F6B")]
	private void OnTutorialPauseClicked()
	{
	}

	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x4E650", Offset = "0x4DA50")]
	[Address(RVA = "0x431800", Offset = "0x430000", Length = "0x65")]
	[Token(Token = "0x6004F6C")]
	private IEnumerator BtnClickCool()
	{
		return null;
	}

	[Address(RVA = "0x431870", Offset = "0x430070", Length = "0x160")]
	[Token(Token = "0x6004F6D")]
	public void ChangeBtnPauseStage(bool isActivity = false)
	{
	}

	[Address(RVA = "0x432EF0", Offset = "0x4316F0", Length = "0xC")]
	[Token(Token = "0x6004F6E")]
	public void PreWarm(int slice)
	{
	}

	[Address(RVA = "0x432570", Offset = "0x430D70", Length = "0x1ED")]
	[Token(Token = "0x6004F6F")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x432C80", Offset = "0x431480", Length = "0x88")]
	[Token(Token = "0x6004F70")]
	public void Pause(bool pauseCorountine)
	{
	}

	[Address(RVA = "0x432F00", Offset = "0x431700", Length = "0x77")]
	[Token(Token = "0x6004F71")]
	public void Resume()
	{
	}

	[Token(Token = "0x6004F73")]
	[Address(RVA = "0x432410", Offset = "0x430C10", Length = "0x156")]
	public void MusicProgressInit()
	{
	}

	[Token(Token = "0x6004F74")]
	[Address(RVA = "0x4319E0", Offset = "0x4301E0", Length = "0x395")]
	public void GameStart()
	{
	}

	[Token(Token = "0x6004F75")]
	[Address(RVA = "0x433C30", Offset = "0x432430", Length = "0x1DA")]
	public void UIPause(bool isPause)
	{
	}

	[Token(Token = "0x6004F76")]
	[Address(RVA = "0x432400", Offset = "0x430C00", Length = "0x8")]
	public bool IsIPhoneX()
	{
		return default(bool);
	}

	[Token(Token = "0x6004F77")]
	[Address(RVA = "0x432D10", Offset = "0x431510", Length = "0x1D1")]
	private void PnlBattleUIInit()
	{
	}

	[Token(Token = "0x6004F78")]
	[Address(RVA = "0x432760", Offset = "0x430F60", Length = "0xCF")]
	private void OnFail()
	{
	}

	[Address(RVA = "0x4329E0", Offset = "0x4311E0", Length = "0x1FF")]
	[Token(Token = "0x6004F79")]
	private void OnStageStart(object sender, object reciever, params object[] args)
	{
	}

	[Token(Token = "0x6004F7A")]
	[Address(RVA = "0x432830", Offset = "0x431030", Length = "0xF6")]
	private void OnNekoSkillTrigger(object sender, object reciever, params object[] args)
	{
	}

	[Address(RVA = "0x4329D0", Offset = "0x4311D0", Length = "0x8")]
	[Token(Token = "0x6004F7B")]
	private void OnShowVictory(object sender, object rev, params object[] args)
	{
	}

	[Token(Token = "0x6004F7C")]
	[Address(RVA = "0x433E10", Offset = "0x432610", Length = "0x73")]
	public PnlBattle()
	{
	}
}
