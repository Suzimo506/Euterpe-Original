using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

[Token(Token = "0x2000158")]
public class PnlMusicSlider : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IPointerDownHandler, IPointerUpHandler
{
	[Token(Token = "0x400087A")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform rectImage;

	[Token(Token = "0x400087B")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 oriScale;

	[Token(Token = "0x400087C")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 changeScaleOffset;

	[Token(Token = "0x400087D")]
	[FieldOffset(Offset = "0x30")]
	public float animatorTime;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400087E")]
	private Tweener m_Tweener;

	[Token(Token = "0x400087F")]
	[FieldOffset(Offset = "0x40")]
	private bool isDrag;

	[Token(Token = "0x60009D7")]
	[Address(RVA = "0x7AA660", Offset = "0x7A8E60", Length = "0xB7")]
	private void Awake()
	{
	}

	[Token(Token = "0x60009D8")]
	[Address(RVA = "0x7AA720", Offset = "0x7A8F20", Length = "0x74")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Address(RVA = "0x7AA7A0", Offset = "0x7A8FA0", Length = "0x6F")]
	[Token(Token = "0x60009D9")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60009DA")]
	[Address(RVA = "0x7AA720", Offset = "0x7A8F20", Length = "0x74")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Address(RVA = "0x7AA7A0", Offset = "0x7A8FA0", Length = "0x6F")]
	[Token(Token = "0x60009DB")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	[Address(RVA = "0x46DD90", Offset = "0x46C590", Length = "0xE")]
	[Token(Token = "0x60009DC")]
	public PnlMusicSlider()
	{
	}
}
