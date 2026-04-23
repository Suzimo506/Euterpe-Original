using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Database;
using Assets.Scripts.PeroTools.Nice.Components;
using Assets.Scripts.Structs;
using Assets.Scripts.UI.Panels;
using Assets.Scripts.UI.Panels.PnlMusicTag;
using Cpp2ILInjected;
using SuperScrollView;
using UnityEngine;

[Token(Token = "0x2000154")]
public class PnlMusicDifficultyItem : AbstractTabItemGenerics<PnlMusicTag>
{
	[SerializeField]
	[Token(Token = "0x4000844")]
	[FieldOffset(Offset = "0x98")]
	protected GameObject[] m_DiffUi;

	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[Token(Token = "0x4000845")]
	protected Assets.Scripts.PeroTools.Nice.Components.FancyScrollView[] m_CurMinDiffUiFsv;

	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[Token(Token = "0x4000846")]
	protected Assets.Scripts.PeroTools.Nice.Components.FancyScrollView[] m_CurMaxDiffUiFsv;

	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000847")]
	protected int m_UiIndex;

	[SerializeField]
	[Token(Token = "0x4000848")]
	[FieldOffset(Offset = "0xB8")]
	protected FsvCompsFromUi[] m_Fsvs;

	[Token(Token = "0x4000849")]
	[FieldOffset(Offset = "0xC0")]
	private BaseTreeViewItemMgr<PnlMusicDiffTreeItem> m_TreeDataMgr;

	[Token(Token = "0x400084A")]
	protected const int pc = 0;

	[Token(Token = "0x400084B")]
	protected const int mobile = 1;

	[Token(Token = "0x400084C")]
	[FieldOffset(Offset = "0xC8")]
	protected Dictionary<int, List<MusicInfo>> m_DiffDic;

	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x400084D")]
	protected Assets.Scripts.PeroTools.Nice.Components.FancyScrollView m_CurMinFsv;

	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x400084E")]
	protected Assets.Scripts.PeroTools.Nice.Components.FancyScrollView m_CurMaxFsv;

	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x400084F")]
	private Vector2Int m_DiffValue;

	[Token(Token = "0x4000850")]
	[FieldOffset(Offset = "0xE8")]
	private Coroutine m_DelaySendDiffValueCoroutine;

