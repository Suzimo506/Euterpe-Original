using System.Collections.Generic;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.Bulletin.AnnounceModule;

[Token(Token = "0x2000955")]
public class PnlAnnounceContentView : MonoBehaviour
{
	[Token(Token = "0x40032DF")]
	private static readonly Vector2 txt_title_start_pos;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40032E0")]
	private ImageLoader m_ImgLoader;

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40032E1")]
	private Image m_ImgTitle;

	[SerializeField]
	[Token(Token = "0x40032E2")]
	[FieldOffset(Offset = "0x28")]
	private YlyRichText m_TxtContent;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40032E3")]
	[SerializeField]
	private YlyRichText m_TxtTitle;

	[Token(Token = "0x40032E4")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RectTransform m_PnlTitleArea;

	[SerializeField]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40032E5")]
	private RectTransform m_AnnounceContentRect;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40032E6")]
	[SerializeField]
	private Scrollbar m_ScrollBar;

	[Token(Token = "0x40032E7")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Outline m_Outline;

	[Token(Token = "0x40032E8")]
	[FieldOffset(Offset = "0x58")]
	private Queue<Sequence> tweenSqeList;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40032E9")]
	private ScrollRect m_ContentScroll;

	[Token(Token = "0x40032EA")]
	[FieldOffset(Offset = "0x68")]
	private PnlStageBulletinDataModel m_Data;

	[Token(Token = "0x170008E4")]
	public PnlStageBulletinDataModel AnnounceData
	{
		[Token(Token = "0x60054BB")]
		[Address(RVA = "0x6C8C20", Offset = "0x6C7420", Length = "0x25")]
		set
		{
		}
	}

	[Token(Token = "0x170008E5")]
	public Scrollbar SelectableScrollbar
	{
		[Address(RVA = "0x46EF30", Offset = "0x46D730", Length = "0x5")]
		[Token(Token = "0x60054BC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008E6")]
	public ScrollRect ContentScroll
	{
		[Token(Token = "0x60054BD")]
		[Address(RVA = "0x4293D0", Offset = "0x427BD0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x6C83A0", Offset = "0x6C6BA0", Length = "0x105")]
	[Token(Token = "0x60054BE")]
	public void ResetScrollBarNavigation(Selectable naviObj)
	{
	}

	[Token(Token = "0x60054BF")]
	[Address(RVA = "0x6C86E0", Offset = "0x6C6EE0", Length = "0x1E")]
	public void SetFocusOn(bool isFocus)
	{
	}

	[Token(Token = "0x60054C0")]
	[Address(RVA = "0x6C8280", Offset = "0x6C6A80", Length = "0xA5")]
	private void Awake()
	{
	}

	[Token(Token = "0x60054C1")]
	[Address(RVA = "0x468E10", Offset = "0x467610", Length = "0x2F")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x6C8330", Offset = "0x6C6B30", Length = "0x6D")]
	[Token(Token = "0x60054C2")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60054C3")]
	[Address(RVA = "0x6C84B0", Offset = "0x6C6CB0", Length = "0x220")]
	private void SetContent()
	{
	}

	[Token(Token = "0x60054C4")]
	[Address(RVA = "0x6C8700", Offset = "0x6C6F00", Length = "0x2F9")]
	private void TitleScrollShow()
	{
	}

	[Token(Token = "0x60054C5")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PnlAnnounceContentView()
	{
	}
}
