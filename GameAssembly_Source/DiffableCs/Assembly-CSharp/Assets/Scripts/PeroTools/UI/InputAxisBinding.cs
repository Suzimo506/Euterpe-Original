namespace Assets.Scripts.PeroTools.UI;

public class InputAxisBinding : MonoBehaviour, IInputKeyBinding
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public Scrollbar bar; //Field offset: 0x10

		public <>c__DisplayClass26_0() { }

		internal float <ListenKeyPress>b__0() { }

		internal void <ListenKeyPress>b__1(float v) { }

	}

	internal enum Type
	{
		Button = 0,
		Axis = 1,
	}

	private UISelectManage m_UiManage; //Field offset: 0x18
	public Type type; //Field offset: 0x20
	public string negative; //Field offset: 0x28
	public string positive; //Field offset: 0x30
	public string axisName; //Field offset: 0x38
	public bool loopToggleGroup; //Field offset: 0x40
	private List<Toggle> m_AllToggles; //Field offset: 0x48
	private ToggleGroup m_ToggleGroup; //Field offset: 0x50
	private string m_Guid; //Field offset: 0x58
	private bool m_IsAxisInUse; //Field offset: 0x60
	private int m_Appen; //Field offset: 0x64
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool hasInertia; //Field offset: 0x68
	public float inertia; //Field offset: 0x6C
	public float inertiaTime; //Field offset: 0x70
	private int m_InertiaVaule; //Field offset: 0x74
	private Sequence m_Sequence; //Field offset: 0x78
	private UnityGameManager m_UnityGameManager; //Field offset: 0x80

	public override UISelectManage GetPanelOrder
	{
		 get { } //Length: 5
	}

	public override bool IsOnCurrentPanel
	{
		 get { } //Length: 143
	}

	public InputAxisBinding() { }

	[CompilerGenerated]
	private void <ListenKeyPress>b__26_2() { }

	private void Awake() { }

	public override UISelectManage get_GetPanelOrder() { }

	public override bool get_IsOnCurrentPanel() { }

	private void ListenKeyPress(float arg0) { }

	private bool m_IsHasScrollBar() { }

	public void MoveToggleGroup(ToggleGroup tglGroup, int append) { }

	private void OnDestroy() { }

	public override void SetPanelOrder(UISelectManage uiManage) { }

}

