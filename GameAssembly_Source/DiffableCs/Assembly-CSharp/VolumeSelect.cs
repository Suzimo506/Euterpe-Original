//Type is in global namespace

public class VolumeSelect : UISelectManage
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public int index; //Field offset: 0x10
		public VolumeSelect <>4__this; //Field offset: 0x18

		public <>c__DisplayClass14_0() { }

		internal void <OnAwake>b__0(bool isOn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public Slider sliderDelegate; //Field offset: 0x10
		public VolumeSelect <>4__this; //Field offset: 0x18

		public <>c__DisplayClass18_0() { }

		internal void <UISliderInit>g__BtnCallback|0() { }

	}

	public AudioClip optionBgmClip; //Field offset: 0x110
	public Color highLight; //Field offset: 0x118
	public Color normal; //Field offset: 0x128
	[SerializeField]
	private UISetColor[] m_UiSetColors; //Field offset: 0x138
	[SerializeField]
	private List<Slider> m_SliderList; //Field offset: 0x140
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	private List<Toggle> m_BattleSfx; //Field offset: 0x148
	public GameObject notBuyCatTip; //Field offset: 0x150
	public Image notBuyCatTipImg; //Field offset: 0x158
	private bool m_IsFirstBuyCatTip; //Field offset: 0x160
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	private List<Toggle> m_TitleTgls; //Field offset: 0x168
	private GameObject m_LastSelect; //Field offset: 0x170

	private bool isBuyNekoSfx
	{
		private get { } //Length: 168
	}

	public VolumeSelect() { }

	public virtual GameObject DefaultSelectObj() { }

	private bool get_isBuyNekoSfx() { }

	private void InitBattleSfx() { }

	public virtual void OnAwake() { }

	private void OnBattleSfxToggle(int index, bool isOn) { }

	public virtual void OnDisablePnl() { }

	public virtual void OnEnablePnl() { }

	public virtual void OnInit() { }

	protected virtual void OnSelect(GameObject currentObj) { }

	public virtual List<GameObject> SetSelectableObj() { }

	private void SetSelectImage(GameObject currentObj) { }

	private void UISliderInit(Slider slider) { }

}

