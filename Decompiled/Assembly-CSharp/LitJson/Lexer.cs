using System.IO;
using System.Text;
using Cpp2ILInjected;

namespace LitJson;

[Token(Token = "0x2000406")]
internal class Lexer
{
	[Token(Token = "0x2000ACA")]
	private delegate bool StateHandler(FsmContext ctx);

	[Token(Token = "0x4001661")]
	private static int[] fsm_return_table;

	[Token(Token = "0x4001662")]
	private static StateHandler[] fsm_handler_table;

	[Token(Token = "0x4001663")]
	[FieldOffset(Offset = "0x10")]
	private bool allow_comments;

	[Token(Token = "0x4001664")]
	[FieldOffset(Offset = "0x11")]
	private bool allow_single_quoted_strings;

	[FieldOffset(Offset = "0x12")]
	[Token(Token = "0x4001665")]
	private bool end_of_input;

	[Token(Token = "0x4001666")]
	[FieldOffset(Offset = "0x18")]
	private FsmContext fsm_context;

	[Token(Token = "0x4001667")]
	[FieldOffset(Offset = "0x20")]
	private int input_buffer;

	[Token(Token = "0x4001668")]
	[FieldOffset(Offset = "0x24")]
	private int input_char;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001669")]
	private TextReader reader;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400166A")]
	private int state;

	[Token(Token = "0x400166B")]
	[FieldOffset(Offset = "0x38")]
	private StringBuilder string_buffer;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400166C")]
	private string string_value;

	[Token(Token = "0x400166D")]
	[FieldOffset(Offset = "0x48")]
	private int token;

	[Token(Token = "0x400166E")]
	[FieldOffset(Offset = "0x4C")]
	private int unichar;

