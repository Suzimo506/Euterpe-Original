//Type is in global namespace

public class AchvSelect : UISelectManage
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public Image imgSelect; //Field offset: 0x10
		public Image imgDelete; //Field offset: 0x18

		public <>c__DisplayClass32_0() { }

		internal Color <SetObjHighLight>b__0() { }

		internal void <SetObjHighLight>b__1(Color selectColor) { }

		internal Color <SetObjHighLight>b__2() { }

		internal void <SetObjHighLight>b__3(Color c) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public Button btn1; //Field offset: 0x10
		public AchvSelect <>4__this; //Field offset: 0x18

		public <>c__DisplayClass33_0() { }

		internal void <UpdateSelectableObj>b__0() { }

		internal void <UpdateSelectableObj>b__1() { }

	}

	private const int max_task_count = 3; //Field offset: 0x0
	[SerializeField]
	private RectTransform m_Rect; //Field offset: 0x110
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Transform challenges; //Field offset: 0x118
	[SerializeField]
	private GameObject m_TaskBoxPrefab; //Field offset: 0x120
	private GameObject[] m_TaskBoxs; //Field offset: 0x128
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Transform achv; //Field offset: 0x130
	[SerializeField]
	private GameObject m_AchvBoxs; //Field offset: 0x138
	public Scrollbar scrollbar; //Field offset: 0x140
	[SerializeField]
	private GameObject m_RefreshTime; //Field offset: 0x148
	public AudioClip pnlMusic; //Field offset: 0x150
	public Color highLight; //Field offset: 0x158
	public Color normal; //Field offset: 0x168
	public float animTime; //Field offset: 0x178
	private readonly List<GameObject> m_SelectableGameObjects; //Field offset: 0x180
	private readonly List<GameObject> m_SeeableObj; //Field offset: 0x188
	private GameObject m_LastObj; //Field offset: 0x190
	private int m_ChallengeCount; //Field offset: 0x198
	private bool m_IsPress; //Field offset: 0x19C
	private InputKeyBinding m_DeleteButton; //Field offset: 0x1A0
	private bool m_TaskDirty; //Field offset: 0x1A8

	public AchvSelect() { }

	[CompilerGenerated]
	private void <OnInit>b__25_0() { }

	[CompilerGenerated]
	private float <SetScrollBar>b__34_0() { }

	[CompilerGenerated]
	private void <SetScrollBar>b__34_1(float x) { }

	public virtual GameObject DefaultSelectObj() { }

	private void FastDestroyAllTask() { }

	private void InitKeyBinding(GameObject go) { }

	public virtual void OnAwake() { }

	public virtual void OnEnablePnl() { }

	public virtual void OnInit() { }

	protected virtual void OnSelect(GameObject currentObj) { }

	public virtual void OnUpdatePnl() { }

	private void RefreshTask() { }

	public void RemuseDeleteButton() { }

	public void ScrollToTop() { }

	private void SetDirty(object sender, object rev, Object[] args) { }

	public virtual Transform SetEdgeObj(GameObject currentObj) { }

	private void SetObjHighLight(GameObject obj, bool isSelect) { }

	private void SetScrollBar(int currentIndex) { }

	public virtual List<GameObject> SetSelectableObj() { }

	public void UpdateSelectableObj() { }

}

