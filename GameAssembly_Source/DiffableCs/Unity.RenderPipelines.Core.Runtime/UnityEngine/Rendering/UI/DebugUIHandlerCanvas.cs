namespace UnityEngine.Rendering.UI;

public class DebugUIHandlerCanvas : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Widget, Boolean> <>9__11_0; //Field offset: 0x8
		public static Action<DebugUIHandlerPanel> <>9__14_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <ActivatePanel>b__14_0(DebugUIHandlerPanel p) { }

		internal bool <Rebuild>b__11_0(Widget x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public string queryPath; //Field offset: 0x10

		public <>c__DisplayClass13_0() { }

		internal bool <GetWidgetFromPath>b__0(DebugUIHandlerWidget w) { }

	}

	private int m_DebugTreeState; //Field offset: 0x18
	private Dictionary<Type, Transform> m_PrefabsMap; //Field offset: 0x20
	public Transform panelPrefab; //Field offset: 0x28
	public List<DebugUIPrefabBundle> prefabs; //Field offset: 0x30
	private List<DebugUIHandlerPanel> m_UIPanels; //Field offset: 0x38
	private int m_SelectedPanel; //Field offset: 0x40
	private DebugUIHandlerWidget m_SelectedWidget; //Field offset: 0x48
	private string m_CurrentQueryPath; //Field offset: 0x50

	public DebugUIHandlerCanvas() { }

	[CompilerGenerated]
	private bool <ActivatePanel>b__14_1(DebugUIHandlerWidget w) { }

	private void ActivatePanel(int index, bool tryAndKeepSelection = false) { }

	private void ActivateSelection() { }

	internal void ChangeSelection(DebugUIHandlerWidget widget, bool fromNext) { }

	private void ChangeSelectionValue(float multiplier) { }

	private DebugUIHandlerWidget GetWidgetFromPath(string queryPath) { }

	private void HandleInput() { }

	private void OnEnable() { }

	private void Rebuild() { }

	internal void ResetAllHierarchy() { }

	private void SelectNextItem() { }

	private void SelectPreviousItem() { }

	private void Traverse(IContainer container, Transform parentTransform, DebugUIHandlerWidget parentUIHandler) { }

	private void Update() { }

}

