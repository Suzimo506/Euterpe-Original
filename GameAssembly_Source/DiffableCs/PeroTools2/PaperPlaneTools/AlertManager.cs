namespace PaperPlaneTools;

public class AlertManager
{
	private static AlertManager instance; //Field offset: 0x0
	private IAlertPlatformAdapter currentAdapter; //Field offset: 0x10
	private Alert currentAlert; //Field offset: 0x18
	private List<Alert> queue; //Field offset: 0x20
	[CompilerGenerated]
	private Func<IAlertPlatformAdapter> <AlertFactory>k__BackingField; //Field offset: 0x28

	public Func<IAlertPlatformAdapter> AlertFactory
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public static AlertManager Instance
	{
		 get { } //Length: 212
	}

	private AlertManager() { }

	private IAlertPlatformAdapter CreateAdapter() { }

	public void Dismiss(Alert alert) { }

	[CompilerGenerated]
	public Func<IAlertPlatformAdapter> get_AlertFactory() { }

	public static AlertManager get_Instance() { }

	public void HandleEvent(string eventName, string value) { }

	private void OnDismiss() { }

	[CompilerGenerated]
	public void set_AlertFactory(Func<IAlertPlatformAdapter> value) { }

	public void Show(Alert alert) { }

	private void ShowNext() { }

}

