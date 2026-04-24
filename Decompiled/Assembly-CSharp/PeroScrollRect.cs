using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[Token(Token = "0x200009D")]
public class PeroScrollRect : ScrollRect
{
	[Token(Token = "0x20009DF")]
	public enum ScrollDirection
	{
		[Token(Token = "0x4003559")]
		None,
		[Token(Token = "0x400355A")]
		Vertical,
		[Token(Token = "0x400355B")]
		Horizontal
	}

	[Token(Token = "0x4000450")]
	[FieldOffset(Offset = "0x128")]
	public ScrollDirection scrollDirection;

	[FieldOffset(Offset = "0x12C")]
	[Token(Token = "0x4000451")]
	public float mouseWheelScale;

	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000452")]
	private RectTransform m_RectTransform;

	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000453")]
	private LayoutGroup m_Layout;

	[Token(Token = "0x4000454")]
	[FieldOffset(Offset = "0x140")]
	private float m_LeftX;

	[Token(Token = "0x4000455")]
	[FieldOffset(Offset = "0x144")]
	private float m_RightX;

	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4000456")]
	private float m_TopY;

	[FieldOffset(Offset = "0x14C")]
	[Token(Token = "0x4000457")]
	private float m_BottomY;

	[SerializeField]
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4000458")]
	private float m_AutoScrollTime;

	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4000459")]
	private Tween m_MoveTween;

	[Token(Token = "0x60004DD")]
	[Address(RVA = "0x4F8490", Offset = "0x4F6C90", Length = "0x1F")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60004DE")]
	[Address(RVA = "0x4F7900", Offset = "0x4F6100", Length = "0x80")]
	private void Init()
	{
	}

	[Address(RVA = "0x4F78A0", Offset = "0x4F60A0", Length = "0x58")]
	[Token(Token = "0x60004DF")]
	private void EnsureLayoutHasRebuilt()
	{
	}

	[Address(RVA = "0x4F7EA0", Offset = "0x4F66A0", Length = "0x20A")]
	[Token(Token = "0x60004E0")]
	private void ResetBase()
	{
	}

	[Token(Token = "0x60004E1")]
	[Address(RVA = "0x4F7CE0", Offset = "0x4F64E0", Length = "0x1BB")]
	public override void OnScroll(PointerEventData data)
	{
	}

	[Token(Token = "0x60004E2")]
	[Address(RVA = "0x4F8310", Offset = "0x4F6B10", Length = "0x170")]
	public void ScrollToMiddle(RectTransform item, bool isGradient)
	{
	}

	[Token(Token = "0x60004E3")]
	[Address(RVA = "0x4F80B0", Offset = "0x4F68B0", Length = "0x25A")]
	public void ScrollToGood(RectTransform item, bool isGradient, bool isRest = false)
	{
	}

	[Token(Token = "0x60004E4")]
	[Address(RVA = "0x4F7990", Offset = "0x4F6190", Length = "0x343")]
	private void MoveToTarget(Vector3 targetPos, Vector3 currentPos, bool isGradient)
	{
	}

	[Token(Token = "0x60004E5")]
	[Address(RVA = "0x4F76C0", Offset = "0x4F5EC0", Length = "0x1D8")]
	private Vector3 ConvertLocalPosToWorldPos(RectTransform target)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60004E6")]
	[Address(RVA = "0x4F84D0", Offset = "0x4F6CD0", Length = "0x1B")]
	public PeroScrollRect()
	{
	}
}
