using System;
using Cpp2ILInjected;
using Newtonsoft.Json;

namespace Assets.Scripts.PeroTools.Nice.Variables;

[Token(Token = "0x20005CD")]
public class DictionaryJsonConverter : JsonConverter
{
	[Address(RVA = "0x979530", Offset = "0x977D30", Length = "0x1F5")]
	[Token(Token = "0x60039C4")]
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
	}

	[Address(RVA = "0x979510", Offset = "0x977D10", Length = "0x1F")]
	[Token(Token = "0x60039C5")]
	public override object ReadJson(JsonReader reader, Type type, object existingValue, JsonSerializer serializer)
	{
		return null;
	}

	[Address(RVA = "0x9794A0", Offset = "0x977CA0", Length = "0x6F")]
	[Token(Token = "0x60039C6")]
	public override bool CanConvert(Type type)
	{
		return default(bool);
	}

	[Address(RVA = "0x441AE0", Offset = "0x4402E0", Length = "0x7")]
	[Token(Token = "0x60039C7")]
	public DictionaryJsonConverter()
	{
	}
}
