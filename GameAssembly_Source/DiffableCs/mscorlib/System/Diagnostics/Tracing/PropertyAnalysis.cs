namespace System.Diagnostics.Tracing;

internal sealed class PropertyAnalysis
{
	internal readonly string name; //Field offset: 0x10
	internal readonly MethodInfo getterInfo; //Field offset: 0x18
	internal readonly TraceLoggingTypeInfo typeInfo; //Field offset: 0x20
	internal readonly EventFieldAttribute fieldAttribute; //Field offset: 0x28

	public PropertyAnalysis(string name, MethodInfo getterInfo, TraceLoggingTypeInfo typeInfo, EventFieldAttribute fieldAttribute) { }

}