	[Token(Token = "0x170000C5")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView CurMinFsv
	{
		[Token(Token = "0x600098F")]
		[Address(RVA = "0x49A8C0", Offset = "0x4990C0", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C6")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView CurMaxFsv
	{
		[Address(RVA = "0x49A8A0", Offset = "0x4990A0", Length = "0x8")]
		[Token(Token = "0x6000990")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C7")]
	public Vector2Int diffValue
	{
		[Token(Token = "0x6000991")]
		[Address(RVA = "0x48E510", Offset = "0x48CD10", Length = "0x8")]
		get
		{
			return default(Vector2Int);
		}
	}

	[Token(Token = "0x170000C8")]
	public override GameObject defaultSelectedObject
	{
		[Token(Token = "0x6000992")]
		[Address(RVA = "0x7AA630", Offset = "0x7A8E30", Length = "0x2C")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x7A8D10", Offset = "0x7A7510", Length = "0x3AD")]
	[Token(Token = "0x6000993")]
	public override void InitBaseUiAndData(int curIndex)
	{
	}

	[Address(RVA = "0x7A8B60", Offset = "0x7A7360", Length = "0x79")]
	[Token(Token = "0x6000994")]
	public override string GetAreaTitle(int treeIndex)
	{
		return null;
	}

	[Address(RVA = "0x7A8950", Offset = "0x7A7150", Length = "0x20F")]
	[Token(Token = "0x6000995")]
	public override void Enable(int curTabIndex)
	{
	}

	[Address(RVA = "0x7A96D0", Offset = "0x7A7ED0", Length = "0x6C")]
	[Token(Token = "0x6000996")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x7A8810", Offset = "0x7A7010", Length = "0x65")]
	[Token(Token = "0x6000997")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x2E290", Offset = "0x2D690")]
	private IEnumerator DelayPostDiffValue()
	{
		return null;
	}

	[Address(RVA = "0x7A9F10", Offset = "0x7A8710", Length = "0xE7")]
	[Token(Token = "0x6000998")]
	private void PostDifficultFilterInfo()
	{
	}

	[Address(RVA = "0x7AA000", Offset = "0x7A8800", Length = "0x16B")]
	[Token(Token = "0x6000999")]
	private void RefreshData()
	{
	}

	[Token(Token = "0x600099A")]
	[Address(RVA = "0x7A8BE0", Offset = "0x7A73E0", Length = "0x8B")]
	private Vector2Int GetDifficultyLevel(Vector2Int diffLevel, out bool isRev)
	{
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref isRev) = null;
		return default(Vector2Int);
	}

	[Token(Token = "0x600099B")]
	[Address(RVA = "0x7A85D0", Offset = "0x7A6DD0", Length = "0x23A")]
	private int AddData(int i)
	{
		return default(int);
	}

	[Token(Token = "0x600099C")]
	[Address(RVA = "0x7A91D0", Offset = "0x7A79D0", Length = "0x37D")]
	private void MgrDataToList(List<string> buffer)
	{
	}

	[Address(RVA = "0x7A8C70", Offset = "0x7A7470", Length = "0x98")]
	[Token(Token = "0x600099D")]
	private MusicInfo GetMusicInfoByDiff(int diff, int index)
	{
		return null;
	}

	[Address(RVA = "0x7A8880", Offset = "0x7A7080", Length = "0xCD")]
	[Token(Token = "0x600099E")]
	protected override void DirtyHandler()
	{
	}

	[Address(RVA = "0x7A90C0", Offset = "0x7A78C0", Length = "0x101")]
	[Token(Token = "0x600099F")]
	public override bool InvokeEvent(int eventType)
	{
		return default(bool);
	}

	[Address(RVA = "0x7A9550", Offset = "0x7A7D50", Length = "0x12")]
	[Token(Token = "0x60009A0")]
	public void OnAdditionalConditionsChanged()
	{
	}

	[Address(RVA = "0x7A9D20", Offset = "0x7A8520", Length = "0x3B")]
	[Token(Token = "0x60009A1")]
	private void OnMinValueChanged(int index)
	{
	}

	[Token(Token = "0x60009A2")]
	[Address(RVA = "0x7A9CE0", Offset = "0x7A84E0", Length = "0x3B")]
	private void OnMaxValueChanged(int index)
	{
	}

	[Address(RVA = "0x7A9570", Offset = "0x7A7D70", Length = "0x153")]
	[Token(Token = "0x60009A3")]
	private void OnDiffValueChanged(Vector2Int value, bool forceUpdate = false)
	{
	}

	[Address(RVA = "0x7AA170", Offset = "0x7A8970", Length = "0x235")]
	[Token(Token = "0x60009A4")]
	private void SelectObjectChanged(bool isThis)
	{
	}

	[Address(RVA = "0x7AA3B0", Offset = "0x7A8BB0", Length = "0x23F")]
	[Token(Token = "0x60009A5")]
	private void SetNavigation()
	{
	}

	[Token(Token = "0x60009A6")]
	[Address(RVA = "0x7A9B70", Offset = "0x7A8370", Length = "0x169")]
	public override void OnItemChanged(int prevIndex, int curIndex, bool init = false)
	{
	}

	[Token(Token = "0x60009A7")]
	[Address(RVA = "0x7A9740", Offset = "0x7A7F40", Length = "0x42C")]
	private PnlMusicTagViewItem OnGetItemByIndex(LoopListView2<PnlMusicTagViewItem> listView, int index)
	{
		return null;
	}

	[Address(RVA = "0x7A9D60", Offset = "0x7A8560", Length = "0x1A5")]
	[Token(Token = "0x60009A8")]
	public override bool OnSelect(GameObject currentObj)
	{
		return default(bool);
	}

	[Token(Token = "0x60009A9")]
	[Address(RVA = "0x7AA5F0", Offset = "0x7A8DF0", Length = "0x38")]
	public PnlMusicDifficultyItem()
	{
		((AbstractTabItemGenerics<>)(object)this)._002Ector();
	}
}
