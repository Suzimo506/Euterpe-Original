using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Panels.Bulletin.AnnounceModule;

[Token(Token = "0x2000954")]
public class PnlAnnounceContentController : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40032DB")]
	public PnlAnnounceContentView contentView;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40032DC")]
	public PnlAnnounceScrollListView scrollListView;

	[Token(Token = "0x40032DD")]
	[FieldOffset(Offset = "0x28")]
	public PnlAnnounceController announceCtrl;

	[Token(Token = "0x40032DE")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<string, List<PnlStageBulletinDataModel>> m_AnnounceData;

	[Address(RVA = "0x6C8180", Offset = "0x6C6980", Length = "0xF3")]
	[Token(Token = "0x60054B6")]
	public void Show(PnlAnnounceController ctrl, Dictionary<string, List<PnlStageBulletinDataModel>> data = null)
	{
	}

	[Address(RVA = "0x44DE50", Offset = "0x44C650", Length = "0x26")]
	[Token(Token = "0x60054B7")]
	public void Hide()
	{
	}

	[Address(RVA = "0x6C8110", Offset = "0x6C6910", Length = "0x6E")]
	[Token(Token = "0x60054B8")]
	public void RefreshContent(Dictionary<string, List<PnlStageBulletinDataModel>> data = null)
	{
	}

	[Token(Token = "0x60054B9")]
	[Address(RVA = "0x6C80F0", Offset = "0x6C68F0", Length = "0x12")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x60054BA")]
	public PnlAnnounceContentController()
	{
	}
}
