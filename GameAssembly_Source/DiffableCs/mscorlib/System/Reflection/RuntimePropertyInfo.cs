namespace System.Reflection;

internal abstract class RuntimePropertyInfo : PropertyInfo, ISerializable
{

	internal BindingFlags BindingFlags
	{
		internal get { } //Length: 3
	}

	public virtual Module Module
	{
		 get { } //Length: 148
	}

	private RuntimeType ReflectedTypeInternal
	{
		private get { } //Length: 135
	}

	protected RuntimePropertyInfo() { }

	private string FormatNameAndSig(bool serialization) { }

	internal BindingFlags get_BindingFlags() { }

	public virtual Module get_Module() { }

	private RuntimeType get_ReflectedTypeInternal() { }

	internal RuntimeType GetDeclaringTypeInternal() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal RuntimeModule GetRuntimeModule() { }

	internal string SerializationToString() { }

	public virtual string ToString() { }

}

