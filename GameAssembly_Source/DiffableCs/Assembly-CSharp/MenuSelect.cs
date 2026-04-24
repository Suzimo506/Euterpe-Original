//Type is in global namespace

public class MenuSelect : UISelectManage
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public int listIndex; //Field offset: 0x10
		public int binaryIndex; //Field offset: 0x14
		public MenuSelect <>4__this; //Field offset: 0x18

		public <>c__DisplayClass8_0() { }

		internal void <OnAwake>b__1(bool b) { }

	}

	[SerializeField]
	private Toggle[] m_PcOptions; //Field offset: 0x110
	[SerializeField]
	private Toggle[] m_NsOptions; //Field offset: 0x118
	[SerializeField]
	private Toggle[] m_MobileOptions; //Field offset: 0x120
	[SerializeField]
	private GameObject[] m_ActivePnls; //Field offset: 0x128
	private Toggle[] m_Panels; //Field offset: 0x130
	private Dictionary<Toggle, GameObject> m_Pnls; //Field offset: 0x138

	public MenuSelect() { }

	[CompilerGenerated]
	private void <OnAwake>b__8_0(bool b) { }

	public virtual bool IsThisUiManager() { }

	public virtual void OnAwake() { }

	public virtual void OnDisablePnl() { }

	public virtual void OnEnablePnl() { }

	private void OnToggleChanged(int listIndex, int index, bool isOn) { }

	public void SaveData() { }

	public void SetOn(MenuType type) { }

}

