namespace Assets.Scripts.Structs;

public class ToggleSettingGroup
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public Action<Int32, Boolean> tglCallback; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_1
	{
		public int delegateIndex; //Field offset: 0x10
		public <>c__DisplayClass3_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass3_1() { }

		internal void <SetCallback>b__0(bool enable) { }

	}

	[SerializeField]
	private ToggleGroup m_ToggleGroup; //Field offset: 0x10
	[SerializeField]
	private List<Toggle> m_Toggles; //Field offset: 0x18

	public ToggleSettingGroup() { }

	public bool GetCheck(int index) { }

	public void Init() { }

	public void SetCallback(Action<Int32, Boolean> tglCallback) { }

	public void SetCheck(int index, bool isOn, bool sendEvent) { }

}

