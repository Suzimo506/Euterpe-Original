namespace LitJson;

public class JsonWriter
{
	private static NumberFormatInfo number_format; //Field offset: 0x0
	private WriterContext context; //Field offset: 0x10
	private Stack<WriterContext> ctx_stack; //Field offset: 0x18
	private bool has_reached_end; //Field offset: 0x20
	private Char[] hex_seq; //Field offset: 0x28
	private int indentation; //Field offset: 0x30
	private int indent_value; //Field offset: 0x34
	private StringBuilder inst_string_builder; //Field offset: 0x38
	private bool pretty_print; //Field offset: 0x40
	private bool validate; //Field offset: 0x41
	private TextWriter writer; //Field offset: 0x48

	public int IndentValue
	{
		 get { } //Length: 4
		 set { } //Length: 22
	}

	public bool PrettyPrint
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public TextWriter TextWriter
	{
		 get { } //Length: 5
	}

	public bool Validate
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	private static JsonWriter() { }

	public JsonWriter() { }

	public JsonWriter(StringBuilder sb) { }

	public JsonWriter(TextWriter writer) { }

	private void DoValidation(Condition cond) { }

	public int get_IndentValue() { }

	public bool get_PrettyPrint() { }

	public TextWriter get_TextWriter() { }

	public bool get_Validate() { }

	private void Indent() { }

	private void Init() { }

	private static void IntToHex(int n, Char[] hex) { }

	private void Put(string str) { }

	private void PutNewline(bool add_comma) { }

	private void PutNewline() { }

	private void PutString(string str) { }

	public void Reset() { }

	public void set_IndentValue(int value) { }

	public void set_PrettyPrint(bool value) { }

	public void set_Validate(bool value) { }

	public virtual string ToString() { }

	private void Unindent() { }

	public void Write(ulong number) { }

	public void Write(string str) { }

	public void Write(long number) { }

	public void Write(double number) { }

	public void Write(decimal number) { }

	public void Write(bool boolean) { }

	public void Write(int number) { }

	public void WriteArrayEnd() { }

	public void WriteArrayStart() { }

	public void WriteObjectEnd() { }

	public void WriteObjectStart() { }

	public void WritePropertyName(string property_name) { }

}

