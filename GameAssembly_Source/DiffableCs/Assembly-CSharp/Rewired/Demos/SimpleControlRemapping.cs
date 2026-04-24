namespace Rewired.Demos;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class SimpleControlRemapping : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public int index; //Field offset: 0x10
		public int actionElementMapId; //Field offset: 0x14
		public SimpleControlRemapping <>4__this; //Field offset: 0x18

		public <>c__DisplayClass21_0() { }

		internal void <RedrawUI>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <StartListeningDelayed>d__28 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public SimpleControlRemapping <>4__this; //Field offset: 0x20
		public int index; //Field offset: 0x28
		public int actionElementMapToReplaceId; //Field offset: 0x2C

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
		public <StartListeningDelayed>d__28(int <>1__state) { }

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

	private const string category = "Default"; //Field offset: 0x0
	private const string layout = "Default"; //Field offset: 0x0
	private const string uiCategory = "UI"; //Field offset: 0x0
	private InputMapper inputMapper; //Field offset: 0x18
	public GameObject buttonPrefab; //Field offset: 0x20
	public GameObject textPrefab; //Field offset: 0x28
	public RectTransform fieldGroupTransform; //Field offset: 0x30
	public RectTransform actionGroupTransform; //Field offset: 0x38
	public Text controllerNameUIText; //Field offset: 0x40
	public Text statusUIText; //Field offset: 0x48
	private ControllerType selectedControllerType; //Field offset: 0x50
	private int selectedControllerId; //Field offset: 0x54
	private List<Row> rows; //Field offset: 0x58

	private Controller controller
	{
		private get { } //Length: 130
	}

	private ControllerMap controllerMap
	{
		private get { } //Length: 278
	}

	private Player player
	{
		private get { } //Length: 95
	}

	public SimpleControlRemapping() { }

	private void ClearUI() { }

	private void CreateUIRow(InputAction action, AxisRange actionRange, string label) { }

	private Controller get_controller() { }

	private ControllerMap get_controllerMap() { }

	private Player get_player() { }

	private void InitializeUI() { }

	private void OnControllerChanged(ControllerStatusChangedEventArgs args) { }

	public void OnControllerSelected(int controllerType) { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnInputFieldClicked(int index, int actionElementMapToReplaceId) { }

	private void OnInputMapped(InputMappedEventData data) { }

	private void OnStopped(StoppedEventData data) { }

	private void RedrawUI() { }

	private void SetSelectedController(ControllerType controllerType) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator StartListeningDelayed(int index, int actionElementMapToReplaceId) { }

}

