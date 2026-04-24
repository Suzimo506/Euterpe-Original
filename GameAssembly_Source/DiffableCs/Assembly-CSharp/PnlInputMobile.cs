//Type is in global namespace

public class PnlInputMobile : UISelectManage
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public KeyValuePair<Toggle, MobileInputType> tgl; //Field offset: 0x10
		public PnlInputMobile <>4__this; //Field offset: 0x20

		public <>c__DisplayClass7_0() { }

		internal void <Awake>b__0(bool state) { }

	}

	public AudioClip clickSfx; //Field offset: 0x110
	private bool m_IsLeftRight; //Field offset: 0x118
	private bool m_IsTouchReverse; //Field offset: 0x119
	private bool m_IsAutoFever; //Field offset: 0x11A
	public Dictionary<Toggle, MobileInputType> bindToggles; //Field offset: 0x120
	public List<GameObject> normalActives; //Field offset: 0x128
	public List<GameObject> reverseActives; //Field offset: 0x130

	public PnlInputMobile() { }

	private void Awake() { }

	public virtual void OnDisablePnl() { }

	private void SetAutoFever(bool autoFever) { }

	private void SetLeftRight(bool leftRight) { }

	private void SetTouchReverse(bool reverse) { }

	private void ToggleHandler(Toggle tgl, bool state) { }

}

