using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Cpp2ILInjected;

namespace LitJson;

[Token(Token = "0x20003FE")]
public class JsonMapper
{
	[Token(Token = "0x400161B")]
	private static int max_nesting_depth;

	[Token(Token = "0x400161C")]
	private static IFormatProvider datetime_format;

	[Token(Token = "0x400161D")]
	private static IDictionary<Type, ExporterFunc> base_exporters_table;

	[Token(Token = "0x400161E")]
	private static IDictionary<Type, ExporterFunc> custom_exporters_table;

	[Token(Token = "0x400161F")]
	private static IDictionary<Type, IDictionary<Type, ImporterFunc>> base_importers_table;

	[Token(Token = "0x4001620")]
	private static IDictionary<Type, IDictionary<Type, ImporterFunc>> custom_importers_table;

	[Token(Token = "0x4001621")]
	private static IDictionary<Type, ArrayMetadata> array_metadata;

	[Token(Token = "0x4001622")]
	private static readonly object array_metadata_lock;

	[Token(Token = "0x4001623")]
	private static IDictionary<Type, IDictionary<Type, MethodInfo>> conv_ops;

	[Token(Token = "0x4001624")]
	private static readonly object conv_ops_lock;

	[Token(Token = "0x4001625")]
	private static IDictionary<Type, ObjectMetadata> object_metadata;

	[Token(Token = "0x4001626")]
	private static readonly object object_metadata_lock;

	[Token(Token = "0x4001627")]
	private static IDictionary<Type, IList<PropertyMetadata>> type_properties;

	[Token(Token = "0x4001628")]
	private static readonly object type_properties_lock;

	[Token(Token = "0x4001629")]
	private static JsonWriter static_writer;

	[Token(Token = "0x400162A")]
	private static readonly object static_writer_lock;

	[Address(RVA = "0x5D1BC0", Offset = "0x5D03C0", Length = "0x3A6")]
	[Token(Token = "0x6003072")]
	static JsonMapper()
	{
	}

	[Address(RVA = "0x5CBEB0", Offset = "0x5CA6B0", Length = "0x409")]
	[Token(Token = "0x6003073")]
	private static void AddArrayMetadata(Type type)
	{
	}

	[Token(Token = "0x6003074")]
	[Address(RVA = "0x5CC2C0", Offset = "0x5CAAC0", Length = "0x61B")]
	private static void AddObjectMetadata(Type type)
	{
	}

	[Address(RVA = "0x5CC8E0", Offset = "0x5CB0E0", Length = "0x40D")]
	[Token(Token = "0x6003075")]
	private static void AddTypeProperties(Type type)
	{
	}

	[Address(RVA = "0x5CCCF0", Offset = "0x5CB4F0", Length = "0x5C5")]
	[Token(Token = "0x6003076")]
	private static MethodInfo GetConvOp(Type t1, Type t2)
	{
		return null;
	}

	[Address(RVA = "0x5CD410", Offset = "0x5CBC10", Length = "0xF16")]
	[Token(Token = "0x6003077")]
	private static object ReadValue(Type inst_type, JsonReader reader)
	{
		return null;
	}

	[Address(RVA = "0x5CE330", Offset = "0x5CCB30", Length = "0x4CE")]
	[Token(Token = "0x6003078")]
	private static IJsonWrapper ReadValue(WrapperFactory factory, JsonReader reader)
	{
		return null;
	}

	[Address(RVA = "0x5CD2C0", Offset = "0x5CBAC0", Length = "0x145")]
	[Token(Token = "0x6003079")]
	private static void ReadSkip(JsonReader reader)
	{
	}

	[Token(Token = "0x600307A")]
	[Address(RVA = "0x5CE800", Offset = "0x5CD000", Length = "0xB46")]
	private static void RegisterBaseExporters()
	{
	}

