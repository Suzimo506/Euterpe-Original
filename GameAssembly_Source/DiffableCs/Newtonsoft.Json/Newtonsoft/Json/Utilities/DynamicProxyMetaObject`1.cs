namespace Newtonsoft.Json.Utilities;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal sealed class DynamicProxyMetaObject : DynamicMetaObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public static readonly <>c<T> <>9; //Field offset: 0x0
		[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public static Func<DynamicMetaObject, Expression> <>9__18_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		internal Expression <GetArgs>b__18_0(DynamicMetaObject arg) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public GetMemberBinder binder; //Field offset: 0x0
		[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public DynamicProxyMetaObject<T> <>4__this; //Field offset: 0x0

		public <>c__DisplayClass3_0() { }

		internal DynamicMetaObject <BindGetMember>b__0(DynamicMetaObject e) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public SetMemberBinder binder; //Field offset: 0x0
		[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public DynamicProxyMetaObject<T> <>4__this; //Field offset: 0x0
		[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public DynamicMetaObject value; //Field offset: 0x0

		public <>c__DisplayClass4_0() { }

		internal DynamicMetaObject <BindSetMember>b__0(DynamicMetaObject e) { }

	}

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private sealed class Fallback : MulticastDelegate
	{

		public Fallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(DynamicMetaObject errorSuggestion, AsyncCallback callback, object object) { }

		public override DynamicMetaObject EndInvoke(IAsyncResult result) { }

		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public override DynamicMetaObject Invoke(DynamicMetaObject errorSuggestion) { }

	}

	private readonly DynamicProxy<T> _proxy; //Field offset: 0x0

	private static Expression[] NoArgs
	{
		private get { } //Length: 47
	}

	internal DynamicProxyMetaObject`1(Expression expression, T value, DynamicProxy<T> proxy) { }

	public virtual DynamicMetaObject BindGetMember(GetMemberBinder binder) { }

	public virtual DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value) { }

	private DynamicMetaObject BuildCallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, DynamicMetaObject fallbackResult, Fallback<T> fallbackInvoke) { }

	private DynamicMetaObject CallMethodReturnLast(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, Fallback<T> fallback) { }

	private DynamicMetaObject CallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, Fallback<T> fallback, Fallback<T> fallbackInvoke = null) { }

	private static ConstantExpression Constant(DynamicMetaObjectBinder binder) { }

	private static Expression[] get_NoArgs() { }

	private static IEnumerable<Expression> GetArgs(DynamicMetaObject[] args) { }

	public virtual IEnumerable<String> GetDynamicMemberNames() { }

	private BindingRestrictions GetRestrictions() { }

	private bool IsOverridden(string method) { }

}

