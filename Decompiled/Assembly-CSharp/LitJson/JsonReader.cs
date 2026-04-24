using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;

namespace LitJson;

[Token(Token = "0x2000401")]
public class JsonReader
{
	[Token(Token = "0x4001638")]
	private static IDictionary<int, IDictionary<int, int[]>> parse_table;

	[Token(Token = "0x4001639")]
	[FieldOffset(Offset = "0x10")]
	private Stack<int> automaton_stack;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400163A")]
	private int current_input;

	[Token(Token = "0x400163B")]
	[FieldOffset(Offset = "0x1C")]
	private int current_symbol;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400163C")]
	private bool end_of_json;

	[Token(Token = "0x400163D")]
	[FieldOffset(Offset = "0x21")]
	private bool end_of_input;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400163E")]
	private Lexer lexer;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400163F")]
	private bool parser_in_string;

	[Token(Token = "0x4001640")]
	[FieldOffset(Offset = "0x31")]
	private bool parser_return;

	[Token(Token = "0x4001641")]
	[FieldOffset(Offset = "0x32")]
	private bool read_started;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001642")]
	private TextReader reader;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001643")]
	private bool reader_is_owned;

	[FieldOffset(Offset = "0x41")]
	[Token(Token = "0x4001644")]
	private bool skip_non_members;

	[Token(Token = "0x4001645")]
	[FieldOffset(Offset = "0x48")]
	private object token_value;

	[Token(Token = "0x4001646")]
	[FieldOffset(Offset = "0x50")]
	private JsonToken token;

	[Token(Token = "0x1700045E")]
	public bool AllowComments
	{
		[Address(RVA = "0x8B5250", Offset = "0x8B3A50", Length = "0x1B")]
		[Token(Token = "0x60030C3")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60030C4")]
		[Address(RVA = "0x8B52A0", Offset = "0x8B3AA0", Length = "0x1A")]
		set
		{
		}
	}

	[Token(Token = "0x1700045F")]
	public bool AllowSingleQuotedStrings
	{
		[Token(Token = "0x60030C5")]
		[Address(RVA = "0x8B5270", Offset = "0x8B3A70", Length = "0x1B")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x8B52C0", Offset = "0x8B3AC0", Length = "0x1A")]
		[Token(Token = "0x60030C6")]
		set
		{
		}
	}

	[Token(Token = "0x17000460")]
	public bool SkipNonMembers
	{
		[Token(Token = "0x60030C7")]
		[Address(RVA = "0x5F9A70", Offset = "0x5F8270", Length = "0x5")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x5F9A80", Offset = "0x5F8280", Length = "0x4")]
		[Token(Token = "0x60030C8")]
		set
		{
		}
	}

	[Token(Token = "0x17000461")]
	public bool EndOfInput
	{
		[Token(Token = "0x60030C9")]
		[Address(RVA = "0x8B5290", Offset = "0x8B3A90", Length = "0x5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000462")]
	public bool EndOfJson
	{
		[Address(RVA = "0x45D430", Offset = "0x45BC30", Length = "0x5")]
		[Token(Token = "0x60030CA")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000463")]
	public JsonToken Token
	{
		[Address(RVA = "0x492770", Offset = "0x490F70", Length = "0x4")]
		[Token(Token = "0x60030CB")]
		get
		{
			return default(JsonToken);
		}
	}

	[Token(Token = "0x17000464")]
	public object Value
	{
		[Token(Token = "0x60030CC")]
		[Address(RVA = "0x46EF30", Offset = "0x46D730", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60030CD")]
	[Address(RVA = "0x8B4FB0", Offset = "0x8B37B0", Length = "0x7")]
	static JsonReader()
	{
	}

	[Token(Token = "0x60030CE")]
	[Address(RVA = "0x8B51E0", Offset = "0x8B39E0", Length = "0x6D")]
	public JsonReader(string json_text)
	{
	}

	[Address(RVA = "0x8B51D0", Offset = "0x8B39D0", Length = "0xB")]
	[Token(Token = "0x60030CF")]
	public JsonReader(TextReader reader)
	{
	}

	[Token(Token = "0x60030D0")]
	[Address(RVA = "0x8B4FC0", Offset = "0x8B37C0", Length = "0x20E")]
	private JsonReader(TextReader reader, bool owned)
	{
	}

	[Token(Token = "0x60030D1")]
	[Address(RVA = "0x8B3D80", Offset = "0x8B2580", Length = "0x887")]
	private static void PopulateParseTable()
	{
	}

	[Token(Token = "0x60030D2")]
	[Address(RVA = "0x8B4DA0", Offset = "0x8B35A0", Length = "0x10D")]
	private static void TableAddCol(ParserToken row, int col, params int[] symbols)
	{
	}

	[Token(Token = "0x60030D3")]
	[Address(RVA = "0x8B4EB0", Offset = "0x8B36B0", Length = "0xFE")]
	private static void TableAddRow(ParserToken rule)
	{
	}

	[Token(Token = "0x60030D4")]
	[Address(RVA = "0x8B4610", Offset = "0x8B2E10", Length = "0x1BB")]
	private void ProcessNumber(string number)
	{
	}

	[Token(Token = "0x60030D5")]
	[Address(RVA = "0x8B47D0", Offset = "0x8B2FD0", Length = "0x1D2")]
	private void ProcessSymbol()
	{
	}

	[Token(Token = "0x60030D6")]
	[Address(RVA = "0x8B49B0", Offset = "0x8B31B0", Length = "0x8F")]
	private bool ReadToken()
	{
		return default(bool);
	}

	[Token(Token = "0x60030D7")]
	[Address(RVA = "0x8B3D10", Offset = "0x8B2510", Length = "0x60")]
	public void Close()
	{
	}

	[Token(Token = "0x60030D8")]
	[Address(RVA = "0x8B4A40", Offset = "0x8B3240", Length = "0x14C")]
	public bool Read()
	{
		return default(bool);
	}
}
