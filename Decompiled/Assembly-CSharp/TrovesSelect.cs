using System.Collections.Generic;
using Assets.Scripts.UI.Panels;
using Assets.Scripts.UI.Specials;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000139")]
public class TrovesSelect : UISelectManage
{
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x40007AB")]
	public Transform selectableObjParent;

	[Token(Token = "0x40007AC")]
	[FieldOffset(Offset = "0x120")]
	private List<GameObject> m_SelectedObjects;

	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x40007AD")]
	public Scrollbar scrollbar;

	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x40007AE")]
	public float animTime;

	[Token(Token = "0x40007AF")]
	[FieldOffset(Offset = "0x134")]
	private int m_Count;

	[Token(Token = "0x40007B0")]
	[FieldOffset(Offset = "0x138")]
	private int m_Line;

	[FieldOffset(Offset = "0x13C")]
	[Token(Token = "0x40007B1")]
	private float m_MovingInterval;

	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x40007B2")]
	private int m_ActivateItemIndex;

	[Token(Token = "0x40007B3")]
	[FieldOffset(Offset = "0x148")]
	private GameObject m_LastSelectObj;

	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x40007B4")]
	private bool m_IsPress;

	[Token(Token = "0x40007B5")]
	private static bool s_RefreshSelectableObj;

	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x40007B6")]
	[SerializeField]
	private PnlTroves m_PnlTroves;

	[SerializeField]
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x40007B7")]
	private TroveGridView m_TroveGridView;

	[Token(Token = "0x60008D8")]
	[Address(RVA = "0x51F6F0", Offset = "0x51DEF0", Length = "0xC7")]
	public override void OnAwake()
	{
	}

	[Token(Token = "0x60008D9")]
	[Address(RVA = "0x51F670", Offset = "0x51DE70", Length = "0x7A")]
	private Selectable GetSelectable(int index)
	{
		return null;
	}

	[Token(Token = "0x60008DA")]
	[Address(RVA = "0x51F910", Offset = "0x51E110", Length = "0x130")]
	protected override void OnSelect(GameObject currentObj)
	{
	}

	[Token(Token = "0x60008DB")]
	[Address(RVA = "0x51FEB0", Offset = "0x51E6B0", Length = "0x8")]
	public override List<GameObject> SetSelectableObj()
	{
		return null;
	}

	[Token(Token = "0x60008DC")]
	[Address(RVA = "0x51FDE0", Offset = "0x51E5E0", Length = "0xCC")]
	public override Transform SetEdgeObj(GameObject currentObj)
	{
		return null;
	}

	[Address(RVA = "0x51F860", Offset = "0x51E060", Length = "0xA6")]
	[Token(Token = "0x60008DD")]
	public override void OnEnablePnl()
	{
	}

	[Token(Token = "0x60008DE")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public static void ReactivateItem()
	{
	}

	[Token(Token = "0x60008DF")]
	[Address(RVA = "0x51FA50", Offset = "0x51E250", Length = "0x37")]
	public override void OnUpdatePnl()
	{
	}

	[Token(Token = "0x60008E0")]
	[Address(RVA = "0x51FA90", Offset = "0x51E290", Length = "0xAA")]
	private void RefreshCurrentSelectObj()
	{
	}

	[Address(RVA = "0x51FB40", Offset = "0x51E340", Length = "0x29A")]
	[Token(Token = "0x60008E1")]
	private void RefreshSelectedObj()
	{
	}

	[Token(Token = "0x60008E2")]
	[Address(RVA = "0x51F7C0", Offset = "0x51DFC0", Length = "0x9D")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x51FEC0", Offset = "0x51E6C0", Length = "0x76")]
	[Token(Token = "0x60008E3")]
	public TrovesSelect()
	{
	}
}
