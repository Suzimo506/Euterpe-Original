namespace ZenFulcrum.EmbeddedBrowser;

[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ExternalKeyboard : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Browser, Boolean> <>9__22_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__22_0(Browser browser, bool editable) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public ExternalKeyboard <>4__this; //Field offset: 0x10
		public Browser browser; //Field offset: 0x18

		public <>c__DisplayClass16_0() { }

		internal void <ObserveBrowser>b__0(string tagName, bool editable, string value) { }

		internal void <ObserveBrowser>b__1() { }

	}

	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool automaticFocus; //Field offset: 0x18
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Browser initialBrowser; //Field offset: 0x20
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool hideWhenUnneeded; //Field offset: 0x28
	protected PointerUIBase activeBrowserUI; //Field offset: 0x30
	protected Browser keyboardBrowser; //Field offset: 0x38
	protected bool forcingFocus; //Field offset: 0x40
	protected Browser _activeBrowser; //Field offset: 0x48
	[CompilerGenerated]
	private Action<Browser, Boolean> onFocusChange; //Field offset: 0x50

	public event Action<Browser, Boolean> onFocusChange
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	protected override Browser ActiveBrowser
	{
		 get { } //Length: 5
		 set { } //Length: 37
	}

	protected void _SetActiveBrowser(Browser browser) { }

	public ExternalKeyboard() { }

	[CompilerGenerated]
	public void add_onFocusChange(Action<Browser, Boolean> value) { }

	public void Awake() { }

	protected void CommandEntered(JSONNode args) { }

	protected void DoFocus(Browser browser) { }

	protected override Browser get_ActiveBrowser() { }

	protected void ObserveBrowser(Browser browser) { }

	public void OnDisable() { }

	protected void OnKeyboardFocus(bool mouseFocused, bool kbFocused) { }

	[CompilerGenerated]
	public void remove_onFocusChange(Action<Browser, Boolean> value) { }

	protected override void set_ActiveBrowser(Browser value) { }

	protected void SetVisible(bool visible) { }

	protected void TextTyped(JSONNode args) { }

}

