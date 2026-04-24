namespace Spine;

public abstract class Attachment
{
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x10

	public private string Name
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	protected Attachment(string name) { }

	public abstract Attachment Copy() { }

	[CompilerGenerated]
	public string get_Name() { }

	[CompilerGenerated]
	private void set_Name(string value) { }

	public virtual string ToString() { }

}

