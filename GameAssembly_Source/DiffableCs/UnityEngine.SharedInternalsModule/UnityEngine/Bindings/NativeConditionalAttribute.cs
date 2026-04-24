namespace UnityEngine.Bindings;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[VisibleToOtherModules]
internal class NativeConditionalAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private string <Condition>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private string <StubReturnStatement>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <Enabled>k__BackingField; //Field offset: 0x20

	public string Condition
	{
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public bool Enabled
	{
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public string StubReturnStatement
	{
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public NativeConditionalAttribute(string condition) { }

	public NativeConditionalAttribute(string condition, string stubReturnStatement) { }

	[CompilerGenerated]
	public void set_Condition(string value) { }

	[CompilerGenerated]
	public void set_Enabled(bool value) { }

	[CompilerGenerated]
	public void set_StubReturnStatement(string value) { }

}

