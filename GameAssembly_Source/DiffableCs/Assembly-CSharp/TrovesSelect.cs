//Type is in global namespace

public class TrovesSelect : UISelectManage
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public Transform last; //Field offset: 0x10

		public <>c__DisplayClass16_0() { }

		internal Vector3 <OnSelect>b__0() { }

		internal void <OnSelect>b__1(Vector3 l) { }

	}

	[CompilerGenerated]
	private sealed class <UpdateActivate>d__20 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public TrovesSelect <>4__this; //Field offset: 0x20

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
		public <UpdateActivate>d__20(int <>1__state) { }

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

	private static bool s_RefreshSelectableObj; //Field offset: 0x0
	public Transform selectableObjParent; //Field offset: 0x110
	private List<GameObject> m_SelectedObjects; //Field offset: 0x118
	public Scrollbar scrollbar; //Field offset: 0x120
	public float animTime; //Field offset: 0x128
	private int m_Count; //Field offset: 0x12C
	private int m_Line; //Field offset: 0x130
	private float m_MovingInterval; //Field offset: 0x134
	private int m_ActivateItemIndex; //Field offset: 0x138
	private GameObject m_LastSelectObj; //Field offset: 0x140
	private bool m_IsPress; //Field offset: 0x148
	[SerializeField]
	private PnlTroves m_PnlTroves; //Field offset: 0x150

	private static TrovesSelect() { }

	public TrovesSelect() { }

	[CompilerGenerated]
	private void <OnEnablePnl>b__19_0() { }

	[CompilerGenerated]
	private float <OnSelect>b__16_2() { }

	[CompilerGenerated]
	private void <OnSelect>b__16_3(float x) { }

	private void AdjuseNaviOnShouTai() { }

	public virtual GameObject DefaultSelectObj() { }

	private int GetCellCount(GridLayoutGroup g) { }

	private Selectable GetSelectable(int index) { }

	public virtual void OnAwake() { }

	public virtual void OnEnablePnl() { }

	protected virtual void OnSelect(GameObject currentObj) { }

	public virtual void OnUpdatePnl() { }

	public static void ReactivateItem() { }

	private void RefreshSelectedObj() { }

	public virtual Transform SetEdgeObj(GameObject currentObj) { }

	public virtual List<GameObject> SetSelectableObj() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator UpdateActivate() { }

}

