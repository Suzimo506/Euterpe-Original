namespace Steamworks;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class CallbackIdentityAttribute : Attribute
{
	[CompilerGenerated]
	private int <Identity>k__BackingField; //Field offset: 0x10

	public int Identity
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public CallbackIdentityAttribute(int callbackNum) { }

	[CompilerGenerated]
	public int get_Identity() { }

	[CompilerGenerated]
	public void set_Identity(int value) { }

}

