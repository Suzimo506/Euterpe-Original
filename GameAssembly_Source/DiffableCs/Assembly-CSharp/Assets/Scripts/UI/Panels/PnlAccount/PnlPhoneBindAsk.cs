namespace Assets.Scripts.UI.Panels.PnlAccount;

public class PnlPhoneBindAsk : BaseMessageBox
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Int64, String> <>9__3_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <OnReplaceClicked>b__3_1(long c, string s) { }

	}

	private InputType m_CurType; //Field offset: 0xD8
	private string m_FinalSendTxt; //Field offset: 0xE0

	public PnlPhoneBindAsk() { }

	[CompilerGenerated]
	private void <OnReplaceClicked>b__3_0(JObject o) { }

	protected virtual void OnNoClicked() { }

	private void OnReplaceClicked() { }

	protected virtual void OnYesClicked() { }

	public void SetInputType(InputType inputType, string finalSendTxt) { }

}

