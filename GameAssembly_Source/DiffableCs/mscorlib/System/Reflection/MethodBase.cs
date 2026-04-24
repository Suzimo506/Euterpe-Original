namespace System.Reflection;

[ClassInterface(/*Cpp2IL Warning: missing at least one required parameter*/)]
[ComDefaultInterface(/*Cpp2IL Warning: missing at least one required parameter*/)]
[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public abstract class MethodBase : MemberInfo, _MethodBase
{

	public abstract MethodAttributes Attributes
	{
		 get { } //Length: 0
	}

	public override CallingConventions CallingConvention
	{
		 get { } //Length: 6
	}

	public override bool ContainsGenericParameters
	{
		 get { } //Length: 3
	}

	public override bool IsAbstract
	{
		 get { } //Length: 33
	}

	public override bool IsAssembly
	{
		 get { } //Length: 33
	}

	[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override bool IsConstructor
	{
		 get { } //Length: 161
	}

	public override bool IsFamilyOrAssembly
	{
		 get { } //Length: 33
	}

	public override bool IsGenericMethod
	{
		 get { } //Length: 3
	}

	public override bool IsGenericMethodDefinition
	{
		 get { } //Length: 3
	}

	public override bool IsPrivate
	{
		 get { } //Length: 32
	}

	public override bool IsPublic
	{
		 get { } //Length: 33
	}

	public override bool IsSecurityCritical
	{
		 get { } //Length: 73
	}

	public override bool IsSpecialName
	{
		 get { } //Length: 33
	}

	public override bool IsStatic
	{
		 get { } //Length: 30
	}

	public override bool IsVirtual
	{
		 get { } //Length: 30
	}

	public abstract RuntimeMethodHandle MethodHandle
	{
		 get { } //Length: 0
	}

	protected MethodBase() { }

	internal static string ConstructParameters(Type[] parameterTypes, CallingConventions callingConvention, bool serialization) { }

	public virtual bool Equals(object obj) { }

	internal override string FormatNameAndSig(bool serialization) { }

	public abstract MethodAttributes get_Attributes() { }

	public override CallingConventions get_CallingConvention() { }

	public override bool get_ContainsGenericParameters() { }

	public override bool get_IsAbstract() { }

	public override bool get_IsAssembly() { }

	public override bool get_IsConstructor() { }

	public override bool get_IsFamilyOrAssembly() { }

	public override bool get_IsGenericMethod() { }

	public override bool get_IsGenericMethodDefinition() { }

	public override bool get_IsPrivate() { }

	public override bool get_IsPublic() { }

	public override bool get_IsSecurityCritical() { }

	public override bool get_IsSpecialName() { }

	public override bool get_IsStatic() { }

	public override bool get_IsVirtual() { }

	public abstract RuntimeMethodHandle get_MethodHandle() { }

	public static MethodBase GetCurrentMethod() { }

	[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override Type[] GetGenericArguments() { }

	public virtual int GetHashCode() { }

	public override MethodBody GetMethodBody() { }

	internal static MethodBody GetMethodBody(IntPtr handle) { }

	internal static MethodBody GetMethodBodyInternal(IntPtr handle) { }

	public static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle) { }

	private static MethodBase GetMethodFromHandleInternalType(IntPtr method_handle, IntPtr type_handle) { }

	internal static MethodBase GetMethodFromHandleInternalType_native(IntPtr method_handle, IntPtr type_handle, bool genericCheck) { }

	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle) { }

	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle, RuntimeTypeHandle reflectedType) { }

	public abstract MethodImplAttributes GetMethodImplementationFlags() { }

	public abstract ParameterInfo[] GetParameters() { }

	internal override int GetParametersCount() { }

	internal override ParameterInfo[] GetParametersInternal() { }

	internal override ParameterInfo[] GetParametersNoCopy() { }

	internal override Type[] GetParameterTypes() { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	public override object Invoke(object obj, Object[] parameters) { }

	public abstract object Invoke(object obj, BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture) { }

	public static bool op_Equality(MethodBase left, MethodBase right) { }

	public static bool op_Inequality(MethodBase left, MethodBase right) { }

}

