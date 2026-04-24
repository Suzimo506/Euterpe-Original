namespace System.Reflection;

internal class MonoCMethod : RuntimeConstructorInfo
{
	internal IntPtr mhandle; //Field offset: 0x10
	private string name; //Field offset: 0x18
	private Type reftype; //Field offset: 0x20

	public virtual MethodAttributes Attributes
	{
		 get { } //Length: 9
	}

	public virtual CallingConventions CallingConvention
	{
		 get { } //Length: 40
	}

	public virtual bool ContainsGenericParameters
	{
		 get { } //Length: 54
	}

	public virtual Type DeclaringType
	{
		 get { } //Length: 41
	}

	public virtual bool IsSecurityCritical
	{
		 get { } //Length: 3
	}

	public virtual RuntimeMethodHandle MethodHandle
	{
		 get { } //Length: 5
	}

	public virtual string Name
	{
		 get { } //Length: 14
	}

	public virtual Type ReflectedType
	{
		 get { } //Length: 5
	}

	public MonoCMethod() { }

	private object DoInvoke(object obj, BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture) { }

	public virtual MethodAttributes get_Attributes() { }

	public virtual CallingConventions get_CallingConvention() { }

	public virtual bool get_ContainsGenericParameters() { }

	private static int get_core_clr_security_level() { }

	public virtual Type get_DeclaringType() { }

	public virtual bool get_IsSecurityCritical() { }

	public virtual RuntimeMethodHandle get_MethodHandle() { }

	public virtual string get_Name() { }

	public virtual Type get_ReflectedType() { }

	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public virtual Object[] GetCustomAttributes(bool inherit) { }

	public virtual IList<CustomAttributeData> GetCustomAttributesData() { }

	public virtual MethodBody GetMethodBody() { }

	public virtual MethodImplAttributes GetMethodImplementationFlags() { }

	public virtual ParameterInfo[] GetParameters() { }

	internal virtual int GetParametersCount() { }

	internal virtual ParameterInfo[] GetParametersInternal() { }

	public object InternalInvoke(object obj, Object[] parameters) { }

	internal object InternalInvoke(object obj, Object[] parameters, out Exception exc) { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	public virtual object Invoke(BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture) { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	public virtual object Invoke(object obj, BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture) { }

	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	public virtual string ToString() { }

}

