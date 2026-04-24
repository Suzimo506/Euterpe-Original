using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.Bulletin.AnnounceModule;

[Token(Token = "0x2000958")]
public class PnlAnnounceRequestStateController : MonoBehaviour
{
	[Token(Token = "0x40032F0")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text txtState;

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40032F1")]
	private RectTransform maskShowContent;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40032F2")]
	[SerializeField]
	private Text txtContent;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40032F3")]
	[SerializeField]
	private Button btnRefresh;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40032F4")]
	[SerializeField]
	private RectTransform rectStateBg;

	[Token(Token = "0x40032F5")]
	[SerializeField]
	[FieldOffset(Offset = "0x40")]
	private Image m_FocusOn;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40032F6")]
	private PnlAnnounceController m_MainCtrl;

	[Token(Token = "0x40032F7")]
	[FieldOffset(Offset = "0x50")]
	private Queue<Sequence> m_TweenSequences;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40032F8")]
	private Sequence m_ContentScrollSqe;

	[Token(Token = "0x170008E9")]
	public Button BtnRefresh
	{
		[Token(Token = "0x60054D6")]
		[Address(RVA = "0x45EEE0", Offset = "0x45D6E0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60054D7")]
	[Address(RVA = "0x6CA370", Offset = "0x6C8B70", Length = "0x140")]
	public void ShowProgress()
	{
	}

	[Address(RVA = "0x6CA0D0", Offset = "0x6C88D0", Length = "0x169")]
	[Token(Token = "0x60054D8")]
	public void ShowComplete()
	{
	}

	[Address(RVA = "0x6CA240", Offset = "0x6C8A40", Length = "0x12E")]
	[Token(Token = "0x60054D9")]
	public void ShowErrorInfo()
	{
	}

	[Token(Token = "0x60054DA")]
	[Address(RVA = "0x6CA060", Offset = "0x6C8860", Length = "0x67")]
	public void SetFocusOnBtnRefresh(bool isFocus)
	{
	}

	[Token(Token = "0x60054DB")]
	[Address(RVA = "0x6C9510", Offset = "0x6C7D10", Length = "0x1B2")]
	private void Awake()
	{
	}

	[Token(Token = "0x60054DC")]
	[Address(RVA = "0x6C97E0", Offset = "0x6C7FE0", Length = "0x23")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x6C96D0", Offset = "0x6C7ED0", Length = "0x10C")]
	[Token(Token = "0x60054DD")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x6C94A0", Offset = "0x6C7CA0", Length = "0x65")]
	[Token(Token = "0x60054DE")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5E20", Offset = "0x5220")]
	private IEnumerator AutoSwitchContent()
	{
		return null;
	}

	[Address(RVA = "0x6C9C20", Offset = "0x6C8420", Length = "0x2AC")]
	[Token(Token = "0x60054DF")]
	private void RefreshContentAndScroll(List<string> localizedContents)
	{
	}

	[Token(Token = "0x60054E0")]
	[Address(RVA = "0x6C9ED0", Offset = "0x6C86D0", Length = "0x18B")]
	private void ResetNavigationToContent()
	{
	}

	[Token(Token = "0x60054E1")]
	[Address(RVA = "0x6C9A40", Offset = "0x6C8240", Length = "0x1DC")]
	private void RefreshBtnDisappear(Action callback = null)
	{
	}

	[Address(RVA = "0x6C9810", Offset = "0x6C8010", Length = "0x22E")]
	[Token(Token = "0x60054E2")]
	private void RefreshBtnAppear(Action callback = null)
	{
	}

	[Token(Token = "0x60054E3")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PnlAnnounceRequestStateController()
	{
	}
}
