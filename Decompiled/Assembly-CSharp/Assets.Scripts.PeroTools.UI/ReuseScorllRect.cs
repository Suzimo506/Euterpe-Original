using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.PeroTools.UI;

[Token(Token = "0x20005B8")]
[Attribute(Name = "RequireComponent", RVA = "0x94A10", Offset = "0x93E10")]
public class ReuseScorllRect : MonoBehaviour
{
	[Token(Token = "0x2000BA7")]
	public enum ScrollType
	{
		[Token(Token = "0x4003AE1")]
		Horizontal,
		[Token(Token = "0x4003AE2")]
		Vertical
	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400215D")]
	public ScrollType scrollbarType;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400215E")]
	public Scrollbar scrollbar;

	[Token(Token = "0x400215F")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x94C40", Offset = "0x94040")]
	public Slider slider;

	[Token(Token = "0x4002160")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x94DD0", Offset = "0x941D0")]
	[FieldOffset(Offset = "0x30")]
	public GameObject cell;

	[Attribute(Name = "TooltipAttribute", RVA = "0x94F30", Offset = "0x94330")]
	[Token(Token = "0x4002161")]
	[FieldOffset(Offset = "0x38")]
	public int maxCount;

	[Token(Token = "0x4002162")]
	[FieldOffset(Offset = "0x3C")]
	private int m_ContentCount;

	[Attribute(Name = "TooltipAttribute", RVA = "0x95080", Offset = "0x94480")]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002163")]
	public int seeCount;

	[Attribute(Name = "TooltipAttribute", RVA = "0x95200", Offset = "0x94600")]
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4002164")]
	public int startAt;

	[Token(Token = "0x4002165")]
	[FieldOffset(Offset = "0x48")]
	public bool isInitAtStart;

	[Token(Token = "0x4002166")]
	[FieldOffset(Offset = "0x50")]
	public string positiveButtonName;

	[Token(Token = "0x4002167")]
	[FieldOffset(Offset = "0x58")]
	public string negativeButtonName;

	[Token(Token = "0x4002168")]
	[FieldOffset(Offset = "0x60")]
	public RectTransform content;

	[Token(Token = "0x4002169")]
	[FieldOffset(Offset = "0x68")]
	private int m_FirstCellIndex;

	[Token(Token = "0x400216A")]
	[FieldOffset(Offset = "0x6C")]
	protected bool isHideSlider;

	[Token(Token = "0x400216B")]
	[FieldOffset(Offset = "0x6D")]
	private bool m_IsHasListener;

	[Token(Token = "0x400216C")]
	[FieldOffset(Offset = "0x6E")]
	private bool m_AfterAddListener;

	[Address(RVA = "0x982F80", Offset = "0x981780", Length = "0x28E")]
	[Token(Token = "0x6003962")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003963")]
	[Address(RVA = "0x9837C0", Offset = "0x981FC0", Length = "0xAB")]
	private void Update()
	{
	}

	[Address(RVA = "0x983450", Offset = "0x981C50", Length = "0x111")]
	[Token(Token = "0x6003964")]
	private void RefreshScorllBar(float f)
	{
	}

	[Address(RVA = "0x983330", Offset = "0x981B30", Length = "0x115")]
	[Token(Token = "0x6003965")]
	private void RefreshFrom(int start)
	{
	}

	[Token(Token = "0x6003966")]
	[Address(RVA = "0x983210", Offset = "0x981A10", Length = "0x116")]
	public void InitList()
	{
	}

	[Token(Token = "0x6003967")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public virtual void SetCell(GameObject obj, int index)
	{
	}

	[Token(Token = "0x6003968")]
	[Address(RVA = "0x9835B0", Offset = "0x981DB0", Length = "0xE9")]
	public void SetContentCount(int i)
	{
	}

	[Token(Token = "0x6003969")]
	[Address(RVA = "0x983570", Offset = "0x981D70", Length = "0x1C")]
	public void ScrollToNext()
	{
	}

	[Address(RVA = "0x983590", Offset = "0x981D90", Length = "0x13")]
	[Token(Token = "0x600396A")]
	public void ScrollToPrevious()
	{
	}

	[Token(Token = "0x600396B")]
	[Address(RVA = "0x9836A0", Offset = "0x981EA0", Length = "0x116")]
	public void SetScorllbarListenerEnable(bool enable)
	{
	}

	[Token(Token = "0x600396C")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public virtual void OnUpdate()
	{
	}

	[Token(Token = "0x600396D")]
	[Address(RVA = "0x983870", Offset = "0x982070", Length = "0x59")]
	public ReuseScorllRect()
	{
	}
}
