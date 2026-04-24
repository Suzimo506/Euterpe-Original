using System.Collections.Generic;
using Assets.Scripts.Database;
using Assets.Scripts.Database.DataClass;
using Assets.Scripts.UI.Panels;
using Assets.Scripts.UI.Panels.PnlMusicTag;
using Cpp2ILInjected;
using SuperScrollView;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000155")]
public class PnlMusicTagItem : AbstractTabItemGenerics<PnlMusicTag>
{
	[Token(Token = "0x4000851")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private GameObject m_CustomTagButton;

	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000852")]
	[SerializeField]
	private ToggleGroup m_ToggleGroup;

	[SerializeField]
	[Token(Token = "0x4000853")]
	[FieldOffset(Offset = "0xA8")]
	private Transform m_TagGroup1;

	[SerializeField]
	[Token(Token = "0x4000854")]
	[FieldOffset(Offset = "0xB0")]
	private Transform m_TagGroup2;

	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000855")]
	private Dictionary<int, AlbumTagToggle> m_Toggles;

	[Token(Token = "0x4000856")]
	[FieldOffset(Offset = "0xC0")]
	private int m_CurTagIndex;

	[Token(Token = "0x4000857")]
	[FieldOffset(Offset = "0xC4")]
	private bool m_IsUnlockAll;

	[Token(Token = "0x4000858")]
	[FieldOffset(Offset = "0xC8")]
	private BaseTreeViewItemMgr<PnlMusicTagTreeItem> m_TreeDataMgr;

	[Token(Token = "0x4000859")]
	[FieldOffset(Offset = "0xD0")]
	private List<int> m_LockSortAlbumJsonIndex;

	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x400085A")]
	private List<int> m_UnlockSortAlbumJsonIndex;

	[Token(Token = "0x400085B")]
	[FieldOffset(Offset = "0xE0")]
	private Dictionary<int, List<MusicInfo>> m_LockMusicInfos;

	[Token(Token = "0x400085C")]
	[FieldOffset(Offset = "0xE8")]
	private Dictionary<int, List<MusicInfo>> m_UnlockMusicInfos;

	[Token(Token = "0x170000C9")]
	public int curTagIndex
	{
		[Address(RVA = "0x48E500", Offset = "0x48CD00", Length = "0x7")]
		[Token(Token = "0x60009AA")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170000CA")]
	public override GameObject defaultSelectedObject
	{
		[Address(RVA = "0x7AE690", Offset = "0x7ACE90", Length = "0x5B")]
		[Token(Token = "0x60009AB")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60009AC")]
	[Address(RVA = "0x7ABB60", Offset = "0x7AA360", Length = "0x1BD")]
	public override void InitBaseUiAndData(int curIndex)
	{
	}

	[Token(Token = "0x60009AD")]
	[Address(RVA = "0x7AB730", Offset = "0x7A9F30", Length = "0x79")]
	public override string GetAreaTitle(int treeIndex)
	{
		return null;
	}

	[Token(Token = "0x60009AE")]
	[Address(RVA = "0x7AB4D0", Offset = "0x7A9CD0", Length = "0x25B")]
	public override void Enable(int curTabIndex)
	{
	}

	[Address(RVA = "0x7AB910", Offset = "0x7AA110", Length = "0x14B")]
	[Token(Token = "0x60009AF")]
	public override bool GetSelectGameObject(List<GameObject> buffer)
	{
		return default(bool);
	}

	[Token(Token = "0x60009B0")]
	[Address(RVA = "0x7AB350", Offset = "0x7A9B50", Length = "0x177")]
	protected override void DirtyHandler()
	{
	}

	[Address(RVA = "0x7AD440", Offset = "0x7ABC40", Length = "0x9A")]
	[Token(Token = "0x60009B1")]
	private void RefreshDataTitleTxt()
	{
	}

	[Token(Token = "0x60009B2")]
	[Address(RVA = "0x7AC240", Offset = "0x7AAA40", Length = "0x371")]
	public override bool InvokeEvent(int eventType)
	{
		return default(bool);
	}

	[Address(RVA = "0x7AB090", Offset = "0x7A9890", Length = "0x2B2")]
	[Token(Token = "0x60009B3")]
	private void ClearData()
	{
	}

	[Token(Token = "0x60009B4")]
	[Address(RVA = "0x7AB7B0", Offset = "0x7A9FB0", Length = "0x15D")]
	private List<MusicInfo> GetMusicInfos(int index, bool isUnlock)
	{
		return null;
	}

	[Address(RVA = "0x7AA810", Offset = "0x7A9010", Length = "0xBF")]
	[Token(Token = "0x60009B5")]
	private void AddDataToMgr(int index, int count, bool isUnlock, int tagIndex = -1)
	{
	}

	[Token(Token = "0x60009B6")]
	[Address(RVA = "0x7AC5C0", Offset = "0x7AADC0", Length = "0x4EB")]
	private void MgrToUids(List<string> buffer)
	{
	}

	[Token(Token = "0x60009B7")]
	[Address(RVA = "0x7AA980", Offset = "0x7A9180", Length = "0x2F1")]
	private void AddWeekFree()
	{
	}

	[Token(Token = "0x60009B8")]
	[Address(RVA = "0x7AD4E0", Offset = "0x7ABCE0", Length = "0x54C")]
	private void RefreshTagTreeData()
	{
	}

	[Address(RVA = "0x7ACBB0", Offset = "0x7AB3B0", Length = "0x3DA")]
	[Token(Token = "0x60009B9")]
	private void NoTitleSort(AlbumTagInfo tagInfo)
	{
	}

	[Token(Token = "0x60009BA")]
	[Address(RVA = "0x7AAC80", Offset = "0x7A9480", Length = "0x402")]
	private void BaseAlbumSort(List<AlbumDisplayMusic> albums)
	{
	}

	[Token(Token = "0x60009BB")]
	[Address(RVA = "0x7ADF40", Offset = "0x7AC740", Length = "0x6CE")]
	private void SortAllAlbum(List<AlbumDisplayMusic> albums)
	{
	}

	[Token(Token = "0x60009BC")]
	[Address(RVA = "0x7AA8D0", Offset = "0x7A90D0", Length = "0xAC")]
	private void AddSortList(int index, bool isUnlock)
	{
	}

	[Token(Token = "0x60009BD")]
	[Address(RVA = "0x7ADA30", Offset = "0x7AC230", Length = "0x248")]
	private void SelectObjectChanged(bool isThis)
	{
	}

	[Token(Token = "0x60009BE")]
	[Address(RVA = "0x7ADC80", Offset = "0x7AC480", Length = "0x19F")]
	private void SetNavigation()
	{
	}

	[Token(Token = "0x60009BF")]
	[Address(RVA = "0x7AD2A0", Offset = "0x7ABAA0", Length = "0x144")]
	public override void OnItemChanged(int prevIndex, int curIndex, bool init = false)
	{
	}

	[Token(Token = "0x60009C0")]
	[Address(RVA = "0x7ACF90", Offset = "0x7AB790", Length = "0x306")]
	private PnlMusicTagViewItem OnGetItemByIndex(LoopListView2<PnlMusicTagViewItem> listView, int index)
	{
		return null;
	}

	[Address(RVA = "0x7ABD20", Offset = "0x7AA520", Length = "0x512")]
	[Token(Token = "0x60009C1")]
	private void InitToggles()
	{
	}

	[Token(Token = "0x60009C2")]
	[Address(RVA = "0x7ADE20", Offset = "0x7AC620", Length = "0x96")]
	private void ShowTip(string key)
	{
	}

	[Address(RVA = "0x7ACAB0", Offset = "0x7AB2B0", Length = "0xF0")]
	[Token(Token = "0x60009C3")]
	public bool MusicTagHideAndLikeHandler(int tagIndex)
	{
		return default(bool);
	}

	[Address(RVA = "0x7ABA60", Offset = "0x7AA260", Length = "0xF2")]
	[Token(Token = "0x60009C4")]
	private bool HideAndLikeTagHandler(int tagIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x60009C5")]
	[Address(RVA = "0x7ADEC0", Offset = "0x7AC6C0", Length = "0x70")]
	private void ShowWarningTxt()
	{
	}

	[Address(RVA = "0x7AD3F0", Offset = "0x7ABBF0", Length = "0x4C")]
	[Token(Token = "0x60009C6")]
	private void OnTagClicked(int tagIndex)
	{
	}

	[Address(RVA = "0x7AE610", Offset = "0x7ACE10", Length = "0x7B")]
	[Token(Token = "0x60009C7")]
	public PnlMusicTagItem()
	{
		((AbstractTabItemGenerics<>)(object)this)._002Ector();
	}
}
