using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000FA")]
public class PnlBulletinSelect : UISelectManage
{
	[Token(Token = "0x4000621")]
	[FieldOffset(Offset = "0x118")]
	public Transform tittleToggle;

	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000622")]
	public GameObject scrollViewObj;

	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000623")]
	public GameObject ScrollVertical;

	[Token(Token = "0x4000624")]
	[FieldOffset(Offset = "0x130")]
	public Color yesColor;

	[Token(Token = "0x4000625")]
	[FieldOffset(Offset = "0x140")]
	public Color noColor;

	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4000626")]
	public RectTransform content;

	[Token(Token = "0x4000627")]
	[FieldOffset(Offset = "0x158")]
	private List<GameObject> m_NsBulletinContent;

	[Token(Token = "0x4000628")]
	[FieldOffset(Offset = "0x160")]
	private List<Toggle> m_TittleToggle;

	[Token(Token = "0x4000629")]
	[FieldOffset(Offset = "0x168")]
	private int m_ToggleIndex;

	[Token(Token = "0x400062A")]
	[FieldOffset(Offset = "0x170")]
	public BulletinTitleScroller titleScroller;

	[Address(RVA = "0x4FBCA0", Offset = "0x4FA4A0", Length = "0x36E")]
	[Token(Token = "0x6000748")]
	public override void OnInit()
	{
	}

	[Token(Token = "0x6000749")]
	[Address(RVA = "0x4FCA00", Offset = "0x4FB200", Length = "0x11E")]
	public override List<GameObject> SetSelectableObj()
	{
		return null;
	}

	[Address(RVA = "0x4FC3D0", Offset = "0x4FABD0", Length = "0x622")]
	[Token(Token = "0x600074A")]
	protected override void OnSelect(GameObject currentObj)
	{
	}

	[Token(Token = "0x600074B")]
	[Address(RVA = "0x4FBC50", Offset = "0x4FA450", Length = "0x43")]
	public override void OnEnablePnl()
	{
	}

	[Token(Token = "0x600074C")]
	[Address(RVA = "0x4FBB30", Offset = "0x4FA330", Length = "0x113")]
	public override void OnDisablePnl()
	{
	}

	[Address(RVA = "0x4FC010", Offset = "0x4FA810", Length = "0x3B7")]
	[Token(Token = "0x600074D")]
	private void OnNsChangeBulletinContent(int last, int current)
	{
	}

	[Address(RVA = "0x4FCB20", Offset = "0x4FB320", Length = "0x6C")]
	[Token(Token = "0x600074E")]
	public PnlBulletinSelect()
	{
	}
}
