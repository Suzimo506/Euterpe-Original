namespace System.Reflection;

[ClassInterface(/*Cpp2IL Warning: missing at least one required parameter*/)]
[ComDefaultInterface(/*Cpp2IL Warning: missing at least one required parameter*/)]
[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class MonoModule : RuntimeModule
{

	public virtual Assembly Assembly
	{
		 get { } //Length: 5
	}

	public virtual Guid ModuleVersionId
	{
		 get { } //Length: 45
	}

	public virtual string ScopeName
	{
		 get { } //Length: 5
	}

	public MonoModule() { }

	public virtual Assembly get_Assembly() { }

	public virtual Guid get_ModuleVersionId() { }

	public virtual string get_ScopeName() { }

	public virtual Object[] GetCustomAttributes(bool inherit) { }

	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal RuntimeAssembly GetRuntimeAssembly() { }

	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	public virtual bool IsResource() { }

}

