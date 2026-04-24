namespace Sirenix.Utilities;

public static class EmitUtilities
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public FieldInfo fieldInfo; //Field offset: 0x0

		public <>c__DisplayClass10_0`1() { }

		internal void <CreateWeakInstanceFieldSetter>b__0(ref object classInstance, FieldType value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public FieldInfo fieldInfo; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal void <CreateWeakInstanceFieldSetter>b__0(ref object classInstance, object value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public PropertyInfo propertyInfo; //Field offset: 0x10

		public <>c__DisplayClass12_0() { }

		internal object <CreateWeakInstancePropertyGetter>b__0(ref object classInstance) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public PropertyInfo propertyInfo; //Field offset: 0x10

		public <>c__DisplayClass13_0() { }

		internal void <CreateWeakInstancePropertySetter>b__0(ref object classInstance, object value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public PropertyInfo propertyInfo; //Field offset: 0x0

		public <>c__DisplayClass14_0`1() { }

		internal void <CreateStaticPropertySetter>b__0(PropType value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public PropertyInfo propertyInfo; //Field offset: 0x0

		public <>c__DisplayClass15_0`1() { }

		internal PropType <CreateStaticPropertyGetter>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public PropertyInfo propertyInfo; //Field offset: 0x0

		public <>c__DisplayClass16_0`2() { }

		internal void <CreateInstancePropertySetter>b__0(ref InstanceType classInstance, PropType value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public PropertyInfo propertyInfo; //Field offset: 0x0

		public <>c__DisplayClass17_0`2() { }

		internal PropType <CreateInstancePropertyGetter>b__0(ref InstanceType classInstance) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public FieldType value; //Field offset: 0x0

		public <>c__DisplayClass2_0`1() { }

		internal FieldType <CreateStaticFieldGetter>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_1
	{
		public FieldInfo fieldInfo; //Field offset: 0x0

		public <>c__DisplayClass2_1`1() { }

		internal FieldType <CreateStaticFieldGetter>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public MethodInfo methodInfo; //Field offset: 0x0

		public <>c__DisplayClass20_0`1() { }

		internal void <CreateWeakInstanceMethodCaller>b__0(object classInstance, TArg1 arg) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public MethodInfo methodInfo; //Field offset: 0x10

		public <>c__DisplayClass21_0() { }

		internal void <CreateWeakInstanceMethodCaller>b__0(object classInstance) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public MethodInfo methodInfo; //Field offset: 0x0

		public <>c__DisplayClass22_0`2() { }

		internal TResult <CreateWeakInstanceMethodCaller>b__0(object classInstance, TArg1 arg1) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public MethodInfo methodInfo; //Field offset: 0x0

		public <>c__DisplayClass23_0`1() { }

		internal TResult <CreateWeakInstanceMethodCallerFunc>b__0(object classInstance) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public MethodInfo methodInfo; //Field offset: 0x0

		public <>c__DisplayClass24_0`2() { }

		internal TResult <CreateWeakInstanceMethodCallerFunc>b__0(object classInstance, TArg arg) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public FieldInfo fieldInfo; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal object <CreateWeakStaticFieldGetter>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public FieldInfo fieldInfo; //Field offset: 0x0

		public <>c__DisplayClass4_0`1() { }

		internal void <CreateStaticFieldSetter>b__0(FieldType value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public FieldInfo fieldInfo; //Field offset: 0x10

		public <>c__DisplayClass5_0() { }

		internal void <CreateWeakStaticFieldSetter>b__0(object value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public FieldInfo fieldInfo; //Field offset: 0x0

		public <>c__DisplayClass6_0`2() { }

		internal FieldType <CreateInstanceFieldGetter>b__0(ref InstanceType classInstance) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public FieldInfo fieldInfo; //Field offset: 0x0

		public <>c__DisplayClass7_0`1() { }

		internal FieldType <CreateWeakInstanceFieldGetter>b__0(ref object classInstance) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public FieldInfo fieldInfo; //Field offset: 0x10

		public <>c__DisplayClass8_0() { }

		internal object <CreateWeakInstanceFieldGetter>b__0(ref object classInstance) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public FieldInfo fieldInfo; //Field offset: 0x0

		public <>c__DisplayClass9_0`2() { }

		internal void <CreateInstanceFieldSetter>b__0(ref InstanceType classInstance, FieldType value) { }

	}


	public static bool CanEmit
	{
		 get { } //Length: 3
	}

	public static ValueGetter<InstanceType, FieldType> CreateInstanceFieldGetter(FieldInfo fieldInfo) { }

	public static ValueSetter<InstanceType, FieldType> CreateInstanceFieldSetter(FieldInfo fieldInfo) { }

	public static Action<InstanceType, Arg1> CreateInstanceMethodCaller(MethodInfo methodInfo) { }

	public static Action<InstanceType> CreateInstanceMethodCaller(MethodInfo methodInfo) { }

	public static ValueGetter<InstanceType, PropType> CreateInstancePropertyGetter(PropertyInfo propertyInfo) { }

	public static ValueSetter<InstanceType, PropType> CreateInstancePropertySetter(PropertyInfo propertyInfo) { }

	public static Func<InstanceType, ReturnType> CreateMethodReturner(MethodInfo methodInfo) { }

	public static Func<FieldType> CreateStaticFieldGetter(FieldInfo fieldInfo) { }

	public static Action<FieldType> CreateStaticFieldSetter(FieldInfo fieldInfo) { }

	public static Action CreateStaticMethodCaller(MethodInfo methodInfo) { }

	public static Func<PropType> CreateStaticPropertyGetter(PropertyInfo propertyInfo) { }

	public static Action<PropType> CreateStaticPropertySetter(PropertyInfo propertyInfo) { }

	public static WeakValueGetter<FieldType> CreateWeakInstanceFieldGetter(Type instanceType, FieldInfo fieldInfo) { }

	public static WeakValueGetter CreateWeakInstanceFieldGetter(Type instanceType, FieldInfo fieldInfo) { }

	public static WeakValueSetter CreateWeakInstanceFieldSetter(Type instanceType, FieldInfo fieldInfo) { }

	public static WeakValueSetter<FieldType> CreateWeakInstanceFieldSetter(Type instanceType, FieldInfo fieldInfo) { }

	public static Action<Object> CreateWeakInstanceMethodCaller(MethodInfo methodInfo) { }

	public static Action<Object, TArg1> CreateWeakInstanceMethodCaller(MethodInfo methodInfo) { }

	public static Func<Object, TArg1, TResult> CreateWeakInstanceMethodCaller(MethodInfo methodInfo) { }

	public static Func<Object, TResult> CreateWeakInstanceMethodCallerFunc(MethodInfo methodInfo) { }

	public static Func<Object, TArg, TResult> CreateWeakInstanceMethodCallerFunc(MethodInfo methodInfo) { }

	public static WeakValueGetter CreateWeakInstancePropertyGetter(Type instanceType, PropertyInfo propertyInfo) { }

	public static WeakValueSetter CreateWeakInstancePropertySetter(Type instanceType, PropertyInfo propertyInfo) { }

	public static Func<Object> CreateWeakStaticFieldGetter(FieldInfo fieldInfo) { }

	public static Action<Object> CreateWeakStaticFieldSetter(FieldInfo fieldInfo) { }

	public static bool get_CanEmit() { }

}

