namespace System.Reflection;

[ClassInterface(/*Cpp2IL Warning: missing at least one required parameter*/)]
[ComDefaultInterface(/*Cpp2IL Warning: missing at least one required parameter*/)]
[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public abstract class MethodInfo : MethodBase, _MethodInfo
{

	public virtual MemberTypes MemberType
	{
		 get { } //Length: 6
	}

	public override Type ReturnType
	{
		 get { } //Length: 73
	}

	public abstract ICustomAttributeProvider ReturnTypeCustomAttributes
	{
		 get { } //Length: 0
	}

	protected MethodInfo() { }

	public override Delegate CreateDelegate(Type delegateType) { }

	public override Delegate CreateDelegate(Type delegateType, object target) { }

	public virtual bool Equals(object obj) { }

	public virtual MemberTypes get_MemberType() { }

	public override Type get_ReturnType() { }

	public abstract ICustomAttributeProvider get_ReturnTypeCustomAttributes() { }

	public abstract MethodInfo GetBaseDefinition() { }

	internal override MethodInfo GetBaseMethod() { }

	[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual Type[] GetGenericArguments() { }

	[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override MethodInfo GetGenericMethodDefinition() { }

	public virtual int GetHashCode() { }

	public override MethodInfo MakeGenericMethod(Type[] typeArguments) { }

	public static bool op_Equality(MethodInfo left, MethodInfo right) { }

	public static bool op_Inequality(MethodInfo left, MethodInfo right) { }

}

