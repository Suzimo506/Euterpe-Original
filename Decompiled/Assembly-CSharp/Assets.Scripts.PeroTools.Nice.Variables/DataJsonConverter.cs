using System;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Assets.Scripts.PeroTools.Nice.Variables;

[Token(Token = "0x20005CC")]
public class DataJsonConverter : CustomCreationConverter<IData>
{
	[Token(Token = "0x1700054D")]
	public override bool CanWrite
	{
		[Token(Token = "0x60039C1")]
		[Address(RVA = "0x526C70", Offset = "0x525470", Length = "0x3")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700054E")]
	public override bool CanRead
	{
		[Address(RVA = "0x526C70", Offset = "0x525470", Length = "0x3")]
		[Token(Token = "0x60039C2")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60039BE")]
	[Address(RVA = "0x976380", Offset = "0x974B80", Length = "0x1AC")]
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
	}

	[Address(RVA = "0x976080", Offset = "0x974880", Length = "0x2FD")]
	[Token(Token = "0x60039BF")]
	public override object ReadJson(JsonReader reader, Type type, object existingValue, JsonSerializer serializer)
	{
		return null;
	}

	[Token(Token = "0x60039C0")]
	[Address(RVA = "0x976030", Offset = "0x974830", Length = "0x43")]
	public override IData Create(Type objectType)
	{
		return null;
	}

	[Token(Token = "0x60039C3")]
	[Address(RVA = "0x976530", Offset = "0x974D30", Length = "0x38")]
	public DataJsonConverter()
	{
		((CustomCreationConverter<T>)(object)this)._002Ector();
	}
}
