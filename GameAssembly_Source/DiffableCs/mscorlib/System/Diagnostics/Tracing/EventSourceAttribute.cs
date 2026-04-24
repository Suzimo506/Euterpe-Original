namespace System.Diagnostics.Tracing;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class EventSourceAttribute : Attribute
{
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Guid>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <LocalizationResources>k__BackingField; //Field offset: 0x20

	public string Guid
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public string LocalizationResources
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string Name
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public EventSourceAttribute() { }

	[CompilerGenerated]
	public string get_Guid() { }

	[CompilerGenerated]
	public string get_LocalizationResources() { }

	[CompilerGenerated]
	public string get_Name() { }

	[CompilerGenerated]
	public void set_Guid(string value) { }

	[CompilerGenerated]
	public void set_Name(string value) { }

}

