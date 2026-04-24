namespace Assets.Scripts.UI.Panels.PnlAccount;

public class PnlIdInput : BaseMessageBox
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public PnlIdInput <>4__this; //Field offset: 0x10
		public string playerName; //Field offset: 0x18

		public <>c__DisplayClass4_0() { }

		internal void <OnOkClicked>b__0(int code) { }

		internal void <OnOkClicked>b__1(long c, string e) { }

	}

	public InputField inputField; //Field offset: 0xD8
	public Button btnVerifying; //Field offset: 0xE0

	public PnlIdInput() { }

	protected virtual void OnNoClicked() { }

	private void OnOkClicked() { }

	private void SetVerifyingEnable(bool enable) { }

	public virtual void StartInit() { }

}

