namespace Sirenix.Serialization.Utilities;

internal sealed class MemberAliasMethodInfo : MethodInfo
{
	private const string FAKE_NAME_SEPARATOR_STRING = "+"; //Field offset: 0x0
	private MethodInfo aliasedMethod; //Field offset: 0x10
	private string mangledName; //Field offset: 0x18

	public MethodInfo AliasedMethod
	{
		 get { } //Length: 5
	}

	public virtual MethodAttributes Attributes
	{
		 get { } //Length: 39
	}

	public virtual Type DeclaringType
	{
		 get { } //Length: 39
	}

	public virtual RuntimeMethodHandle MethodHandle
	{
		 get { } //Length: 39
	}

	public virtual string Name
	{
		 get { } //Length: 5
	}

	public virtual Type ReflectedType
	{
		 get { } //Length: 39
	}

	public virtual Type ReturnType
	{
		 get { } //Length: 39
	}

	public virtual ICustomAttributeProvider ReturnTypeCustomAttributes
	{
		 get { } //Length: 39
	}

	public MemberAliasMethodInfo(MethodInfo method, string namePrefix) { }

	public MemberAliasMethodInfo(MethodInfo method, string namePrefix, string separatorString) { }

	public MethodInfo get_AliasedMethod() { }

	public virtual MethodAttributes get_Attributes() { }

	public virtual Type get_DeclaringType() { }

	public virtual RuntimeMethodHandle get_MethodHandle() { }

	public virtual string get_Name() { }

	public virtual Type get_ReflectedType() { }

	public virtual Type get_ReturnType() { }

	public virtual ICustomAttributeProvider get_ReturnTypeCustomAttributes() { }

	public virtual MethodInfo GetBaseDefinition() { }

	public virtual Object[] GetCustomAttributes(bool inherit) { }

	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public virtual MethodImplAttributes GetMethodImplementationFlags() { }

	public virtual ParameterInfo[] GetParameters() { }

	public virtual object Invoke(object obj, BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture) { }

	public virtual bool IsDefined(Type attributeType, bool inherit) { }

}

