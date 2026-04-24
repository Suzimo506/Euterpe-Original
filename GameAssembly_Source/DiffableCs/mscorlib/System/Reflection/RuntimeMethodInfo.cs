namespace System.Reflection;

internal abstract class RuntimeMethodInfo : MethodInfo, ISerializable
{

	internal BindingFlags BindingFlags
	{
		internal get { } //Length: 3
	}

	public virtual Module Module
	{
		 get { } //Length: 202
	}

	private RuntimeType ReflectedTypeInternal
	{
		private get { } //Length: 135
	}

	protected RuntimeMethodInfo() { }

	public virtual Delegate CreateDelegate(Type delegateType) { }

	public virtual Delegate CreateDelegate(Type delegateType, object target) { }

	internal virtual string FormatNameAndSig(bool serialization) { }

	internal BindingFlags get_BindingFlags() { }

	public virtual Module get_Module() { }

	private RuntimeType get_ReflectedTypeInternal() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal RuntimeModule GetRuntimeModule() { }

	internal string SerializationToString() { }

	public virtual string ToString() { }

}

