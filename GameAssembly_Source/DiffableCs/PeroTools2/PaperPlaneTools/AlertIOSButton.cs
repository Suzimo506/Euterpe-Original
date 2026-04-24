namespace PaperPlaneTools;

public class AlertIOSButton
{
	internal enum Type
	{
		Default = 0,
		Cancel = 1,
		Destructive = 2,
	}

	[CompilerGenerated]
	private Type <WhichButton>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Title>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Action <Handler>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <IsPreferable>k__BackingField; //Field offset: 0x28

	public private Action Handler
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private bool IsPreferable
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private string Title
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private Type WhichButton
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public AlertIOSButton(Type whichButton, string title, Action handler, bool isPreferable) { }

	[CompilerGenerated]
	public Action get_Handler() { }

	[CompilerGenerated]
	public bool get_IsPreferable() { }

	[CompilerGenerated]
	public string get_Title() { }

	[CompilerGenerated]
	public Type get_WhichButton() { }

	[CompilerGenerated]
	private void set_Handler(Action value) { }

	[CompilerGenerated]
	private void set_IsPreferable(bool value) { }

	[CompilerGenerated]
	private void set_Title(string value) { }

	[CompilerGenerated]
	private void set_WhichButton(Type value) { }

}

