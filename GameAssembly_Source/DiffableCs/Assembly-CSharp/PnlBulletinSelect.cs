//Type is in global namespace

public class PnlBulletinSelect : UISelectManage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<InputKeyBinding> <>9__14_0; //Field offset: 0x8
		public static Action<InputKeyBinding> <>9__14_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <OnNsChangeBulletinContent>b__14_0(InputKeyBinding k) { }

		internal void <OnNsChangeBulletinContent>b__14_1(InputKeyBinding k) { }

	}

	public Transform tittleToggle; //Field offset: 0x110
	public GameObject scrollViewObj; //Field offset: 0x118
	public GameObject ScrollVertical; //Field offset: 0x120
	public Color yesColor; //Field offset: 0x128
	public Color noColor; //Field offset: 0x138
	public RectTransform content; //Field offset: 0x148
	private List<GameObject> m_NsBulletinContent; //Field offset: 0x150
	private List<Toggle> m_TittleToggle; //Field offset: 0x158
	private int m_ToggleIndex; //Field offset: 0x160
	public BulletinTitleScroller titleScroller; //Field offset: 0x168

	public PnlBulletinSelect() { }

	public virtual void OnDisablePnl() { }

	public virtual void OnInit() { }

	private void OnNsChangeBulletinContent(int last, int current) { }

	protected virtual void OnSelect(GameObject currentObj) { }

	public virtual List<GameObject> SetSelectableObj() { }

}

