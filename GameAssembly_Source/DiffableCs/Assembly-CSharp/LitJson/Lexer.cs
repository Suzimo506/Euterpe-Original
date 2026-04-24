namespace LitJson;

internal class Lexer
{
	private sealed class StateHandler : MulticastDelegate
	{

		public StateHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(FsmContext ctx, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(FsmContext ctx) { }

	}

	private static Int32[] fsm_return_table; //Field offset: 0x0
	private static StateHandler[] fsm_handler_table; //Field offset: 0x8
	private bool allow_comments; //Field offset: 0x10
	private bool allow_single_quoted_strings; //Field offset: 0x11
	private bool end_of_input; //Field offset: 0x12
	private FsmContext fsm_context; //Field offset: 0x18
	private int input_buffer; //Field offset: 0x20
	private int input_char; //Field offset: 0x24
	private TextReader reader; //Field offset: 0x28
	private int state; //Field offset: 0x30
	private StringBuilder string_buffer; //Field offset: 0x38
	private string string_value; //Field offset: 0x40
	private int token; //Field offset: 0x48
	private int unichar; //Field offset: 0x4C

	public bool AllowComments
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool AllowSingleQuotedStrings
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool EndOfInput
	{
		 get { } //Length: 5
	}

	public string StringValue
	{
		 get { } //Length: 5
	}

	public int Token
	{
		 get { } //Length: 4
	}

	private static Lexer() { }

	public Lexer(TextReader reader) { }

	public bool get_AllowComments() { }

	public bool get_AllowSingleQuotedStrings() { }

	public bool get_EndOfInput() { }

	public string get_StringValue() { }

	public int get_Token() { }

	private bool GetChar() { }

	private static int HexValue(int digit) { }

	private int NextChar() { }

	public bool NextToken() { }

	private static void PopulateFsmTables() { }

	private static char ProcessEscChar(int esc_char) { }

	public void set_AllowComments(bool value) { }

	public void set_AllowSingleQuotedStrings(bool value) { }

	private static bool State1(FsmContext ctx) { }

	private static bool State10(FsmContext ctx) { }

	private static bool State11(FsmContext ctx) { }

	private static bool State12(FsmContext ctx) { }

	private static bool State13(FsmContext ctx) { }

	private static bool State14(FsmContext ctx) { }

	private static bool State15(FsmContext ctx) { }

	private static bool State16(FsmContext ctx) { }

	private static bool State17(FsmContext ctx) { }

	private static bool State18(FsmContext ctx) { }

	private static bool State19(FsmContext ctx) { }

	private static bool State2(FsmContext ctx) { }

	private static bool State20(FsmContext ctx) { }

	private static bool State21(FsmContext ctx) { }

	private static bool State22(FsmContext ctx) { }

	private static bool State23(FsmContext ctx) { }

	private static bool State24(FsmContext ctx) { }

	private static bool State25(FsmContext ctx) { }

	private static bool State26(FsmContext ctx) { }

	private static bool State27(FsmContext ctx) { }

	private static bool State28(FsmContext ctx) { }

	private static bool State3(FsmContext ctx) { }

	private static bool State4(FsmContext ctx) { }

	private static bool State5(FsmContext ctx) { }

	private static bool State6(FsmContext ctx) { }

	private static bool State7(FsmContext ctx) { }

	private static bool State8(FsmContext ctx) { }

	private static bool State9(FsmContext ctx) { }

	private void UngetChar() { }

}

