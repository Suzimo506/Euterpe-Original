namespace PaperPlaneTools;

public class AlertUnityUIAdapter : MonoBehaviour, IAlertPlatformAdapter
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<Entry> <>9__9_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <PaperPlaneTools.IAlertPlatformAdapter.Show>b__9_0(Entry foo) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public AlertUnityUIAdapter <>4__this; //Field offset: 0x10
		public AlertButton alertButton; //Field offset: 0x18

		public <>c__DisplayClass11_0() { }

		internal void <SetButton>b__0() { }

		internal void <SetButton>b__1() { }

	}

	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Text titleText; //Field offset: 0x18
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Text messageText; //Field offset: 0x20
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Button positiveButton; //Field offset: 0x28
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Button neutralButton; //Field offset: 0x30
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Button negativeButton; //Field offset: 0x38
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public GameObject dismissPanel; //Field offset: 0x40
	private Action onDismiss; //Field offset: 0x48

	public AlertUnityUIAdapter() { }

	[CompilerGenerated]
	private void <PaperPlaneTools.IAlertPlatformAdapter.Show>b__9_1(BaseEventData eventData) { }

	private override void PaperPlaneTools.IAlertPlatformAdapter.Dismiss() { }

	private override void PaperPlaneTools.IAlertPlatformAdapter.HandleEvent(string name, string value) { }

	private override void PaperPlaneTools.IAlertPlatformAdapter.SetOnDismiss(Action action) { }

	private override void PaperPlaneTools.IAlertPlatformAdapter.Show(Alert alert) { }

	private void SetButton(Button uiButton, AlertButton alertButton) { }

}

