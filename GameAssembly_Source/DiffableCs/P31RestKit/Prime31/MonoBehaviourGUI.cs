namespace Prime31;

public class MonoBehaviourGUI : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <fetchScreenshot>d__56 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public string filename; //Field offset: 0x20
		public float delay; //Field offset: 0x28
		private Texture2D <screenImage>5__1; //Field offset: 0x30
		private Byte[] <imageBytes>5__2; //Field offset: 0x38

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
		public <fetchScreenshot>d__56(int <>1__state) { }

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

	protected float _width; //Field offset: 0x18
	protected float _buttonHeight; //Field offset: 0x1C
	protected Dictionary<String, Boolean> _toggleButtons; //Field offset: 0x20
	protected Dictionary<String, Boolean> _toggleTriggers; //Field offset: 0x28
	protected StringBuilder _logBuilder; //Field offset: 0x30
	private bool _logRegistered; //Field offset: 0x38
	private Vector2 _logScrollPosition; //Field offset: 0x3C
	private bool _isShowingLogConsole; //Field offset: 0x44
	private float _doubleClickDelay; //Field offset: 0x48
	private float _previousClickTime; //Field offset: 0x4C
	private bool _isIphoneX; //Field offset: 0x50
	private Texture2D _normalBackground; //Field offset: 0x58
	private Texture2D _bottomButtonBackground; //Field offset: 0x60
	private Texture2D _activeBackground; //Field offset: 0x68
	private Texture2D _toggleButtonBackground; //Field offset: 0x70
	private bool _didRetinaIpadCheck; //Field offset: 0x78
	private bool _isRetinaIpad; //Field offset: 0x79

	private Texture2D activeBackground
	{
		private get { } //Length: 230
	}

	private Texture2D bottomButtonBackground
	{
		private get { } //Length: 313
	}

	private Texture2D normalBackground
	{
		private get { } //Length: 230
	}

	private Texture2D toggleButtonBackground
	{
		private get { } //Length: 230
	}

	public MonoBehaviourGUI() { }

	private void addLogCallback() { }

	protected void beginColumn() { }

	private void beginRightColumn() { }

	protected bool bottomCenterButton(string text, float width = 150) { }

	protected bool bottomLeftButton(string text, float width = 150) { }

	protected bool bottomRightButton(string text, float width = 150) { }

	protected bool button(string text) { }

	private int buttonFontSize() { }

	private int buttonHeight() { }

	public static void captureScreenshot(string filename) { }

	private void checkForIphoneX() { }

	protected bool checkTrigger(string trigger) { }

	protected void endColumn() { }

	protected void endColumn(bool hasSecondColumn) { }

	public static IEnumerator fetchScreenshot(string filename, float delay = 3) { }

	private Texture2D get_activeBackground() { }

	private Texture2D get_bottomButtonBackground() { }

	private Texture2D get_normalBackground() { }

	private Texture2D get_toggleButtonBackground() { }

	private int getNotchOffset() { }

	private void handleLog(string logString, string stackTrace, LogType type) { }

	private bool isRetinaIpad() { }

	private bool isRetinaOrLargeScreen() { }

	public static void loadLevel(string level) { }

	public static void loadLevel(int level) { }

	private void OnDestroy() { }

	private void OnGUI() { }

	protected override void onLeftColumnGUI() { }

	protected override void onRightColumnGUI() { }

	private void paintWindow(int id) { }

	protected void prepGuiSkin() { }

	private void removeLogCallback() { }

	protected void setTrigger(string trigger, bool state = true) { }

	protected bool toggleButton(string defaultText, string selectedText) { }

	protected bool toggleButtonState(string defaultText) { }

	private void Update() { }

}

