namespace System.Diagnostics.Tracing;

internal sealed class TypeAnalysis
{
	internal readonly PropertyAnalysis[] properties; //Field offset: 0x10
	internal readonly string name; //Field offset: 0x18
	internal readonly EventKeywords keywords; //Field offset: 0x20
	internal readonly EventLevel level; //Field offset: 0x28
	internal readonly EventOpcode opcode; //Field offset: 0x2C
	internal readonly EventTags tags; //Field offset: 0x30

	public TypeAnalysis(Type dataType, EventDataAttribute eventAttrib, List<Type> recursionCheck) { }

}

