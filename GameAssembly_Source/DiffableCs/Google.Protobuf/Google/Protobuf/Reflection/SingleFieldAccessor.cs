namespace Google.Protobuf.Reflection;

internal sealed class SingleFieldAccessor : FieldAccessorBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<IMessage, Boolean> <>9__3_4; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__3_4(IMessage message) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public SingleFieldAccessor <>4__this; //Field offset: 0x10
		public FieldDescriptor descriptor; //Field offset: 0x18

		public <>c__DisplayClass3_0() { }

		internal bool <.ctor>b__0(IMessage message) { }

		internal void <.ctor>b__1(IMessage message) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_1
	{
		public OneofAccessor oneofAccessor; //Field offset: 0x10
		public <>c__DisplayClass3_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass3_1() { }

		internal bool <.ctor>b__2(IMessage message) { }

		internal void <.ctor>b__3(IMessage message) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_2
	{
		public object defaultValue; //Field offset: 0x10
		public <>c__DisplayClass3_0 CS$<>8__locals2; //Field offset: 0x18

		public <>c__DisplayClass3_2() { }

		internal void <.ctor>b__5(IMessage message) { }

	}

	private readonly Action<IMessage, Object> setValueDelegate; //Field offset: 0x20
	private readonly Action<IMessage> clearDelegate; //Field offset: 0x28
	private readonly Func<IMessage, Boolean> hasDelegate; //Field offset: 0x30

	internal SingleFieldAccessor(PropertyInfo property, FieldDescriptor descriptor) { }

	public virtual void Clear(IMessage message) { }

	public virtual bool HasValue(IMessage message) { }

	public virtual void SetValue(IMessage message, object value) { }

}

