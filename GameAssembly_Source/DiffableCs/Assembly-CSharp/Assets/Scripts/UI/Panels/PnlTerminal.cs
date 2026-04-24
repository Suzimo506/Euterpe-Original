namespace Assets.Scripts.UI.Panels;

public class PnlTerminal : BaseMessageBox
{
	public Button btnVerifying; //Field offset: 0xD8
	private Coroutine m_Coroutine; //Field offset: 0xE0
	[SerializeField]
	private InputField m_InputField; //Field offset: 0xE8

	public PnlTerminal() { }

	[CompilerGenerated]
	private void <Exchange>b__5_0(DownloadHandler t) { }

	[CompilerGenerated]
	private void <Exchange>b__5_1(long c, string r) { }

	[CompilerGenerated]
	private void <Exchange>b__5_2() { }

	private void Exchange(string code) { }

	protected virtual void OnNoClicked() { }

	protected virtual void OnYesClicked() { }

}

