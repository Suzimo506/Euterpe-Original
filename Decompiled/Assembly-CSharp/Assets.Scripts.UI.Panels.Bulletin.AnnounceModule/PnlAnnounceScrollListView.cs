using System.Collections.Generic;
using Cpp2ILInjected;
using PeroTools2.Pool;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.Bulletin.AnnounceModule;

[Token(Token = "0x2000959")]
public class PnlAnnounceScrollListView : MonoBehaviour
{
	[Token(Token = "0x40032F9")]
	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	private Transform m_ScrollListContent;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40032FA")]
	[SerializeField]
	private PnlAnnounceCell m_Cell;

	[SerializeField]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40032FB")]
	private ScrollRect m_CellScroll;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40032FC")]
	private Pool<PnlAnnounceCell> m_CellPool;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40032FD")]
	private int m_CurSelectIdx;

	[Token(Token = "0x40032FE")]
	[FieldOffset(Offset = "0x40")]
	private List<PnlAnnounceCell> m_ActiveCellList;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40032FF")]
	private PnlAnnounceContentController m_ContentCtrl;

	[Token(Token = "0x170008EA")]
	public PnlAnnounceCell CurrentSelect
	{
		[Token(Token = "0x60054E5")]
		[Address(RVA = "0x6CB5F0", Offset = "0x6C9DF0", Length = "0x6B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008EB")]
	public List<PnlAnnounceCell> AnnounceCellList
	{
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		[Token(Token = "0x60054E6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60054E7")]
	[Address(RVA = "0x6CAA10", Offset = "0x6C9210", Length = "0x13")]
	public void Init(PnlAnnounceContentController controller)
	{
	}

	[Token(Token = "0x60054E8")]
	[Address(RVA = "0x6CAC40", Offset = "0x6C9440", Length = "0x63F")]
	public void Refresh(Dictionary<string, List<PnlStageBulletinDataModel>> data)
	{
	}

	[Address(RVA = "0x6CAC30", Offset = "0x6C9430", Length = "0x7")]
	[Token(Token = "0x60054E9")]
	public void RefreshPostion()
	{
	}

	[Address(RVA = "0x6CA5B0", Offset = "0x6C8DB0", Length = "0x147")]
	[Token(Token = "0x60054EA")]
	private void Awake()
	{
	}

	[Address(RVA = "0x6CB580", Offset = "0x6C9D80", Length = "0x65")]
	[Token(Token = "0x60054EB")]
	private void Update()
	{
	}

	[Token(Token = "0x60054EC")]
	[Address(RVA = "0x6CA700", Offset = "0x6C8F00", Length = "0x29F")]
	private void CellOnClick(PnlAnnounceCell cellItem, PnlStageBulletinDataModel data)
	{
	}

	[Address(RVA = "0x6CB4A0", Offset = "0x6C9CA0", Length = "0xA0")]
	[Token(Token = "0x60054ED")]
	private void ResetScrollViewPosition()
	{
	}

	[Address(RVA = "0x6CB280", Offset = "0x6C9A80", Length = "0x216")]
	[Token(Token = "0x60054EE")]
	private void ResetItemNavigation()
	{
	}

	[Token(Token = "0x60054EF")]
	[Address(RVA = "0x6CA9A0", Offset = "0x6C91A0", Length = "0x63")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60054F0")]
	[Address(RVA = "0x6CA9A0", Offset = "0x6C91A0", Length = "0x63")]
	private void ClearAll()
	{
	}

	[Token(Token = "0x60054F1")]
	[Address(RVA = "0x6CAA30", Offset = "0x6C9230", Length = "0x92")]
	private PnlAnnounceCell OnCellCreate()
	{
		return null;
	}

	[Token(Token = "0x60054F2")]
	[Address(RVA = "0x6CAAD0", Offset = "0x6C92D0", Length = "0x11A")]
	private void OnListCellDisable(PnlAnnounceCell cell)
	{
	}

	[Token(Token = "0x60054F3")]
	[Address(RVA = "0x6CABF0", Offset = "0x6C93F0", Length = "0x31")]
	private void OnPopCell(PnlAnnounceCell popCell)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x60054F4")]
	public PnlAnnounceScrollListView()
	{
	}
}
