namespace FlexFramework.Excel;

public static class ValueConverter
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public Type type; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

		internal bool <Unregister>b__0(IConverter c) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public Type type; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal bool <Convert>b__0(IConverter c) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public IConverter converter; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal bool <Register>b__0(IConverter c) { }

	}

	private class Converter : IConverter
	{
		private Converter<String, Object> _converter; //Field offset: 0x10
		private Type _type; //Field offset: 0x18

		private override Type FlexFramework.Excel.IConverter.Type
		{
			private get { } //Length: 5
		}

		public Converter(Converter<String, Object> converter, Type type) { }

		private override object FlexFramework.Excel.IConverter.Convert(string input) { }

		private override Type FlexFramework.Excel.IConverter.get_Type() { }

	}

	private class Converter : IConverter
	{
		private Converter<String, T> _converter; //Field offset: 0x0

		private override Type FlexFramework.Excel.IConverter.Type
		{
			private get { } //Length: 95
		}

		public Converter`1(Converter<String, T> converter) { }

		private override object FlexFramework.Excel.IConverter.Convert(string input) { }

		private override Type FlexFramework.Excel.IConverter.get_Type() { }

	}

	private static readonly List<IConverter> converters; //Field offset: 0x2C927BC

	private static ValueConverter() { }

	public static object Convert(Type type, string value) { }

	public static T Convert(string value) { }

	public static void Empty() { }

	public static bool Register(IConverter converter) { }

	public static bool Register() { }

	public static bool Register(Converter<String, T> converter) { }

	public static bool Register(Converter<String, Object> converter, Type type) { }

	public static void Reset() { }

	public static bool Unregister(Type type) { }

	public static bool Unregister() { }

}

