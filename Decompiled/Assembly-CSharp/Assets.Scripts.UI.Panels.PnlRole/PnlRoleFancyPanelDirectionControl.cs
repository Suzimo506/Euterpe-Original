using Assets.Scripts.PeroTools.Nice.Components;
using Assets.Scripts.PeroTools.UI;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlRole;

[Token(Token = "0x2000960")]
public class PnlRoleFancyPanelDirectionControl : PnlRoleSelectedItem
{
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400334D")]
	[SerializeField]
	private RectTransform m_ImgSelectTransform;

	[Token(Token = "0x400334E")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private RectTransform m_BtnNextTransform;

	[SerializeField]
	[Token(Token = "0x400334F")]
	[FieldOffset(Offset = "0x90")]
	private RectTransform m_BtnPreviousTransform;

	[SerializeField]
	[Token(Token = "0x4003350")]
	[FieldOffset(Offset = "0x98")]
	private Button m_BtnNext;

	[Token(Token = "0x4003351")]
	[SerializeField]
	[FieldOffset(Offset = "0xA0")]
	private Button m_BtnPrevious;

	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4003352")]
	[SerializeField]
	private Button m_BtnApply;

	[SerializeField]
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4003353")]
	private Assets.Scripts.PeroTools.Nice.Components.FancyScrollView m_FancyScrollView;

	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4003354")]
	private LongPressButton m_PreviousLongPressButton;

	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4003355")]
	private LongPressButton m_NextLongPressButton;

	[Token(Token = "0x4003356")]
	[FieldOffset(Offset = "0xC8")]
	private LongPressButton m_CurLongPressButton;

	[Token(Token = "0x6005579")]
	[Address(RVA = "0x6391A0", Offset = "0x6379A0", Length = "0x2CF")]
	private void Awake()
	{
	}

	[Token(Token = "0x600557A")]
	[Address(RVA = "0x6394B0", Offset = "0x637CB0", Length = "0x32")]
	public override void OnSelected()
	{
	}

	[Token(Token = "0x600557B")]
	[Address(RVA = "0x639470", Offset = "0x637C70", Length = "0x32")]
	public override void OnDeselected()
	{
	}

	[Token(Token = "0x600557C")]
	[Address(RVA = "0x6394F0", Offset = "0x637CF0", Length = "0xA9")]
	private void SetSelected(RectTransform transform)
	{
	}

	[Token(Token = "0x600557D")]
	[Address(RVA = "0x6397A0", Offset = "0x637FA0", Length = "0x11F")]
	private void TurnLeft()
	{
	}

	[Address(RVA = "0x6398C0", Offset = "0x6380C0", Length = "0x11F")]
	[Token(Token = "0x600557E")]
	private void TurnRight()
	{
	}

	[Address(RVA = "0x6395A0", Offset = "0x637DA0", Length = "0x1FD")]
	[Token(Token = "0x600557F")]
	private void TurnByAxis(float value)
	{
	}

	[Address(RVA = "0x561DF0", Offset = "0x5605F0", Length = "0x7")]
	[Token(Token = "0x6005580")]
	public PnlRoleFancyPanelDirectionControl()
	{
	}
}
