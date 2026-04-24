using Assets.Scripts.PeroTools.Nice.Components;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Panels.PnlInputs.PCInputModules;

[Token(Token = "0x20001C9")]
public class PnlInputJoystick : MonoBehaviour
{
	[Token(Token = "0x4000B34")]
	[FieldOffset(Offset = "0x18")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView screenFancyScrollView;

	[Token(Token = "0x4000B35")]
	[FieldOffset(Offset = "0x20")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView joystickFeverFancyScrollView;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B36")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView reverseFancyScrollView;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B37")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView vibrationFancyScrollView;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000B38")]
	public Transform joystickFeverTipsBtn;

	[Token(Token = "0x4000B39")]
	[FieldOffset(Offset = "0x40")]
	public PointsBar screenPointsBar;

	[Token(Token = "0x4000B3A")]
	[FieldOffset(Offset = "0x48")]
	public Button btnHandleUI;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000B3B")]
	public int screenProposalIndex;

	[Token(Token = "0x4000B3C")]
	[FieldOffset(Offset = "0x54")]
	private bool m_IsReverse;

	[FieldOffset(Offset = "0x55")]
	[Token(Token = "0x4000B3D")]
	private bool m_IsVibration;

	[FieldOffset(Offset = "0x56")]
	[Token(Token = "0x4000B3E")]
	private bool m_IsManualFever;

	[Token(Token = "0x4000B3F")]
	[FieldOffset(Offset = "0x57")]
	private bool m_IsInitReverse;

	[Token(Token = "0x4000B40")]
	[FieldOffset(Offset = "0x58")]
	private bool m_IsInitVibration;

	[Token(Token = "0x4000B41")]
	[FieldOffset(Offset = "0x59")]
	private bool m_IsInitManualFever;

	[FieldOffset(Offset = "0x5A")]
	[Token(Token = "0x4000B42")]
	private bool m_IsInitHandlerSetting;

	[Token(Token = "0x4000B43")]
	[FieldOffset(Offset = "0x60")]
	private PnlInputPc m_ParentPnl;

	[Token(Token = "0x6000CCE")]
	[Address(RVA = "0x50CF50", Offset = "0x50B750", Length = "0xDA")]
	public void Init()
	{
	}

	[Token(Token = "0x6000CCF")]
	[Address(RVA = "0x50D2E0", Offset = "0x50BAE0", Length = "0x46")]
	public void Release()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6000CD0")]
	public void Loop()
	{
	}

	[Address(RVA = "0x50CD30", Offset = "0x50B530", Length = "0x21E")]
	[Token(Token = "0x6000CD1")]
	private void Awake()
	{
	}

	[Address(RVA = "0x50D030", Offset = "0x50B830", Length = "0x42")]
	[Token(Token = "0x6000CD2")]
	private void OnJoystickFeverFsvSelect(int index)
	{
	}

	[Address(RVA = "0x50D1E0", Offset = "0x50B9E0", Length = "0xF4")]
	[Token(Token = "0x6000CD3")]
	private void OnVibrationFsvSelect(int index)
	{
	}

	[Address(RVA = "0x50D080", Offset = "0x50B880", Length = "0x156")]
	[Token(Token = "0x6000CD4")]
	private void OnReverseFsvSelect(int selectIndex)
	{
	}

	[Address(RVA = "0x50D330", Offset = "0x50BB30", Length = "0x1B6")]
	[Token(Token = "0x6000CD5")]
	public void SetScreenProposal(int index = 0)
	{
	}

	[Address(RVA = "0x50D2E0", Offset = "0x50BAE0", Length = "0x46")]
	[Token(Token = "0x6000CD6")]
	private void SaveHandleSettings()
	{
	}

	[Token(Token = "0x6000CD7")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PnlInputJoystick()
	{
	}
}
