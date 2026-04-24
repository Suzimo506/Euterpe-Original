namespace Newtonsoft.Json.Utilities;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class ReflectionObject
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public Func<Object> ctor; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal object <Create>b__0(Object[] args) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_1
	{
		[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public MethodCall<Object, Object> call; //Field offset: 0x10

		public <>c__DisplayClass11_1() { }

		internal object <Create>b__1(object target) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_2
	{
		[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public MethodCall<Object, Object> call; //Field offset: 0x10

		public <>c__DisplayClass11_2() { }

		internal void <Create>b__2(object target, object arg) { }

	}

	[CompilerGenerated]
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private readonly ObjectConstructor<Object> <Creator>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly IDictionary<String, ReflectionMember> <Members>k__BackingField; //Field offset: 0x18

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public ObjectConstructor<Object> Creator
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public IDictionary<String, ReflectionMember> Members
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	private ReflectionObject(ObjectConstructor<Object> creator) { }

	public static ReflectionObject Create(Type t, String[] memberNames) { }

	public static ReflectionObject Create(Type t, MethodBase creator, String[] memberNames) { }

	[CompilerGenerated]
	public ObjectConstructor<Object> get_Creator() { }

	[CompilerGenerated]
	public IDictionary<String, ReflectionMember> get_Members() { }

	public Type GetType(string member) { }

	public object GetValue(object target, string member) { }

	public void SetValue(object target, string member, object value) { }

}

