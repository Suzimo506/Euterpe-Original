namespace UnityEngine.Rendering;

public sealed class DebugManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Boolean> <>9__51_0; //Field offset: 0x8
		public static Action <>9__51_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal DebugManager <.cctor>b__68_0() { }

		internal void <.ctor>b__51_0(bool <p0>) { }

		internal void <.ctor>b__51_1() { }

	}

	private const string kEnableDebugBtn1 = "Enable Debug Button 1"; //Field offset: 0x0
	private const string kEnableDebugBtn2 = "Enable Debug Button 2"; //Field offset: 0x0
	private const string kDebugPreviousBtn = "Debug Previous"; //Field offset: 0x0
	private const string kDebugNextBtn = "Debug Next"; //Field offset: 0x0
	private const string kValidateBtn = "Debug Validate"; //Field offset: 0x0
	private const string kPersistentBtn = "Debug Persistent"; //Field offset: 0x0
	private const string kDPadVertical = "Debug Vertical"; //Field offset: 0x0
	private const string kDPadHorizontal = "Debug Horizontal"; //Field offset: 0x0
	private const string kMultiplierBtn = "Debug Multiplier"; //Field offset: 0x0
	private const string kResetBtn = "Debug Reset"; //Field offset: 0x0
	private static readonly Lazy<DebugManager> s_Instance; //Field offset: 0x0
	private DebugActionDesc[] m_DebugActions; //Field offset: 0x10
	private DebugActionState[] m_DebugActionStates; //Field offset: 0x18
	private ReadOnlyCollection<Panel> m_ReadOnlyPanels; //Field offset: 0x20
	private readonly List<Panel> m_Panels; //Field offset: 0x28
	[CompilerGenerated]
	private Action<Boolean> onDisplayRuntimeUIChanged; //Field offset: 0x30
	[CompilerGenerated]
	private Action onSetDirty; //Field offset: 0x38
	[CompilerGenerated]
	private Action resetData; //Field offset: 0x40
	public bool refreshEditorRequested; //Field offset: 0x48
	private GameObject m_Root; //Field offset: 0x50
	private DebugUIHandlerCanvas m_RootUICanvas; //Field offset: 0x58
	private GameObject m_PersistentRoot; //Field offset: 0x60
	private DebugUIHandlerPersistentCanvas m_RootUIPersistentCanvas; //Field offset: 0x68
	private bool m_EditorOpen; //Field offset: 0x70

	public event Action<Boolean> onDisplayRuntimeUIChanged
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action onSetDirty
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	private event Action resetData
	{
		[CompilerGenerated]
		private add { } //Length: 158
		[CompilerGenerated]
		private remove { } //Length: 158
	}

	public bool displayEditorUI
	{
		 get { } //Length: 5
	}

	public bool displayPersistentRuntimeUI
	{
		 get { } //Length: 133
		 set { } //Length: 59
	}

	public bool displayRuntimeUI
	{
		 get { } //Length: 133
		 set { } //Length: 588
	}

	public static DebugManager instance
	{
		 get { } //Length: 107
	}

	public ReadOnlyCollection<Panel> panels
	{
		 get { } //Length: 35
	}

	private static DebugManager() { }

	private DebugManager() { }

	[CompilerGenerated]
	public void add_onDisplayRuntimeUIChanged(Action<Boolean> value) { }

	[CompilerGenerated]
	public void add_onSetDirty(Action value) { }

	[CompilerGenerated]
	private void add_resetData(Action value) { }

	private void AddAction(DebugAction action, DebugActionDesc desc) { }

	internal void ChangeSelection(DebugUIHandlerWidget widget, bool fromNext) { }

	private void CheckPersistentCanvas() { }

	public bool get_displayEditorUI() { }

	public bool get_displayPersistentRuntimeUI() { }

	public bool get_displayRuntimeUI() { }

	public static DebugManager get_instance() { }

	public ReadOnlyCollection<Panel> get_panels() { }

	internal float GetAction(DebugAction action) { }

	private Widget GetItem(string queryPath, IContainer container) { }

	public Widget GetItem(string queryPath) { }

	public Panel GetPanel(string displayName, bool createIfNull = false, int groupIndex = 0, bool overrideIfExist = false) { }

	public int GetState() { }

	private void OnPanelDirty(Panel panel) { }

	public void ReDrawOnScreenDebug() { }

	public void RefreshEditor() { }

	private void RegisterActions() { }

	public void RegisterData(IDebugData data) { }

	private void RegisterInputs() { }

	internal void RegisterRootCanvas(DebugUIHandlerCanvas root) { }

	[CompilerGenerated]
	public void remove_onDisplayRuntimeUIChanged(Action<Boolean> value) { }

	[CompilerGenerated]
	public void remove_onSetDirty(Action value) { }

	[CompilerGenerated]
	private void remove_resetData(Action value) { }

	public void RemovePanel(Panel panel) { }

	public void RemovePanel(string displayName) { }

	public void Reset() { }

	private void SampleAction(int actionIndex) { }

	public void set_displayPersistentRuntimeUI(bool value) { }

	public void set_displayRuntimeUI(bool value) { }

	public void ToggleEditorUI(bool open) { }

	internal void TogglePersistent(Widget widget) { }

	public void UnregisterData(IDebugData data) { }

	private void UpdateAction(int actionIndex) { }

	internal void UpdateActions() { }

	private void UpdateReadOnlyCollection() { }

}

