namespace UnityEngine.Bindings;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[VisibleToOtherModules]
internal class NativePropertyAttribute : NativeMethodAttribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private TargetType <TargetType>k__BackingField; //Field offset: 0x20

	public TargetType TargetType
	{
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public NativePropertyAttribute() { }

	public NativePropertyAttribute(string name) { }

	public NativePropertyAttribute(string name, bool isFree, TargetType targetType) { }

	[CompilerGenerated]
	public void set_TargetType(TargetType value) { }

}

