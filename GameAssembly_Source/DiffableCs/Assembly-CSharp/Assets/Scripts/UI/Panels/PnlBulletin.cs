namespace Assets.Scripts.UI.Panels;

public class PnlBulletin : BaseMessageBox
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<Bulletin> <>9__10_2; //Field offset: 0x8
		public static Func<Boolean> <>9__10_1; //Field offset: 0x10
		public static Action <>9__11_0; //Field offset: 0x18
		public static Func<Boolean> <>9__11_1; //Field offset: 0x20
		public static Func<Boolean> <>9__11_2; //Field offset: 0x28
		public static Action<Texture2D> <>9__15_0; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal void <AwakeInit>b__11_0() { }

		internal bool <AwakeInit>b__11_1() { }

		internal bool <AwakeInit>b__11_2() { }

		internal bool <Popup>b__10_1() { }

		internal bool <Popup>b__10_2(Bulletin b) { }

		internal void <RefreshUI>b__15_0(Texture2D t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public Bulletin bulletin; //Field offset: 0x10
		public Component goImg; //Field offset: 0x18
		public Toggle tgl; //Field offset: 0x20
		public PnlBulletin <>4__this; //Field offset: 0x28
		public Action<Texture2D> <>9__2; //Field offset: 0x30

		public <>c__DisplayClass15_0() { }

		internal void <RefreshUI>b__1(bool isOn) { }

		internal void <RefreshUI>b__2(Texture2D t) { }

	}

	private static bool m_ShowFlag; //Field offset: 0x0
	public YlyRichText txtContent; //Field offset: 0xD8
	public Image image; //Field offset: 0xE0
	public GameObject tglBulletin; //Field offset: 0xE8
	public Transform content; //Field offset: 0xF0
	public ToggleGroup toggleGroup; //Field offset: 0xF8
	private readonly List<Toggle> m_Tgls; //Field offset: 0x100
	private bool m_LanguageChangDirty; //Field offset: 0x108

	private static PnlBulletin() { }

	public PnlBulletin() { }

	[CompilerGenerated]
	private void <Popup>b__10_0() { }

	public virtual void AwakeInit() { }

	public virtual void Destroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnShowPnlBulletin() { }

	public void Popup() { }

	public void RefreshUI() { }

	private void SetDirty(int index) { }

}

