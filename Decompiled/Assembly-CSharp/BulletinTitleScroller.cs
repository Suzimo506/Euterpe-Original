using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000172")]
public class BulletinTitleScroller : MonoBehaviour
{
	[Token(Token = "0x4000930")]
	[FieldOffset(Offset = "0x18")]
	public Scrollbar scrollbar;

	[Token(Token = "0x4000931")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "RangeAttribute", RVA = "0x3A9C0", Offset = "0x39DC0")]
	public int ignoreCount;

	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000932")]
	private int m_ChildCount;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000933")]
	private float[] m_ScrollBarValue;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000934")]
	private bool m_IsPress;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000935")]
	private ToggleGroup m_ToggleGroup;

	[Address(RVA = "0x461F70", Offset = "0x460770", Length = "0x17C")]
	[Token(Token = "0x6000AA5")]
	private void Awake()
	{
	}

	[Address(RVA = "0x4621C0", Offset = "0x4609C0", Length = "0x37")]
	[Token(Token = "0x6000AA6")]
	private void Update()
	{
	}

	[Address(RVA = "0x4620F0", Offset = "0x4608F0", Length = "0xC7")]
	[Token(Token = "0x6000AA7")]
	public void OnValueChange(int selectIndex)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6000AA8")]
	public BulletinTitleScroller()
	{
	}
}