	[Token(Token = "0x17000469")]
	public bool AllowComments
	{
		[Address(RVA = "0x45CA50", Offset = "0x45B250", Length = "0x5")]
		[Token(Token = "0x60030FD")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60030FE")]
		[Address(RVA = "0x45C980", Offset = "0x45B180", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x1700046A")]
	public bool AllowSingleQuotedStrings
	{
		[Address(RVA = "0x45CA60", Offset = "0x45B260", Length = "0x5")]
		[Token(Token = "0x60030FF")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x45C990", Offset = "0x45B190", Length = "0x4")]
		[Token(Token = "0x6003100")]
		set
		{
		}
	}

	[Token(Token = "0x1700046B")]
	public bool EndOfInput
	{
		[Token(Token = "0x6003101")]
		[Address(RVA = "0x48C7D0", Offset = "0x48AFD0", Length = "0x5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700046C")]
	public int Token
	{
		[Address(RVA = "0x6F3B00", Offset = "0x6F2300", Length = "0x4")]
		[Token(Token = "0x6003102")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700046D")]
	public string StringValue
	{
		[Token(Token = "0x6003103")]
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003104")]
	[Address(RVA = "0x8B9D60", Offset = "0x8B8560", Length = "0x7")]
	static Lexer()
	{
	}

	[Address(RVA = "0x8B9D70", Offset = "0x8B8570", Length = "0xE4")]
	[Token(Token = "0x6003105")]
	public Lexer(TextReader reader)
	{
	}

	[Address(RVA = "0x8B72B0", Offset = "0x8B5AB0", Length = "0x18")]
	[Token(Token = "0x6003106")]
	private static int HexValue(int digit)
	{
		return default(int);
	}

	[Address(RVA = "0x8B75A0", Offset = "0x8B5DA0", Length = "0xF08")]
	[Token(Token = "0x6003107")]
	private static void PopulateFsmTables()
	{
	}

	[Token(Token = "0x6003108")]
	[Address(RVA = "0x8B84B0", Offset = "0x8B6CB0", Length = "0xC2")]
	private static char ProcessEscChar(int esc_char)
	{
		return default(char);
	}

	[Address(RVA = "0x8B8AF0", Offset = "0x8B72F0", Length = "0x26A")]
	[Token(Token = "0x6003109")]
	private static bool State1(FsmContext ctx)
	{
		return default(bool);
	}

	[Address(RVA = "0x8B95C0", Offset = "0x8B7DC0", Length = "0xD1")]
	[Token(Token = "0x600310A")]
	private static bool State2(FsmContext ctx)
	{
		return default(bool);
	}

	[Address(RVA = "0x8B96A0", Offset = "0x8B7EA0", Length = "0x166")]
	[Token(Token = "0x600310B")]
	private static bool State3(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x600310C")]
	[Address(RVA = "0x8B9810", Offset = "0x8B8010", Length = "0x113")]
	private static bool State4(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x600310D")]
	[Address(RVA = "0x8B9930", Offset = "0x8B8130", Length = "0x9F")]
	private static bool State5(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x600310E")]
	[Address(RVA = "0x8B99D0", Offset = "0x8B81D0", Length = "0x137")]
	private static bool State6(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x600310F")]
	[Address(RVA = "0x8B9B10", Offset = "0x8B8310", Length = "0xAD")]
	private static bool State7(FsmContext ctx)
	{
		return default(bool);
	}

	[Address(RVA = "0x8B9BC0", Offset = "0x8B83C0", Length = "0xFD")]
	[Token(Token = "0x6003110")]
	private static bool State8(FsmContext ctx)
	{
		return default(bool);
	}

	[Address(RVA = "0x8B9CC0", Offset = "0x8B84C0", Length = "0x85")]
	[Token(Token = "0x6003111")]
	private static bool State9(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6003112")]
	[Address(RVA = "0x8B8580", Offset = "0x8B6D80", Length = "0x85")]
	private static bool State10(FsmContext ctx)
	{
		return default(bool);
	}

	[Address(RVA = "0x8B8610", Offset = "0x8B6E10", Length = "0x89")]
	[Token(Token = "0x6003113")]
	private static bool State11(FsmContext ctx)
	{
		return default(bool);
	}

	[Address(RVA = "0x8B86A0", Offset = "0x8B6EA0", Length = "0x85")]
	[Token(Token = "0x6003114")]
	private static bool State12(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6003115")]
	[Address(RVA = "0x8B8730", Offset = "0x8B6F30", Length = "0x85")]
	private static bool State13(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6003116")]
	[Address(RVA = "0x8B87C0", Offset = "0x8B6FC0", Length = "0x85")]
	private static bool State14(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6003117")]
	[Address(RVA = "0x8B8610", Offset = "0x8B6E10", Length = "0x89")]
	private static bool State15(FsmContext ctx)
	{
		return default(bool);
	}

	[Address(RVA = "0x8B8850", Offset = "0x8B7050", Length = "0x85")]
	[Token(Token = "0x6003118")]
	private static bool State16(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6003119")]
	[Address(RVA = "0x8B88E0", Offset = "0x8B70E0", Length = "0x85")]
	private static bool State17(FsmContext ctx)
	{
		return default(bool);
	}

	[Address(RVA = "0x8B8970", Offset = "0x8B7170", Length = "0x89")]
	[Token(Token = "0x600311A")]
	private static bool State18(FsmContext ctx)
	{
		return default(bool);
	}

	[Address(RVA = "0x8B8A00", Offset = "0x8B7200", Length = "0xE2")]
	[Token(Token = "0x600311B")]
	private static bool State19(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x600311C")]
	[Address(RVA = "0x8B8D60", Offset = "0x8B7560", Length = "0x89")]
	private static bool State20(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x600311D")]
	[Address(RVA = "0x8B8DF0", Offset = "0x8B75F0", Length = "0x1D7")]
	private static bool State21(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x600311E")]
	[Address(RVA = "0x8B8FD0", Offset = "0x8B77D0", Length = "0x1A0")]
	private static bool State22(FsmContext ctx)
	{
		return default(bool);
	}

	[Address(RVA = "0x8B9180", Offset = "0x8B7980", Length = "0xE2")]
	[Token(Token = "0x600311F")]
	private static bool State23(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6003120")]
	[Address(RVA = "0x8B9270", Offset = "0x8B7A70", Length = "0x90")]
	private static bool State24(FsmContext ctx)
	{
		return default(bool);
	}

	[Address(RVA = "0x8B9310", Offset = "0x8B7B10", Length = "0xA8")]
	[Token(Token = "0x6003121")]
	private static bool State25(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6003122")]
	[Address(RVA = "0x8B93C0", Offset = "0x8B7BC0", Length = "0x92")]
	private static bool State26(FsmContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6003123")]
	[Address(RVA = "0x8B9460", Offset = "0x8B7C60", Length = "0x92")]
	private static bool State27(FsmContext ctx)
	{
		return default(bool);
	}

	[Address(RVA = "0x8B9500", Offset = "0x8B7D00", Length = "0xB8")]
	[Token(Token = "0x6003124")]
	private static bool State28(FsmContext ctx)
	{
		return default(bool);
	}

	[Address(RVA = "0x8B7250", Offset = "0x8B5A50", Length = "0x53")]
	[Token(Token = "0x6003125")]
	private bool GetChar()
	{
		return default(bool);
	}

	[Address(RVA = "0x8B7350", Offset = "0x8B5B50", Length = "0x3A")]
	[Token(Token = "0x6003126")]
	private int NextChar()
	{
		return default(int);
	}

	[Token(Token = "0x6003127")]
	[Address(RVA = "0x8B7390", Offset = "0x8B5B90", Length = "0x204")]
	public bool NextToken()
	{
		return default(bool);
	}

	[Token(Token = "0x6003128")]
	[Address(RVA = "0x8B9D50", Offset = "0x8B8550", Length = "0x7")]
	private void UngetChar()
	{
	}
}
