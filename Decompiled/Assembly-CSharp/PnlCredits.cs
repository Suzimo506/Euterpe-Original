using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[Token(Token = "0x20000FC")]
public class PnlCredits : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400062D")]
	public GameObject pnlCredits;

	[Token(Token = "0x400062E")]
	[FieldOffset(Offset = "0x20")]
	public AudioClip pnlMusicClip;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400062F")]
	public AudioClip optionBgmClip;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000630")]
	public ScrollRect scrollRect;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000631")]
	public float waitTime;

	[Token(Token = "0x4000632")]
	[FieldOffset(Offset = "0x3C")]
	public float totalTime;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000633")]
	public float moveSpeed;

	[Token(Token = "0x4000634")]
	[FieldOffset(Offset = "0x48")]
	public Button backButton;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000635")]
	private Tweener m_Tweener;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000636")]
	private Sequence m_Sequence;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000637")]
	private bool m_UserControl;

	[Token(Token = "0x4000638")]
	[FieldOffset(Offset = "0x61")]
	private bool m_IsDrag;

	[SerializeField]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x12CD0", Offset = "0x120D0")]
	[Token(Token = "0x4000639")]
	private Button[] m_ClickWebBtns;

	[SerializeField]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400063A")]
	private string[] m_PcWebs;

	[Token(Token = "0x400063B")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private string[] m_MobileWebs;

	[Token(Token = "0x6000754")]
	[Address(RVA = "0x4FD910", Offset = "0x4FC110", Length = "0x46")]
	private string GetWeb(int index)
	{
		return null;
	}

	[Address(RVA = "0x4FDEF0", Offset = "0x4FC6F0", Length = "0xA2")]
	[Token(Token = "0x6000755")]
	private void OnWebClicked(int index)
	{
	}

	[Token(Token = "0x6000756")]
	[Address(RVA = "0x4FD790", Offset = "0x4FBF90", Length = "0x177")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000757")]
	[Address(RVA = "0x4FD960", Offset = "0x4FC160", Length = "0x9C")]
	private void OnBackClicked()
	{
	}

	[Token(Token = "0x6000758")]
	[Address(RVA = "0x4FDB30", Offset = "0x4FC330", Length = "0x1BB")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000759")]
	[Address(RVA = "0x4FDA00", Offset = "0x4FC200", Length = "0xB")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Address(RVA = "0x4FDCF0", Offset = "0x4FC4F0", Length = "0xB")]
	[Token(Token = "0x600075A")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	[Address(RVA = "0x4FDD00", Offset = "0x4FC500", Length = "0x74")]
	[Token(Token = "0x600075B")]
	private void OnPress()
	{
	}

	[Address(RVA = "0x4FDD80", Offset = "0x4FC580", Length = "0x160")]
	[Token(Token = "0x600075C")]
	private void OnRelease()
	{
	}

	[Address(RVA = "0x4FE000", Offset = "0x4FC800", Length = "0x1D7")]
	[Token(Token = "0x600075D")]
	private void Update()
	{
	}

	[Address(RVA = "0x4FDA10", Offset = "0x4FC210", Length = "0x11B")]
	[Token(Token = "0x600075E")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600075F")]
	[Address(RVA = "0x4FE1E0", Offset = "0x4FC9E0", Length = "0x1C")]
	public PnlCredits()
	{
	}
}
