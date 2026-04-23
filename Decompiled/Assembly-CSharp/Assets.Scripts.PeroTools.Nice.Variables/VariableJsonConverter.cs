using System;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Assets.Scripts.PeroTools.Nice.Variables;

[Token(Token = "0x20005CB")]
public class VariableJsonConverter : CustomCreationConverter<IVariable>
{
	[Token(Token = "0x1700054B")]
	public override bool CanWrite
	{
		[Token(Token = "0x60039BB")]
		[Address(RVA = "0x526C70", Offset = "0x525470", Length = "0x3")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700054C")]
	public override bool CanRead
	{
		[Token(Token = "0x60039BC")]
		[Address(RVA = "0x526C70", Offset = "0x525470", Length = "0x3")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60039B8")]
	[Address(RVA = "0x988780", Offset = "0x986F80", Length = "0x83")]
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
	}

	[Token(Token = "0x60039B9")]
	[Address(RVA = "0x9881C0", Offset = "0x9869C0", Length = "0x5B2")]
	public override object ReadJson(JsonReader reader, Type type, object existingValue, JsonSerializer serializer)
	{
		return null;
	}

	[Address(RVA = "0x988170", Offset = "0x986970", Length = "0x43")]
	[Token(Token = "0x60039BA")]
	public override IVariable Create(Type type)
	{
		return null;
	}

	[Address(RVA = "0x988810", Offset = "0x987010", Length = "0x38")]
	[Token(Token = "0x60039BD")]
	public VariableJsonConverter()
	{
		((CustomCreationConverter<T>)(object)this)._002Ector();
	}
}
