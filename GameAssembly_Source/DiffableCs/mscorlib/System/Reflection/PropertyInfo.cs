namespace System.Reflection;

[ClassInterface(/*Cpp2IL Warning: missing at least one required parameter*/)]
[ComDefaultInterface(/*Cpp2IL Warning: missing at least one required parameter*/)]
[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public abstract class PropertyInfo : MemberInfo, _PropertyInfo
{

	public abstract PropertyAttributes Attributes
	{
		 get { } //Length: 0
	}

	public abstract bool CanRead
	{
		 get { } //Length: 0
	}

	public abstract bool CanWrite
	{
		 get { } //Length: 0
	}

	public override MethodInfo GetMethod
	{
		 get { } //Length: 19
	}

	public virtual MemberTypes MemberType
	{
		 get { } //Length: 6
	}

	public abstract Type PropertyType
	{
		 get { } //Length: 0
	}

	protected PropertyInfo() { }

	private static NotImplementedException CreateNIE() { }

	public virtual bool Equals(object obj) { }

	public abstract PropertyAttributes get_Attributes() { }

	public abstract bool get_CanRead() { }

	public abstract bool get_CanWrite() { }

	public override MethodInfo get_GetMethod() { }

	public virtual MemberTypes get_MemberType() { }

	public abstract Type get_PropertyType() { }

	public abstract MethodInfo[] GetAccessors(bool nonPublic) { }

	public override object GetConstantValue() { }

	public override MethodInfo GetGetMethod() { }

	public abstract MethodInfo GetGetMethod(bool nonPublic) { }

	public virtual int GetHashCode() { }

	public abstract ParameterInfo[] GetIndexParameters() { }

	public override Type[] GetOptionalCustomModifiers() { }

	internal static PropertyInfo GetPropertyFromHandle(RuntimePropertyHandle handle, RuntimeTypeHandle reflectedType) { }

	public override object GetRawConstantValue() { }

	public override Type[] GetRequiredCustomModifiers() { }

	public abstract MethodInfo GetSetMethod(bool nonPublic) { }

	public override MethodInfo GetSetMethod() { }

	public abstract object GetValue(object obj, BindingFlags invokeAttr, Binder binder, Object[] index, CultureInfo culture) { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	public override object GetValue(object obj, Object[] index) { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	public object GetValue(object obj) { }

	private static PropertyInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle) { }

	public static bool op_Equality(PropertyInfo left, PropertyInfo right) { }

	public static bool op_Inequality(PropertyInfo left, PropertyInfo right) { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	public void SetValue(object obj, object value) { }

	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, Object[] index, CultureInfo culture) { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	public override void SetValue(object obj, object value, Object[] index) { }

}

