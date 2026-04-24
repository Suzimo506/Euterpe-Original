namespace Newtonsoft.Json.Serialization;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ErrorContext
{
	[CompilerGenerated]
	private bool <Traced>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Exception <Error>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private readonly object <OriginalObject>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private readonly object <Member>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly string <Path>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private bool <Handled>k__BackingField; //Field offset: 0x38

	public Exception Error
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool Handled
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal bool Traced
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	internal ErrorContext(object originalObject, object member, string path, Exception error) { }

	[CompilerGenerated]
	public Exception get_Error() { }

	[CompilerGenerated]
	public bool get_Handled() { }

	[CompilerGenerated]
	internal bool get_Traced() { }

	[CompilerGenerated]
	internal void set_Traced(bool value) { }

}

