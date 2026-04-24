namespace LitJson;

public class JsonReader
{
	private static IDictionary<Int32, IDictionary`2<Int32, Int32[]>> parse_table; //Field offset: 0x0
	private Stack<Int32> automaton_stack; //Field offset: 0x10
	private int current_input; //Field offset: 0x18
	private int current_symbol; //Field offset: 0x1C
	private bool end_of_json; //Field offset: 0x20
	private bool end_of_input; //Field offset: 0x21
	private Lexer lexer; //Field offset: 0x28
	private bool parser_in_string; //Field offset: 0x30
	private bool parser_return; //Field offset: 0x31
	private bool read_started; //Field offset: 0x32
	private TextReader reader; //Field offset: 0x38
	private bool reader_is_owned; //Field offset: 0x40
	private bool skip_non_members; //Field offset: 0x41
	private object token_value; //Field offset: 0x48
	private JsonToken token; //Field offset: 0x50

	public bool AllowComments
	{
		 get { } //Length: 27
		 set { } //Length: 26
	}

	public bool AllowSingleQuotedStrings
	{
		 get { } //Length: 27
		 set { } //Length: 26
	}

	public bool EndOfInput
	{
		 get { } //Length: 5
	}

	public bool EndOfJson
	{
		 get { } //Length: 5
	}

	public bool SkipNonMembers
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public JsonToken Token
	{
		 get { } //Length: 4
	}

	public object Value
	{
		 get { } //Length: 5
	}

	private static JsonReader() { }

	private JsonReader(TextReader reader, bool owned) { }

	public JsonReader(TextReader reader) { }

	public JsonReader(string json_text) { }

	public void Close() { }

	public bool get_AllowComments() { }

	public bool get_AllowSingleQuotedStrings() { }

	public bool get_EndOfInput() { }

	public bool get_EndOfJson() { }

	public bool get_SkipNonMembers() { }

	public JsonToken get_Token() { }

	public object get_Value() { }

	private static void PopulateParseTable() { }

	private void ProcessNumber(string number) { }

	private void ProcessSymbol() { }

	public bool Read() { }

	private bool ReadToken() { }

	public void set_AllowComments(bool value) { }

	public void set_AllowSingleQuotedStrings(bool value) { }

	public void set_SkipNonMembers(bool value) { }

	private static void TableAddCol(ParserToken row, int col, Int32[] symbols) { }

	private static void TableAddRow(ParserToken rule) { }

}

