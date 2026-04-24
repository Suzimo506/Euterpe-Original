namespace xdsdk.Unity;

[DisallowMultipleComponent]
public class SDKManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__19_1; //Field offset: 0x8
		public static Action <>9__19_0; //Field offset: 0x10
		public static Action <>9__21_1; //Field offset: 0x18
		public static Action <>9__21_0; //Field offset: 0x20
		public static Action <>9__23_0; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal void <CreateContainer>b__23_0() { }

		internal void <ShowDialog>b__19_0() { }

		internal void <ShowDialog>b__19_1() { }

		internal void <ShowLoading>b__21_0() { }

		internal void <ShowLoading>b__21_1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public UIElement element; //Field offset: 0x10
		public SDKManager <>4__this; //Field offset: 0x18

		public <>c__DisplayClass20_0() { }

		internal void <DismissDialog>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public UIElement element; //Field offset: 0x10
		public SDKManager <>4__this; //Field offset: 0x18

		public <>c__DisplayClass22_0() { }

		internal void <DismissLoading>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public UIElement lastElement; //Field offset: 0x0

		public <>c__DisplayClass25_0`1() { }

		internal void <PushUIElement>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public UIElement element; //Field offset: 0x10
		public UIElement lastElement; //Field offset: 0x18
		public SDKManager <>4__this; //Field offset: 0x20

		public <>c__DisplayClass26_0() { }

		internal void <PopUIElement>b__0() { }

	}

	public static readonly int RESULT_FAILED; //Field offset: 0x0
	public static readonly int RESULT_SUCCESS; //Field offset: 0x4
	public static readonly int RESULT_BACK; //Field offset: 0x8
	public static readonly int RESULT_CLOSE; //Field offset: 0xC
	private GameObject containerObj; //Field offset: 0x18
	private GameObject dialogObj; //Field offset: 0x20
	private GameObject dialogContentObj; //Field offset: 0x28
	private GameObject loadingObj; //Field offset: 0x30
	private GameObject loadingContentObj; //Field offset: 0x38
	private readonly List<UIElement> uiElements; //Field offset: 0x40

	private static SDKManager() { }

	public SDKManager() { }

	[CompilerGenerated]
	private void <DestoryContainer>b__24_0() { }

	[CompilerGenerated]
	private void <DismissDialog>b__20_1() { }

	[CompilerGenerated]
	private void <DismissDialog>b__20_2() { }

	[CompilerGenerated]
	private void <DismissLoading>b__22_1() { }

	[CompilerGenerated]
	private void <DismissLoading>b__22_2() { }

	[CompilerGenerated]
	private void <PopAll>b__13_0() { }

	private void Awake() { }

	private void CreateContainer() { }

	private void DestoryContainer() { }

	public void DismissDialog() { }

	public void DismissLoading() { }

	public void Pop(string targetName) { }

	public void Pop() { }

	public void PopAll() { }

	private void PopUIElement(string targetName) { }

	private void PushUIElement(string prefabName, Dictionary<String, Object> extra, Action<Int32, Object> callback) { }

	public void ShowDialog(Dictionary<String, Object> extra, Action<Int32, Object> callback) { }

	public void ShowLoading() { }

	public void ShowLogin(Dictionary<String, Object> configs, Action<Int32, Object> callback) { }

	public void ShowPlatformLogin(Dictionary<String, Object> configs, Action<Int32, Object> callback) { }

	public void ShowRealName(Dictionary<String, Object> configs, Action<Int32, Object> callback) { }

	public void ShowTwoFactorAuth(Dictionary<String, Object> configs, Action<Int32, Object> callback) { }

	public void ShowWebView(Dictionary<String, Object> configs, Action<Int32, Object> callback) { }

}

