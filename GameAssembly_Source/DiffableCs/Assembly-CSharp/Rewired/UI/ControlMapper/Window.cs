namespace Rewired.UI.ControlMapper;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class Window : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <OnEnableAsync>d__64 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Window <>4__this; //Field offset: 0x20

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
		public <OnEnableAsync>d__64(int <>1__state) { }

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

	internal class Timer
	{
		private bool _started; //Field offset: 0x10
		private float end; //Field offset: 0x14

		public bool finished
		{
			 get { } //Length: 52
		}

		public float remaining
		{
			 get { } //Length: 52
		}

		public bool started
		{
			 get { } //Length: 5
		}

		public Timer() { }

		public bool get_finished() { }

		public float get_remaining() { }

		public bool get_started() { }

		public void Start(float length) { }

		public void Stop() { }

	}

	public Image backgroundImage; //Field offset: 0x18
	public GameObject content; //Field offset: 0x20
	private bool _initialized; //Field offset: 0x28
	private int _id; //Field offset: 0x2C
	private RectTransform _rectTransform; //Field offset: 0x30
	private Text _titleText; //Field offset: 0x38
	private List<Text> _contentText; //Field offset: 0x40
	private GameObject _defaultUIElement; //Field offset: 0x48
	private Action<Int32> _updateCallback; //Field offset: 0x50
	private Func<Int32, Boolean> _isFocusedCallback; //Field offset: 0x58
	private Timer _timer; //Field offset: 0x60
	private CanvasGroup _canvasGroup; //Field offset: 0x68
	public UnityAction cancelCallback; //Field offset: 0x70
	private GameObject lastUISelection; //Field offset: 0x78

	public List<Text> contentText
	{
		 get { } //Length: 5
	}

	public GameObject defaultUIElement
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public bool hasFocus
	{
		 get { } //Length: 73
	}

	public int height
	{
		 get { } //Length: 47
		 set { } //Length: 123
	}

	public int id
	{
		 get { } //Length: 4
	}

	protected bool initialized
	{
		 get { } //Length: 5
	}

	public RectTransform rectTransform
	{
		 get { } //Length: 167
	}

	public Timer timer
	{
		 get { } //Length: 5
	}

	public Text titleText
	{
		 get { } //Length: 5
	}

	public Action<Int32> updateCallback
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public int width
	{
		 get { } //Length: 47
		 set { } //Length: 123
	}

	public Window() { }

	public void AddContentImage(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset, string text) { }

	public void AddContentImage(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset) { }

	public void AddContentText(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset, string text) { }

	public void AddContentText(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset) { }

	public override void Cancel() { }

	private void CheckUISelection() { }

	private GameObject CreateButton(GameObject prefab, string name, UIAnchor anchor, UIPivot pivot, Vector2 offset, out ButtonInfo buttonInfo) { }

	public void CreateButton(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset, string buttonText, UnityAction confirmCallback, UnityAction cancelCallback, bool setDefault) { }

	private void CreateImage(GameObject prefab, string name, UIPivot pivot, UIAnchor anchor, Vector2 offset) { }

	private void CreateText(GameObject prefab, ref Text textComponent, string name, UIPivot pivot, UIAnchor anchor, Vector2 offset) { }

	public void CreateTitleText(GameObject prefab, Vector2 offset, string text) { }

	public void CreateTitleText(GameObject prefab, Vector2 offset) { }

	public override void Disable() { }

	public override void Enable() { }

	public List<Text> get_contentText() { }

	public GameObject get_defaultUIElement() { }

	public bool get_hasFocus() { }

	public int get_height() { }

	public int get_id() { }

	protected bool get_initialized() { }

	public RectTransform get_rectTransform() { }

	public Timer get_timer() { }

	public Text get_titleText() { }

	public Action<Int32> get_updateCallback() { }

	public int get_width() { }

	public string GetContentText(int index) { }

	public float GetContentTextHeight(int index) { }

	public string GetTitleText(string text) { }

	public override void Initialize(int id, Func<Int32, Boolean> isFocusedCallback) { }

	private void OnEnable() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator OnEnableAsync() { }

	private void RestoreDefaultOrLastUISelection() { }

	public void set_defaultUIElement(GameObject value) { }

	public void set_height(int value) { }

	public void set_updateCallback(Action<Int32> value) { }

	public void set_width(int value) { }

	public void SetContentText(string text, int index) { }

	public void SetSize(int width, int height) { }

	public void SetTitleText(string text) { }

	private void SetUISelection(GameObject selection) { }

	public void SetUpdateCallback(Action<Int32> callback) { }

	public override void TakeInputFocus() { }

	protected override void Update() { }

}

