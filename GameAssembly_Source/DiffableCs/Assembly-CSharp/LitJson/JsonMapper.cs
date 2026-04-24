namespace LitJson;

public class JsonMapper
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static WrapperFactory <>9__23_0; //Field offset: 0x8
		public static ExporterFunc <>9__24_0; //Field offset: 0x10
		public static ExporterFunc <>9__24_1; //Field offset: 0x18
		public static ExporterFunc <>9__24_2; //Field offset: 0x20
		public static ExporterFunc <>9__24_3; //Field offset: 0x28
		public static ExporterFunc <>9__24_4; //Field offset: 0x30
		public static ExporterFunc <>9__24_5; //Field offset: 0x38
		public static ExporterFunc <>9__24_6; //Field offset: 0x40
		public static ExporterFunc <>9__24_7; //Field offset: 0x48
		public static ExporterFunc <>9__24_8; //Field offset: 0x50
		public static ImporterFunc <>9__25_0; //Field offset: 0x58
		public static ImporterFunc <>9__25_1; //Field offset: 0x60
		public static ImporterFunc <>9__25_2; //Field offset: 0x68
		public static ImporterFunc <>9__25_3; //Field offset: 0x70
		public static ImporterFunc <>9__25_4; //Field offset: 0x78
		public static ImporterFunc <>9__25_5; //Field offset: 0x80
		public static ImporterFunc <>9__25_6; //Field offset: 0x88
		public static ImporterFunc <>9__25_7; //Field offset: 0x90
		public static ImporterFunc <>9__25_8; //Field offset: 0x98
		public static ImporterFunc <>9__25_9; //Field offset: 0xA0
		public static ImporterFunc <>9__25_10; //Field offset: 0xA8
		public static ImporterFunc <>9__25_11; //Field offset: 0xB0
		public static WrapperFactory <>9__30_0; //Field offset: 0xB8
		public static WrapperFactory <>9__31_0; //Field offset: 0xC0
		public static WrapperFactory <>9__32_0; //Field offset: 0xC8

		private static <>c() { }

		public <>c() { }

		internal IJsonWrapper <ReadSkip>b__23_0() { }

		internal void <RegisterBaseExporters>b__24_0(object obj, JsonWriter writer) { }

		internal void <RegisterBaseExporters>b__24_1(object obj, JsonWriter writer) { }

		internal void <RegisterBaseExporters>b__24_2(object obj, JsonWriter writer) { }

		internal void <RegisterBaseExporters>b__24_3(object obj, JsonWriter writer) { }

		internal void <RegisterBaseExporters>b__24_4(object obj, JsonWriter writer) { }

		internal void <RegisterBaseExporters>b__24_5(object obj, JsonWriter writer) { }

		internal void <RegisterBaseExporters>b__24_6(object obj, JsonWriter writer) { }

		internal void <RegisterBaseExporters>b__24_7(object obj, JsonWriter writer) { }

		internal void <RegisterBaseExporters>b__24_8(object obj, JsonWriter writer) { }

		internal object <RegisterBaseImporters>b__25_0(object input) { }

		internal object <RegisterBaseImporters>b__25_1(object input) { }

		internal object <RegisterBaseImporters>b__25_10(object input) { }

		internal object <RegisterBaseImporters>b__25_11(object input) { }

		internal object <RegisterBaseImporters>b__25_2(object input) { }

		internal object <RegisterBaseImporters>b__25_3(object input) { }

		internal object <RegisterBaseImporters>b__25_4(object input) { }

		internal object <RegisterBaseImporters>b__25_5(object input) { }

		internal object <RegisterBaseImporters>b__25_6(object input) { }

		internal object <RegisterBaseImporters>b__25_7(object input) { }

		internal object <RegisterBaseImporters>b__25_8(object input) { }

		internal object <RegisterBaseImporters>b__25_9(object input) { }

		internal IJsonWrapper <ToObject>b__30_0() { }

		internal IJsonWrapper <ToObject>b__31_0() { }

		internal IJsonWrapper <ToObject>b__32_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_0
	{
		public ExporterFunc<T> exporter; //Field offset: 0x0

		public <>c__DisplayClass38_0`1() { }

		internal void <RegisterExporter>b__0(object obj, JsonWriter writer) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass39_0
	{
		public ImporterFunc<TJson, TValue> importer; //Field offset: 0x0

		public <>c__DisplayClass39_0`2() { }

		internal object <RegisterImporter>b__0(object input) { }

	}

	private static int max_nesting_depth; //Field offset: 0x0
	private static IFormatProvider datetime_format; //Field offset: 0x8
	private static IDictionary<Type, ExporterFunc> base_exporters_table; //Field offset: 0x10
	private static IDictionary<Type, ExporterFunc> custom_exporters_table; //Field offset: 0x18
	private static IDictionary<Type, IDictionary`2<Type, ImporterFunc>> base_importers_table; //Field offset: 0x20
	private static IDictionary<Type, IDictionary`2<Type, ImporterFunc>> custom_importers_table; //Field offset: 0x28
	private static IDictionary<Type, ArrayMetadata> array_metadata; //Field offset: 0x30
	private static readonly object array_metadata_lock; //Field offset: 0x38
	private static IDictionary<Type, IDictionary`2<Type, MethodInfo>> conv_ops; //Field offset: 0x40
	private static readonly object conv_ops_lock; //Field offset: 0x48
	private static IDictionary<Type, ObjectMetadata> object_metadata; //Field offset: 0x50
	private static readonly object object_metadata_lock; //Field offset: 0x58
	private static IDictionary<Type, IList`1<PropertyMetadata>> type_properties; //Field offset: 0x60
	private static readonly object type_properties_lock; //Field offset: 0x68
	private static JsonWriter static_writer; //Field offset: 0x70
	private static readonly object static_writer_lock; //Field offset: 0x78

	private static JsonMapper() { }

	public JsonMapper() { }

	private static void AddArrayMetadata(Type type) { }

	private static void AddObjectMetadata(Type type) { }

	private static void AddTypeProperties(Type type) { }

	private static MethodInfo GetConvOp(Type t1, Type t2) { }

	private static void ReadSkip(JsonReader reader) { }

	private static object ReadValue(Type inst_type, JsonReader reader) { }

	private static IJsonWrapper ReadValue(WrapperFactory factory, JsonReader reader) { }

	private static void RegisterBaseExporters() { }

	private static void RegisterBaseImporters() { }

	public static void RegisterExporter(ExporterFunc<T> exporter) { }

	private static void RegisterImporter(IDictionary<Type, IDictionary`2<Type, ImporterFunc>> table, Type json_type, Type value_type, ImporterFunc importer) { }

	public static void RegisterImporter(ImporterFunc<TJson, TValue> importer) { }

	public static void ToJson(object obj, JsonWriter writer) { }

	public static string ToJson(object obj) { }

	public static JsonData ToObject(TextReader reader) { }

	public static JsonData ToObject(string json) { }

	public static T ToObject(JsonReader reader) { }

	public static T ToObject(TextReader reader) { }

	public static T ToObject(string json) { }

	public static JsonData ToObject(JsonReader reader) { }

	public static IJsonWrapper ToWrapper(WrapperFactory factory, JsonReader reader) { }

	public static IJsonWrapper ToWrapper(WrapperFactory factory, string json) { }

	public static void UnregisterExporters() { }

	public static void UnregisterImporters() { }

	private static void WriteValue(object obj, JsonWriter writer, bool writer_is_private, int depth) { }

}

