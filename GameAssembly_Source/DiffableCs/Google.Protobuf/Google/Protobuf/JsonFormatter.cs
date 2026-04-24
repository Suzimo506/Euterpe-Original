namespace Google.Protobuf;

public sealed class JsonFormatter
{
	private static class OriginalEnumValueHelper
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func<FieldInfo, Boolean> <>9__2_0; //Field offset: 0x8
			public static Func<FieldInfo, Boolean> <>9__2_1; //Field offset: 0x10
			public static Func<FieldInfo, Object> <>9__2_2; //Field offset: 0x18
			public static Func<FieldInfo, String> <>9__2_3; //Field offset: 0x20

			private static <>c() { }

			public <>c() { }

			internal bool <GetNameMapping>b__2_0(FieldInfo f) { }

			internal bool <GetNameMapping>b__2_1(FieldInfo f) { }

			internal object <GetNameMapping>b__2_2(FieldInfo f) { }

			internal string <GetNameMapping>b__2_3(FieldInfo f) { }

		}

		private static readonly Dictionary<Type, Dictionary`2<Object, String>> dictionaries; //Field offset: 0x6A45C

		private static OriginalEnumValueHelper() { }

		private static Dictionary<Object, String> GetNameMapping(Type enumType) { }

		internal static string GetOriginalName(object value) { }

	}

	internal sealed class Settings
	{
		[CompilerGenerated]
		private static readonly Settings <Default>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private readonly bool <FormatDefaultValues>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private readonly TypeRegistry <TypeRegistry>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private readonly bool <FormatEnumsAsIntegers>k__BackingField; //Field offset: 0x20

		public static Settings Default
		{
			[CompilerGenerated]
			 get { } //Length: 554
		}

		public bool FormatDefaultValues
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public bool FormatEnumsAsIntegers
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public TypeRegistry TypeRegistry
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		private static Settings() { }

		public Settings(bool formatDefaultValues) { }

		public Settings(bool formatDefaultValues, TypeRegistry typeRegistry) { }

		private Settings(bool formatDefaultValues, TypeRegistry typeRegistry, bool formatEnumsAsIntegers) { }

		[CompilerGenerated]
		public static Settings get_Default() { }

		[CompilerGenerated]
		public bool get_FormatDefaultValues() { }

		[CompilerGenerated]
		public bool get_FormatEnumsAsIntegers() { }

		[CompilerGenerated]
		public TypeRegistry get_TypeRegistry() { }

	}

	[CompilerGenerated]
	private static readonly JsonFormatter <Default>k__BackingField; //Field offset: 0x0
	private static readonly JsonFormatter diagnosticFormatter; //Field offset: 0x8
	private static readonly String[] CommonRepresentations; //Field offset: 0x10
	private readonly Settings settings; //Field offset: 0x10

	public static JsonFormatter Default
	{
		[CompilerGenerated]
		 get { } //Length: 86
	}

	private bool DiagnosticOnly
	{
		private get { } //Length: 96
	}

	private static JsonFormatter() { }

	public JsonFormatter(Settings settings) { }

	public string Format(IMessage message) { }

	public void Format(IMessage message, TextWriter writer) { }

	[CompilerGenerated]
	public static JsonFormatter get_Default() { }

	private bool get_DiagnosticOnly() { }

	private static void HexEncodeUtf16CodeUnit(TextWriter writer, char c) { }

	private static bool IsDefaultValue(FieldDescriptor descriptor, object value) { }

	private bool ShouldFormatFieldValue(IMessage message, FieldDescriptor field, object value) { }

	public static string ToDiagnosticString(IMessage message) { }

	internal static string ToJsonName(string name) { }

	private void WriteAny(TextWriter writer, IMessage value) { }

	private void WriteDiagnosticOnlyAny(TextWriter writer, IMessage value) { }

	internal void WriteDictionary(TextWriter writer, IDictionary dictionary) { }

	private void WriteDuration(TextWriter writer, IMessage value) { }

	private void WriteFieldMask(TextWriter writer, IMessage value) { }

	internal void WriteList(TextWriter writer, IList list) { }

	private void WriteMessage(TextWriter writer, IMessage message) { }

	private bool WriteMessageFields(TextWriter writer, IMessage message, bool assumeFirstFieldWritten) { }

	private static void WriteNull(TextWriter writer) { }

	internal static void WriteString(TextWriter writer, string text) { }

	private void WriteStruct(TextWriter writer, IMessage message) { }

	private void WriteStructFieldValue(TextWriter writer, IMessage message) { }

	private void WriteTimestamp(TextWriter writer, IMessage value) { }

	public void WriteValue(TextWriter writer, object value) { }

	private void WriteWellKnownTypeValue(TextWriter writer, MessageDescriptor descriptor, object value) { }

}

