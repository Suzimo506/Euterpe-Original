namespace Rewired.Demos;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class SimpleCombinedKeyboardMouseRemapping : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public int index; //Field offset: 0x10
		public int actionElementMapId; //Field offset: 0x14
		public SimpleCombinedKeyboardMouseRemapping <>4__this; //Field offset: 0x18

		public <>c__DisplayClass17_0() { }

		internal void <RedrawUI>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <StartListeningDelayed>d__22 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public SimpleCombinedKeyboardMouseRemapping <>4__this; //Field offset: 0x20
		public int index; //Field offset: 0x28
		public ControllerMap keyboardMap; //Field offset: 0x30
		public int actionElementMapToReplaceId; //Field offset: 0x38
		public ControllerMap mouseMap; //Field offset: 0x40

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
		public <StartListeningDelayed>d__22(int <>1__state) { }

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

	private class Row
	{
		public InputAction action; //Field offset: 0x10
		public AxisRange actionRange; //Field offset: 0x18
		public Button button; //Field offset: 0x20
		public Text text; //Field offset: 0x28

		public Row() { }

	}

	private struct TargetMapping
	{
		public ControllerMap controllerMap; //Field offset: 0x0
		public int actionElementMapId; //Field offset: 0x8

	}

	private const string category = "Default"; //Field offset: 0x0
	private const string layout = "Default"; //Field offset: 0x0
	private const string uiCategory = "UI"; //Field offset: 0x0
	private InputMapper inputMapper_keyboard; //Field offset: 0x18
	private InputMapper inputMapper_mouse; //Field offset: 0x20
	public GameObject buttonPrefab; //Field offset: 0x28
	public GameObject textPrefab; //Field offset: 0x30
	public RectTransform fieldGroupTransform; //Field offset: 0x38
	public RectTransform actionGroupTransform; //Field offset: 0x40
	public Text controllerNameUIText; //Field offset: 0x48
	public Text statusUIText; //Field offset: 0x50
	private List<Row> rows; //Field offset: 0x58
	private TargetMapping _replaceTargetMapping; //Field offset: 0x60

	private Player player
	{
		private get { } //Length: 95
	}

	public SimpleCombinedKeyboardMouseRemapping() { }

	private void ClearUI() { }

	private void CreateUIRow(InputAction action, AxisRange actionRange, string label) { }

	private Player get_player() { }

	private void InitializeUI() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnInputFieldClicked(int index, int actionElementMapToReplaceId) { }

	private void OnInputMapped(InputMappedEventData data) { }

	private void OnStopped(StoppedEventData data) { }

	private void RedrawUI() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator StartListeningDelayed(int index, ControllerMap keyboardMap, ControllerMap mouseMap, int actionElementMapToReplaceId) { }

}

