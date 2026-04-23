using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace LitJson;

[Token(Token = "0x20003F4")]
internal class OrderedDictionaryEnumerator : IDictionaryEnumerator, IEnumerator
{
	[Token(Token = "0x4001611")]
	[FieldOffset(Offset = "0x10")]
	private IEnumerator<KeyValuePair<string, JsonData>> list_enumerator;

	[Token(Token = "0x17000441")]
	public object Current
	{
		[Address(RVA = "0x8CB600", Offset = "0x8C9E00", Length = "0x105")]
		[Token(Token = "0x6003044")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000442")]
	public DictionaryEntry Entry
	{
		[Token(Token = "0x6003045")]
		[Address(RVA = "0x8CB710", Offset = "0x8C9F10", Length = "0xDD")]
		get
		{
			return default(DictionaryEntry);
		}
	}

	[Token(Token = "0x17000443")]
	public object Key
	{
		[Address(RVA = "0x8CB7F0", Offset = "0x8C9FF0", Length = "0xA1")]
		[Token(Token = "0x6003046")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000444")]
	public object Value
	{
		[Address(RVA = "0x8CB8A0", Offset = "0x8CA0A0", Length = "0xA2")]
		[Token(Token = "0x6003047")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003048")]
	[Address(RVA = "0x494AC0", Offset = "0x4932C0", Length = "0x30")]
	public OrderedDictionaryEnumerator(IEnumerator<KeyValuePair<string, JsonData>> enumerator)
	{
	}

	[Address(RVA = "0x8CB500", Offset = "0x8C9D00", Length = "0x45")]
	[Token(Token = "0x6003049")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Token(Token = "0x600304A")]
	[Address(RVA = "0x8CB550", Offset = "0x8C9D50", Length = "0xAB")]
	public void Reset()
	{
	}
}
