using System.Collections;
using System.Diagnostics;
using Assets.Scripts.Database;
using Assets.Scripts.PeroTools.UI;
using Assets.Scripts.Structs.Modules;
using Cpp2ILInjected;
using SuperScrollView;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlMusicTag;

[Token(Token = "0x20008FC")]
public class PnlMusicSearchItem : AbstractTabItemGenerics<PnlMusicTag>
{
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4003018")]
	[SerializeField]
	private PeroInputField m_InputField;

	[Token(Token = "0x4003019")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private float m_CoolDownTime;

	[SerializeField]
	[Token(Token = "0x400301A")]
	[FieldOffset(Offset = "0xA8")]
	private Animator m_Animator;

	[Token(Token = "0x400301B")]
	[SerializeField]
	[FieldOffset(Offset = "0xB0")]
	private Button m_TrashCan;

	[Token(Token = "0x400301C")]
	[FieldOffset(Offset = "0xB8")]
	private Coroutine m_FindCoroutine;

	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400301D")]
	private Stopwatch m_Stopwatch;

	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x400301E")]
	private long m_LCoolDownTime;

	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x400301F")]
	[SerializeField]
	private GameObject m_SearchItemDefaultSelect;

	[Token(Token = "0x4003020")]
	[FieldOffset(Offset = "0xD8")]
	private SearchResults m_SearchResults;

	[Token(Token = "0x4003021")]
	[FieldOffset(Offset = "0xE0")]
	private BaseTreeViewItemMgr<PnlMusicSearchTreeItem> m_TreeDataMgr;

	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4003022")]
	private string m_SearchText;

	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4003023")]
	private bool m_PrevPlayFocus;

	[Token(Token = "0x170008AB")]
	public string searchText
	{
		[Token(Token = "0x6005184")]
		[Address(RVA = "0x4870D0", Offset = "0x4858D0", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008AC")]
	public override GameObject defaultSelectedObject
	{
		[Address(RVA = "0x67F330", Offset = "0x67DB30", Length = "0x20")]
		[Token(Token = "0x6005189")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005185")]
	[Address(RVA = "0x67D770", Offset = "0x67BF70", Length = "0x2C4")]
	public override void InitBaseUiAndData(int curIndex)
	{
	}

	[Token(Token = "0x6005186")]
	[Address(RVA = "0x67EEF0", Offset = "0x67D6F0", Length = "0xAC")]
	private void SelectObjectChanged(bool isThis)
	{
	}

	[Token(Token = "0x6005187")]
	[Address(RVA = "0x67E260", Offset = "0x67CA60", Length = "0x1F0")]
	public override void OnItemChanged(int prevIndex, int curIndex, bool init = false)
	{
	}

	[Token(Token = "0x6005188")]
	[Address(RVA = "0x67EFA0", Offset = "0x67D7A0", Length = "0x84")]
	private void SetInputToDefaultObject(bool popupInput)
	{
	}

	[Address(RVA = "0x67D070", Offset = "0x67B870", Length = "0x344")]
	[Token(Token = "0x600518A")]
	protected override void DirtyHandler()
	{
	}

	[Address(RVA = "0x67E980", Offset = "0x67D180", Length = "0x94")]
	[Token(Token = "0x600518B")]
	private void RefreshDataTitleTxt()
	{
	}

	[Address(RVA = "0x67EB70", Offset = "0x67D370", Length = "0x379")]
	[Token(Token = "0x600518C")]
	private void ResultsToDataMgr()
	{
	}

	[Token(Token = "0x600518D")]
	[Address(RVA = "0x67D680", Offset = "0x67BE80", Length = "0xEC")]
	private MusicInfo GetResultInfo(SearchType type, int index, int albumId = -1)
	{
		return null;
	}

	[Token(Token = "0x600518E")]
	[Address(RVA = "0x67DE50", Offset = "0x67C650", Length = "0x407")]
	private PnlMusicTagViewItem OnGetItemByIndex(LoopListView2<PnlMusicTagViewItem> listView, int index)
	{
		return null;
	}

	[Token(Token = "0x600518F")]
	[Address(RVA = "0x67EA20", Offset = "0x67D220", Length = "0x146")]
	private void RefreshData()
	{
	}

	[Address(RVA = "0x67E460", Offset = "0x67CC60", Length = "0xA8")]
	[Token(Token = "0x6005190")]
	private void OnSearchFocus(bool focus)
	{
	}

	[Token(Token = "0x6005191")]
	[Address(RVA = "0x67DDB0", Offset = "0x67C5B0", Length = "0x9A")]
	public override bool OnAxisDown(ButtonDirection dir, ButtonDirection nullDir, GameObject current, GameObject lastGameObject)
	{
		return default(bool);
	}

	[Token(Token = "0x6005192")]
	[Address(RVA = "0x67D3F0", Offset = "0x67BBF0", Length = "0x205")]
	public override void Enable(int curTabIndex)
	{
	}

	[Token(Token = "0x6005193")]
	[Address(RVA = "0x67D3C0", Offset = "0x67BBC0", Length = "0x23")]
	public override void Disable(int curTabIndex)
	{
	}

	[Address(RVA = "0x67F030", Offset = "0x67D830", Length = "0x1FD")]
	[Token(Token = "0x6005194")]
	private void SetNavigation()
	{
	}

	[Address(RVA = "0x67D600", Offset = "0x67BE00", Length = "0x79")]
	[Token(Token = "0x6005195")]
	public override string GetAreaTitle(int treeIndex)
	{
		return null;
	}

	[Address(RVA = "0x67DA40", Offset = "0x67C240", Length = "0x10E")]
	[Token(Token = "0x6005196")]
	public override bool InvokeEvent(int eventType)
	{
		return default(bool);
	}

	[Address(RVA = "0x67E5C0", Offset = "0x67CDC0", Length = "0x1FE")]
	[Token(Token = "0x6005197")]
	private void OnTextChanged(string text)
	{
	}

	[Address(RVA = "0x67E7C0", Offset = "0x67CFC0", Length = "0xD6")]
	[Token(Token = "0x6005198")]
	private void OnTextFocusChanged(bool focus)
	{
	}

	[Token(Token = "0x6005199")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x6BC00", Offset = "0x6B000")]
	[Address(RVA = "0x67F270", Offset = "0x67DA70", Length = "0x65")]
	private IEnumerator StartTick()
	{
		return null;
	}

	[Address(RVA = "0x67F230", Offset = "0x67DA30", Length = "0x39")]
	[Token(Token = "0x600519A")]
	public void ShowTrashCan(bool show)
	{
	}

	[Address(RVA = "0x67E8A0", Offset = "0x67D0A0", Length = "0xD6")]
	[Token(Token = "0x600519B")]
	public void OnTrashCanClick()
	{
	}

	[Address(RVA = "0x67DB50", Offset = "0x67C350", Length = "0x252")]
	[Token(Token = "0x600519C")]
	public override bool ItemUpdate()
	{
		return default(bool);
	}

	[Address(RVA = "0x67E510", Offset = "0x67CD10", Length = "0xA5")]
	[Token(Token = "0x600519D")]
	public override bool OnSelectEmpty(GameObject lastSelObj)
	{
		return default(bool);
	}

	[Address(RVA = "0x67F2E0", Offset = "0x67DAE0", Length = "0x42")]
	[Token(Token = "0x600519E")]
	public PnlMusicSearchItem()
	{
		((AbstractTabItemGenerics<>)(object)this)._002Ector();
	}
}
