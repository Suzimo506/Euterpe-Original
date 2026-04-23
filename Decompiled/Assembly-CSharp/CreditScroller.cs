using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200005F")]
public class CreditScroller : MonoBehaviour
{
	[Token(Token = "0x40002C6")]
	[FieldOffset(Offset = "0x18")]
	public Camera uguiCamera;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002C7")]
	public GameObject uguiScrollView;

	[Token(Token = "0x40002C8")]
	[FieldOffset(Offset = "0x28")]
	public GameObject uguiScrollRect;

	[Token(Token = "0x40002C9")]
	[FieldOffset(Offset = "0x30")]
	public GameObject uguiContent;

	[Token(Token = "0x40002CA")]
	[FieldOffset(Offset = "0x38")]
	public GameObject uguiScrollbar;

	[Token(Token = "0x40002CB")]
	[FieldOffset(Offset = "0x40")]
	private Scrollbar scrollbar;

	[Token(Token = "0x40002CC")]
	[FieldOffset(Offset = "0x48")]
	private Tweener scrollbarTween;

	[Token(Token = "0x40002CD")]
	[FieldOffset(Offset = "0x50")]
	private float tweenFloat;

	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40002CE")]
	private bool isAutoScrolling;

	[FieldOffset(Offset = "0x55")]
	[Token(Token = "0x40002CF")]
	private bool touchInside;

	[Token(Token = "0x40002D0")]
	[FieldOffset(Offset = "0x58")]
	private float currentStart;

	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40002D1")]
	private float easeInA;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40002D2")]
	private float easeInB;

	[Token(Token = "0x40002D3")]
	[FieldOffset(Offset = "0x64")]
	private float easeStart;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40002D4")]
	private int fingerID;

	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40002D5")]
	private float initialTime;

	[Token(Token = "0x40002D6")]
	[FieldOffset(Offset = "0x70")]
	private float mathHelperA;

	[Token(Token = "0x40002D7")]
	[FieldOffset(Offset = "0x74")]
	private float mathHelperB;

	[Token(Token = "0x40002D8")]
	[FieldOffset(Offset = "0x78")]
	private float percentage;

	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x40002D9")]
	private float time;

	[Token(Token = "0x40002DA")]
	[FieldOffset(Offset = "0x80")]
	private bool letsGo;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40002DB")]
	private ScrollRect srComponent;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40002DC")]
	[Attribute(Name = "RangeAttribute", RVA = "0x6A6E0", Offset = "0x69AE0")]
	public float scrollSpeed;

	[Token(Token = "0x40002DD")]
	[FieldOffset(Offset = "0x94")]
	public float initialDelay;

	[Address(RVA = "0x469BC0", Offset = "0x4683C0", Length = "0x9")]
	[Token(Token = "0x60002F0")]
	private void Awake()
	{
	}

	[Address(RVA = "0x46A330", Offset = "0x468B30", Length = "0x1E2")]
	[Token(Token = "0x60002F1")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x46A230", Offset = "0x468A30", Length = "0xF8")]
	[Token(Token = "0x60002F2")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x46A6F0", Offset = "0x468EF0", Length = "0x549")]
	[Token(Token = "0x60002F3")]
	private void Update()
	{
	}

	[Address(RVA = "0x469BD0", Offset = "0x4683D0", Length = "0x3BD")]
	[Token(Token = "0x60002F4")]
	private void DelayedSetup()
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x469F90", Offset = "0x468790", Length = "0x150")]
	private void InitialEaseIn()
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x46A0E0", Offset = "0x4688E0", Length = "0x14B")]
	private void InitialScroll()
	{
	}

	[Address(RVA = "0x46A520", Offset = "0x468D20", Length = "0x1A0")]
	[Token(Token = "0x60002F7")]
	private void PressReleased()
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x469A70", Offset = "0x468270", Length = "0x145")]
	private void AutoScrolling()
	{
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x469A60", Offset = "0x468260", Length = "0x5")]
	private void AutoScrollEnd()
	{
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x46AC40", Offset = "0x469440", Length = "0x1B")]
	public CreditScroller()
	{
	}
}
