//Type is in global namespace

public class UISelectManage : SerializedMonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass57_0
	{
		public Transform obj; //Field offset: 0x10
		public UISelectManage <>4__this; //Field offset: 0x18
		public GameObject current; //Field offset: 0x20
		public DOGetter<Vector3> <>9__1; //Field offset: 0x28
		public DOSetter<Vector3> <>9__2; //Field offset: 0x30

		public <>c__DisplayClass57_0() { }

		internal void <ExcuteEdgeAnim>b__0() { }

		internal Vector3 <ExcuteEdgeAnim>b__1() { }

		internal void <ExcuteEdgeAnim>b__2(Vector3 value) { }

	}

	protected const string img_selected = "ImgSelected"; //Field offset: 0x0
	[SerializeField]
	private PanelSpecialType m_PanelSpecial; //Field offset: 0x58
	[SerializeField]
	private PanelType m_Panel; //Field offset: 0x5C
	public bool hasNavigationFunciton; //Field offset: 0x60
	public GameObject defaultSelect; //Field offset: 0x68
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool forceOnDefaultSelect; //Field offset: 0x70
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public UISelectManage deactivatePanel; //Field offset: 0x78
	public AudioClip onSelectAudio; //Field offset: 0x80
	public bool playSelectAudioOnInit; //Field offset: 0x88
	private bool m_PlayOnInit; //Field offset: 0x89
	public bool hasButtonBlinding; //Field offset: 0x8A
	public string buttonUp; //Field offset: 0x90
	public string buttonDown; //Field offset: 0x98
	public string buttonLeft; //Field offset: 0xA0
	public string buttonRight; //Field offset: 0xA8
	public bool hasEdgeAnim; //Field offset: 0xB0
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public List<Vector2> edgeAnimManager; //Field offset: 0xB8
	public AudioClip onEdgeAudio; //Field offset: 0xC0
	protected bool isOnEdgeAnim; //Field offset: 0xC8
	private ButtonDirection m_NullDir; //Field offset: 0xCC
	private bool m_IsGetAxis; //Field offset: 0xD0
	private Sequence m_Sequence; //Field offset: 0xD8
	private Vector3 m_OrgPos; //Field offset: 0xE0
	private bool m_IsExcuteAnim; //Field offset: 0xEC
	private Boolean[] m_FunctionBools; //Field offset: 0xF0
	protected GameObject lastSelectedObj; //Field offset: 0xF8
	private List<GameObject> m_SelectableObj; //Field offset: 0x100
	private String[] m_DirStrings; //Field offset: 0x108

	private bool ignoreStack
	{
		private get { } //Length: 8
	}

	public bool isPopup
	{
		 get { } //Length: 7
	}

	public PanelSpecialType panelSpecialType
	{
		 get { } //Length: 4
	}

	public PanelType panelType
	{
		 get { } //Length: 4
	}

	public UISelectManage() { }

	private void Awake() { }

	private ButtonDirection AxisToButton(float h, float v) { }

	private ButtonDirection CheckDirIsNull(GameObject obj) { }

	protected void CleanEdgeAnim(GameObject current) { }

	protected void CloseAllStackPopup() { }

	public override GameObject DefaultSelectObj() { }

	private void ExcuteEdgeAnim(GameObject current, ButtonDirection dir) { }

	private Selectable FindSelect(Selectable obj, ButtonDirection dir) { }

	private bool get_ignoreStack() { }

	public bool get_isPopup() { }

	public PanelSpecialType get_panelSpecialType() { }

	public PanelType get_panelType() { }

	private ButtonDirection GetAxisDown() { }

	protected void GetButtonDown(ButtonDirection dir) { }

	private Selectable GetCurrentSelectable(GameObject obj) { }

	protected Vector3 GetEdgeAnimPos(ButtonDirection dir, float vaule) { }

	private bool IsOnSelectableObj(GameObject current) { }

	public override bool IsThisUiManager() { }

	private bool m_IsHasSelectAudio() { }

	private void MoveToSelectable(Selectable obj, ButtonDirection dir) { }

	public override void OnAwake() { }

	protected override void OnAxisDown(ButtonDirection dir, ButtonDirection nullDir, GameObject current, GameObject lastGameObject) { }

	public override void OnCheckNullDir() { }

	private void OnDisable() { }

	public override void OnDisablePnl() { }

	private void OnEnable() { }

	public override void OnEnablePnl() { }

	public override void OnInit() { }

	protected override void OnSelect(GameObject currentObj) { }

	protected override void OnSelectEmpty(GameObject lastSelObj) { }

	public override void OnStart() { }

	public override void OnUpdatePnl() { }

	private void PlayAudio(AudioClip clip) { }

	public override Transform SetEdgeObj(GameObject currentObj) { }

	public void SetEnable(bool enable, bool needToSetDefault = true) { }

	public override void SetKeyBindings(GameObject obj, bool enable, bool isStart = false) { }

	protected void SetPanelBindings() { }

	public override List<GameObject> SetSelectableObj() { }

	protected void SetSelectableObjList(List<GameObject> objs) { }

	private void Start() { }

	private void Update() { }

}

