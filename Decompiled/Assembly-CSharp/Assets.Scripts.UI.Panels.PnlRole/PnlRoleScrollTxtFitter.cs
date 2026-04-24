using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlRole;

[Token(Token = "0x2000968")]
public class PnlRoleScrollTxtFitter : PnlRoleSelectedItem
{
	[Token(Token = "0x4003390")]
	[SerializeField]
	[FieldOffset(Offset = "0x80")]
	private TextMeshProUGUI m_TxtScroll;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4003391")]
	[SerializeField]
	private ContentSizeFitter m_ContentSizeFitter;

	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	[Token(Token = "0x4003392")]
	private Scrollbar m_Scrollbar;

	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4003393")]
	[SerializeField]
	private RectTransform m_TxtRectTransform;

	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4003394")]
	[SerializeField]
	private float m_HeightBound;

	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x4003395")]
	private Vector2 m_OriTxtSizeDelta;

	[SerializeField]
	[Token(Token = "0x4003396")]
	[FieldOffset(Offset = "0xB0")]
	private Dictionary<string, Vector4> m_ScrollMarginMapping;

	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4003397")]
	[SerializeField]
	private Dictionary<string, float> m_LanguageToFontSizeMapping;

	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4003398")]
	private Vector4 m_CurScrollMargin;

	[Token(Token = "0x4003399")]
	[FieldOffset(Offset = "0xD0")]
	private bool m_IsScroll;

	[Address(RVA = "0x640000", Offset = "0x63E800", Length = "0x29")]
	[Token(Token = "0x60055D0")]
	public void ResetScrollPosition()
	{
	}

	[Token(Token = "0x60055D1")]
	[Address(RVA = "0x63FD80", Offset = "0x63E580", Length = "0x167")]
	private void Awake()
	{
	}

	[Address(RVA = "0x63FEF0", Offset = "0x63E6F0", Length = "0x10F")]
	[Token(Token = "0x60055D2")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x640030", Offset = "0x63E830", Length = "0xB3")]
	[Token(Token = "0x60055D3")]
	public void SetNewTxt(string txt)
	{
	}

	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x14F30", Offset = "0x14330")]
	[Token(Token = "0x60055D4")]
	[Address(RVA = "0x6401B0", Offset = "0x63E9B0", Length = "0x65")]
	private IEnumerator TxtSizeFitter()
	{
		return null;
	}

	[Address(RVA = "0x6400F0", Offset = "0x63E8F0", Length = "0xB1")]
	[Token(Token = "0x60055D5")]
	private void TurnVertical(float value)
	{
	}

	[Token(Token = "0x60055D6")]
	[Address(RVA = "0x561DF0", Offset = "0x5605F0", Length = "0x7")]
	public PnlRoleScrollTxtFitter()
	{
	}
}
