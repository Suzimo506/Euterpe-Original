namespace System.ComponentModel.Design.Serialization;

public sealed class InstanceDescriptor
{
	private MemberInfo member; //Field offset: 0x10
	private ICollection arguments; //Field offset: 0x18
	private bool isComplete; //Field offset: 0x20

	public InstanceDescriptor(MemberInfo member, ICollection arguments) { }

	public InstanceDescriptor(MemberInfo member, ICollection arguments, bool isComplete) { }

	public object Invoke() { }

}