	[Token(Token = "0x600307B")]
	[Address(RVA = "0x5CF350", Offset = "0x5CDB50", Length = "0xEA4")]
	private static void RegisterBaseImporters()
	{
	}

	[Address(RVA = "0x5D0200", Offset = "0x5CEA00", Length = "0x148")]
	[Token(Token = "0x600307C")]
	private static void RegisterImporter(IDictionary<Type, IDictionary<Type, ImporterFunc>> table, Type json_type, Type value_type, ImporterFunc importer)
	{
	}

	[Token(Token = "0x600307D")]
	[Address(RVA = "0x5D0C50", Offset = "0x5CF450", Length = "0xF61")]
	private static void WriteValue(object obj, JsonWriter writer, bool writer_is_private, int depth)
	{
	}

	[Address(RVA = "0x5D0350", Offset = "0x5CEB50", Length = "0x17B")]
	[Token(Token = "0x600307E")]
	public static string ToJson(object obj)
	{
		return null;
	}

	[Token(Token = "0x600307F")]
	[Address(RVA = "0x5D04D0", Offset = "0x5CECD0", Length = "0x6E")]
	public static void ToJson(object obj, JsonWriter writer)
	{
	}

	[Address(RVA = "0x5D0540", Offset = "0x5CED40", Length = "0x19E")]
	[Token(Token = "0x6003080")]
	public static JsonData ToObject(JsonReader reader)
	{
		return null;
	}

	[Token(Token = "0x6003081")]
	[Address(RVA = "0x5D0890", Offset = "0x5CF090", Length = "0x1B3")]
	public static JsonData ToObject(TextReader reader)
	{
		return null;
	}

	[Address(RVA = "0x5D06E0", Offset = "0x5CEEE0", Length = "0x1AC")]
	[Token(Token = "0x6003082")]
	public static JsonData ToObject(string json)
	{
		return null;
	}

	[Address(RVA = "0x918020", Offset = "0x916820", Length = "0xDC")]
	[Token(Token = "0x6003083")]
	public static T ToObject<T>(JsonReader reader)
	{
		return (T)null;
	}

	[Token(Token = "0x6003084")]
	[Address(RVA = "0x918100", Offset = "0x916900", Length = "0xF9")]
	public static T ToObject<T>(TextReader reader)
	{
		return (T)null;
	}

	[Token(Token = "0x6003085")]
	[Address(RVA = "0x917F20", Offset = "0x916720", Length = "0xF9")]
	public static T ToObject<T>(string json)
	{
		return (T)null;
	}

	[Token(Token = "0x6003086")]
	[Address(RVA = "0x5D0AE0", Offset = "0x5CF2E0", Length = "0x61")]
	public static IJsonWrapper ToWrapper(WrapperFactory factory, JsonReader reader)
	{
		return null;
	}

	[Token(Token = "0x6003087")]
	[Address(RVA = "0x5D0A50", Offset = "0x5CF250", Length = "0x88")]
	public static IJsonWrapper ToWrapper(WrapperFactory factory, string json)
	{
		return null;
	}

	[Address(RVA = "0x7C2E10", Offset = "0x7C1610", Length = "0x18D")]
	[Token(Token = "0x6003088")]
	public static void RegisterExporter<T>(ExporterFunc<T> exporter)
	{
	}

	[Address(RVA = "0x7C2FA0", Offset = "0x7C17A0", Length = "0x14F")]
	[Token(Token = "0x6003089")]
	public static void RegisterImporter<TJson, TValue>(ImporterFunc<TJson, TValue> importer)
	{
	}

	[Address(RVA = "0x5D0B50", Offset = "0x5CF350", Length = "0x71")]
	[Token(Token = "0x600308A")]
	public static void UnregisterExporters()
	{
	}

	[Address(RVA = "0x5D0BD0", Offset = "0x5CF3D0", Length = "0x71")]
	[Token(Token = "0x600308B")]
	public static void UnregisterImporters()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x600308C")]
	public JsonMapper()
	{
	}
}
