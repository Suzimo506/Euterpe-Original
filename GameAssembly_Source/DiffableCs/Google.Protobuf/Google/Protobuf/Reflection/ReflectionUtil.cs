namespace Google.Protobuf.Reflection;

internal static class ReflectionUtil
{
	private class ExtensionReflectionHelper
	{

	}

	public interface IExtensionReflectionHelper
	{

		public void ClearExtension(IMessage message) { }

		public object GetExtension(IMessage message) { }

		public bool HasExtension(IMessage message) { }

	}

	private interface IReflectionHelper
	{

		public Action<IMessage> CreateActionIMessage(MethodInfo method) { }

		public Action<IMessage, Object> CreateActionIMessageObject(MethodInfo method) { }

		public Func<IMessage, Boolean> CreateFuncIMessageBool(MethodInfo method) { }

		public Func<IMessage, Int32> CreateFuncIMessageInt32(MethodInfo method) { }

		public Func<IMessage, Object> CreateFuncIMessageObject(MethodInfo method) { }

	}

	private class ReflectionHelper : IReflectionHelper
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass0_0
		{
			public Func<T1, Int32> del; //Field offset: 0x0

			public <>c__DisplayClass0_0() { }

			internal int <CreateFuncIMessageInt32>b__0(IMessage message) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass0_1
		{
			public Func<T1, T2> del; //Field offset: 0x0

			public <>c__DisplayClass0_1() { }

			internal int <CreateFuncIMessageInt32>b__1(IMessage message) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass1_0
		{
			public Action<T1> del; //Field offset: 0x0

			public <>c__DisplayClass1_0() { }

			internal void <CreateActionIMessage>b__0(IMessage message) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			public Func<T1, T2> del; //Field offset: 0x0

			public <>c__DisplayClass2_0() { }

			internal object <CreateFuncIMessageObject>b__0(IMessage message) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			public Action<T1, T2> del; //Field offset: 0x0

			public <>c__DisplayClass3_0() { }

			internal void <CreateActionIMessageObject>b__0(IMessage message, object arg) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			public Func<T1, Boolean> del; //Field offset: 0x0

			public <>c__DisplayClass4_0() { }

			internal bool <CreateFuncIMessageBool>b__0(IMessage message) { }

		}


		public ReflectionHelper`2() { }

		public override Action<IMessage> CreateActionIMessage(MethodInfo method) { }

		public override Action<IMessage, Object> CreateActionIMessageObject(MethodInfo method) { }

		public override Func<IMessage, Boolean> CreateFuncIMessageBool(MethodInfo method) { }

		public override Func<IMessage, Int32> CreateFuncIMessageInt32(MethodInfo method) { }

		public override Func<IMessage, Object> CreateFuncIMessageObject(MethodInfo method) { }

	}

	internal enum SampleEnum
	{
		X = 0,
	}

	internal static readonly Type[] EmptyTypes; //Field offset: 0x0
	[CompilerGenerated]
	private static readonly bool <CanConvertEnumFuncToInt32Func>k__BackingField; //Field offset: 0x8

	private static bool CanConvertEnumFuncToInt32Func
	{
		[CompilerGenerated]
		private get { } //Length: 87
	}

	private static ReflectionUtil() { }

	private static bool CheckCanConvertEnumFuncToInt32Func() { }

	internal static Action<IMessage> CreateActionIMessage(MethodInfo method) { }

	internal static Action<IMessage, Object> CreateActionIMessageObject(MethodInfo method) { }

	internal static IExtensionReflectionHelper CreateExtensionHelper(Extension extension) { }

	internal static Func<IMessage, Boolean> CreateFuncIMessageBool(MethodInfo method) { }

	internal static Func<IMessage, Int32> CreateFuncIMessageInt32(MethodInfo method) { }

	internal static Func<IMessage, Object> CreateFuncIMessageObject(MethodInfo method) { }

	internal static void ForceInitialize() { }

	[CompilerGenerated]
	private static bool get_CanConvertEnumFuncToInt32Func() { }

	private static IReflectionHelper GetReflectionHelper(Type t1, Type t2) { }

	public static SampleEnum SampleEnumMethod() { }

}

