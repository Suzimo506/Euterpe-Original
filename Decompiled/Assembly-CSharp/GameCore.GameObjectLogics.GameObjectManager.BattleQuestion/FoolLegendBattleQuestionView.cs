using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.GameCore.Interface;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GameCore.GameObjectLogics.GameObjectManager.BattleQuestion;

[Token(Token = "0x2000482")]
public class FoolLegendBattleQuestionView : BaseBattleQuestionView, IPause
{
	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001852")]
	private float m_QuestionShowDelay;

	[SerializeField]
	[Token(Token = "0x4001853")]
	[FieldOffset(Offset = "0x20")]
	private Canvas m_ViewCanvas;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001854")]
	[SerializeField]
	private Animator m_AnimaQuestionShow;

	[SerializeField]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001855")]
	private Animator m_AnimaAnswerShow;

	[SerializeField]
	[Token(Token = "0x4001856")]
	[FieldOffset(Offset = "0x38")]
	private CanvasGroup m_QuestionView;

	[SerializeField]
	[Token(Token = "0x4001857")]
	[FieldOffset(Offset = "0x40")]
	private TextMeshProUGUI m_TxtQuestion;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001858")]
	[SerializeField]
	private Image[] m_ImgsQuestionNumber;

	[Token(Token = "0x4001859")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private TextMeshProUGUI m_TxtAnswerAir;

	[SerializeField]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400185A")]
	private TextMeshProUGUI m_TxtAnswerGround;

	[SerializeField]
	[Token(Token = "0x400185B")]
	[FieldOffset(Offset = "0x60")]
	private CanvasGroup m_AnswerArea;

	[SerializeField]
	[Token(Token = "0x400185C")]
	[FieldOffset(Offset = "0x68")]
	private CanvasGroup m_RightState;

	[Token(Token = "0x400185D")]
	[SerializeField]
	[FieldOffset(Offset = "0x70")]
	private CanvasGroup m_WrongState;

	[SerializeField]
	[Token(Token = "0x400185E")]
	[FieldOffset(Offset = "0x78")]
	private TextMeshProUGUI m_TxtAnswerAirSelect;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400185F")]
	[SerializeField]
	private TextMeshProUGUI m_TxtAnswerGroundSelect;

	[Token(Token = "0x4001860")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private CanvasGroup m_AreaAnswerAir;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001861")]
	[SerializeField]
	private CanvasGroup m_AreaAnswerGround;

	[Token(Token = "0x170004B0")]
	public bool IsGlobal
	{
		[CompilerGenerated]
		[Token(Token = "0x60033A5")]
		[Address(RVA = "0x432400", Offset = "0x430C00", Length = "0x8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600339E")]
	[Address(RVA = "0x83FBD0", Offset = "0x83E3D0", Length = "0x15B")]
	public override void RefreshUI()
	{
	}

	[Token(Token = "0x600339F")]
	[Address(RVA = "0x83FF00", Offset = "0x83E700", Length = "0x4B")]
	public override void SetVisible(bool isShow)
	{
	}

	[Token(Token = "0x60033A0")]
	[Address(RVA = "0x83FD80", Offset = "0x83E580", Length = "0x177")]
	public override void SetAnswerState(bool isRight, bool charaIsAir)
	{
	}

	[Address(RVA = "0x83FF50", Offset = "0x83E750", Length = "0x84")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x43460", Offset = "0x42860")]
	[Token(Token = "0x60033A1")]
	private IEnumerator<float> ShowQuestion(BattleQuestionState questionData)
	{
		return null;
	}

	[Token(Token = "0x60033A2")]
	[Address(RVA = "0x83FFE0", Offset = "0x83E7E0", Length = "0xE9")]
	private void Start()
	{
	}

	[Address(RVA = "0x83FB90", Offset = "0x83E390", Length = "0x3B")]
	[Token(Token = "0x60033A3")]
	public void Pause(bool pauseCorountine)
	{
	}

	[Address(RVA = "0x83FD30", Offset = "0x83E530", Length = "0x45")]
	[Token(Token = "0x60033A4")]
	public void Resume()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x60033A6")]
	public FoolLegendBattleQuestionView()
	{
	}
}
