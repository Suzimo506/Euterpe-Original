namespace PaperPlaneTools;

public class Alert
{
	internal enum ButtonType
	{
		Positive = 0,
		Negative = 1,
		Neutral = 2,
	}

	[CompilerGenerated]
	private string <Title>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Message>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private AlertButton <PositiveButton>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private AlertButton <NegativeButton>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private AlertButton <NeutralButton>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private List<Object> <Options>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private Action <OnDismiss>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private IAlertPlatformAdapter <Adapter>k__BackingField; //Field offset: 0x48

	public private IAlertPlatformAdapter Adapter
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private string Message
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private AlertButton NegativeButton
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private AlertButton NeutralButton
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private Action OnDismiss
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private List<Object> Options
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private AlertButton PositiveButton
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private string Title
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public Alert(string title = null, string message = null) { }

	public Alert AddOptions(object opt) { }

	public void Dismiss() { }

	[CompilerGenerated]
	public IAlertPlatformAdapter get_Adapter() { }

	[CompilerGenerated]
	public string get_Message() { }

	[CompilerGenerated]
	public AlertButton get_NegativeButton() { }

	[CompilerGenerated]
	public AlertButton get_NeutralButton() { }

	[CompilerGenerated]
	public Action get_OnDismiss() { }

	[CompilerGenerated]
	public List<Object> get_Options() { }

	[CompilerGenerated]
	public AlertButton get_PositiveButton() { }

	[CompilerGenerated]
	public string get_Title() { }

	[CompilerGenerated]
	private void set_Adapter(IAlertPlatformAdapter value) { }

	[CompilerGenerated]
	private void set_Message(string value) { }

	[CompilerGenerated]
	private void set_NegativeButton(AlertButton value) { }

	[CompilerGenerated]
	private void set_NeutralButton(AlertButton value) { }

	[CompilerGenerated]
	private void set_OnDismiss(Action value) { }

	[CompilerGenerated]
	private void set_Options(List<Object> value) { }

	[CompilerGenerated]
	private void set_PositiveButton(AlertButton value) { }

	[CompilerGenerated]
	private void set_Title(string value) { }

	public Alert SetAdapter(IAlertPlatformAdapter adaper) { }

	public Alert SetMessage(string title) { }

	public Alert SetNegativeButton(string title, Action handler = null) { }

	public Alert SetNeutralButton(string title, Action handler = null) { }

	public Alert SetOnDismiss(Action handler) { }

	public Alert SetOptions(List<Object> options) { }

	public Alert SetPositiveButton(string title, Action handler = null) { }

	public Alert SetTitle(string title) { }

	public void Show() { }

}

