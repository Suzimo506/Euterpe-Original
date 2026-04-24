namespace System.Reflection;

[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public abstract class TypeInfo : Type, IReflectableType
{

	public override IEnumerable<FieldInfo> DeclaredFields
	{
		 get { } //Length: 22
	}

	public override IEnumerable<MethodInfo> DeclaredMethods
	{
		 get { } //Length: 22
	}

	public override IEnumerable<Type> ImplementedInterfaces
	{
		 get { } //Length: 17
	}

	[FriendAccessAllowed]
	internal TypeInfo() { }

	public override IEnumerable<FieldInfo> get_DeclaredFields() { }

	public override IEnumerable<MethodInfo> get_DeclaredMethods() { }

	public override IEnumerable<Type> get_ImplementedInterfaces() { }

	private override TypeInfo System.Reflection.IReflectableType.GetTypeInfo() { }

}

