namespace Assets.Scripts.UI.Panels.PnlMusicTag;

public class PnlMusicSearchItem : AbstractTabItemGenerics<PnlMusicTag>
{
	[CompilerGenerated]
	private sealed class <StartTick>d__30 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PnlMusicSearchItem <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <StartTick>d__30(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[SerializeField]
	private PeroInputField m_InputField; //Field offset: 0x98
	[SerializeField]
	private float m_CoolDownTime; //Field offset: 0xA0
	[SerializeField]
	private Animator m_Animator; //Field offset: 0xA8
	private Coroutine m_FindCoroutine; //Field offset: 0xB0
	private Stopwatch m_Stopwatch; //Field offset: 0xB8
	private long m_LCoolDownTime; //Field offset: 0xC0
	private SearchResults m_SearchResults; //Field offset: 0xC8
	private BaseTreeViewItemMgr<PnlMusicSearchTreeItem> m_TreeDataMgr; //Field offset: 0xD0
	private bool m_PrevPlayFocus; //Field offset: 0xD8

	public virtual GameObject defaultSelectedObject
	{
		 get { } //Length: 32
	}

	public PnlMusicSearchItem() { }

	protected virtual void DirtyHandler() { }

	public virtual void Disable(int curTabIndex) { }

	public virtual void Enable(int curTabIndex) { }

	public virtual GameObject get_defaultSelectedObject() { }

	public virtual string GetAreaTitle(int treeIndex) { }

	private MusicInfo GetResultInfo(SearchType type, int index) { }

	public virtual void InitBaseUiAndData(int curIndex) { }

	public virtual bool InvokeEvent(int eventType) { }

	public virtual bool ItemUpdate() { }

	public virtual bool OnAxisDown(ButtonDirection dir, ButtonDirection nullDir, GameObject current, GameObject lastGameObject) { }

	private PnlMusicTagViewItem OnGetItemByIndex(LoopListView2<PnlMusicTagViewItem> listView, int index) { }

	public virtual void OnItemChanged(int prevIndex, int curIndex, bool init = false) { }

	private void OnSearchFocus(bool focus) { }

	public virtual bool OnSelectEmpty(GameObject lastSelObj) { }

	private void OnTextChanged(string text) { }

	private void OnTextFocusChanged(bool focus) { }

	private void RefreshData() { }

	private void RefreshDataTitleTxt() { }

	private void ResultsToDataMgr() { }

	private void SelectObjectChanged(bool isThis) { }

	private void SetInputToDefaultObject(bool popupInput) { }

	private void SetNavigation() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator StartTick() { }

}

