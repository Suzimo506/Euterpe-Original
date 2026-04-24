//Type is in global namespace

public class CheckWelcome : BaseMessageBox
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<Tweener> <>9__15_1; //Field offset: 0x8
		public static Comparison<Tweener> <>9__17_0; //Field offset: 0x10
		public static Action<Tweener> <>9__17_2; //Field offset: 0x18
		public static Action<Tweener> <>9__18_0; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal int <InstanceWelcome>b__15_1(Tweener l, Tweener r) { }

		internal void <KillAllTwns>b__18_0(Tweener t) { }

		internal int <OnDisable>b__17_0(Tweener l, Tweener r) { }

		internal void <OnDisable>b__17_2(Tweener t) { }

	}

	public Image mask; //Field offset: 0xD8
	public GameObject welcome; //Field offset: 0xE0
	private CanvasScaler uiCanvas; //Field offset: 0xE8
	private List<Tweener> m_Twners; //Field offset: 0xF0
	private Vector3 m_OriginPos; //Field offset: 0xF8
	private GameObject m_CurrentWelcome; //Field offset: 0x108
	private float m_MatchWidthOrHeight; //Field offset: 0x110
	private GameObject[] m_WelcomeGameObjects; //Field offset: 0x118

	public CheckWelcome() { }

	[CompilerGenerated]
	private void <DisableWelcome>b__20_0() { }

	[CompilerGenerated]
	private void <InstanceWelcome>b__15_0() { }

	[CompilerGenerated]
	private void <OnDisable>b__17_1() { }

	[CompilerGenerated]
	private void <Show>b__14_0() { }

	public virtual void AwakeInit() { }

	public virtual void Destroy() { }

	private void DisableAllWelcome() { }

	private void DisableWelcome() { }

	private int GetWelcomeIndex() { }

	private void InstanceWelcome() { }

	private void KillAllTwns() { }

	protected virtual void OnCancelClicked() { }

	private void OnCytusHiddenClose() { }

	private void OnCytusTrigger() { }

	private void OnDisable() { }

	protected virtual void OnNoClicked() { }

	public virtual void Show() { }

}

