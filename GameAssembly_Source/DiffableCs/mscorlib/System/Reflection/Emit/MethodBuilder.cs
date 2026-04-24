namespace System.Reflection.Emit;

public abstract class MethodBuilder : MethodInfo
{

	public virtual MethodAttributes Attributes
	{
		 get { } //Length: 73
	}

	public virtual Type DeclaringType
	{
		 get { } //Length: 73
	}

	public virtual RuntimeMethodHandle MethodHandle
	{
		 get { } //Length: 43
	}

	public virtual string Name
	{
		 get { } //Length: 73
	}

	public virtual Type ReflectedType
	{
		 get { } //Length: 43
	}

	public virtual ICustomAttributeProvider ReturnTypeCustomAttributes
	{
		 get { } //Length: 43
	}

	public virtual MethodAttributes get_Attributes() { }

	public virtual Type get_DeclaringType() { }

	public virtual RuntimeMethodHandle get_MethodHandle() { }

	public virtual string get_Name() { }

	public virtual Type get_ReflectedType() { }

	public virtual ICustomAttributeProvider get_ReturnTypeCustomAttributes() { }

	public virtual MethodInfo GetBaseDefinition() { }

	public virtual Object[] GetCustomAttributes(bool inherit) { }

	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public virtual MethodImplAttributes GetMethodImplementationFlags() { }

	public virtual ParameterInfo[] GetParameters() { }

	public virtual object Invoke(object obj, BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture) { }

	public virtual bool IsDefined(Type attributeType, bool inherit) { }

}

