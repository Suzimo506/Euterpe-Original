using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Cpp2ILInjected;

namespace LitJson;

[Token(Token = "0x2000404")]
public class JsonWriter
{
	[Token(Token = "0x4001652")]
	private static NumberFormatInfo number_format;

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001653")]
	private WriterContext context;

	[Token(Token = "0x4001654")]
	[FieldOffset(Offset = "0x18")]
	private Stack<WriterContext> ctx_stack;

	[Token(Token = "0x4001655")]
	[FieldOffset(Offset = "0x20")]
	private bool has_reached_end;

	[Token(Token = "0x4001656")]
	[FieldOffset(Offset = "0x28")]
	private char[] hex_seq;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001657")]
	private int indentation;

	[Token(Token = "0x4001658")]
	[FieldOffset(Offset = "0x34")]
	private int indent_value;

	[Token(Token = "0x4001659")]
	[FieldOffset(Offset = "0x38")]
	private StringBuilder inst_string_builder;

	[Token(Token = "0x400165A")]
	[FieldOffset(Offset = "0x40")]
	private bool pretty_print;

	[Token(Token = "0x400165B")]
	[FieldOffset(Offset = "0x41")]
	private bool validate;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400165C")]
	private TextWriter writer;

	[Token(Token = "0x17000465")]
	public int IndentValue
	{
		[Token(Token = "0x60030DA")]
		[Address(RVA = "0x597000", Offset = "0x595800", Length = "0x4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60030DB")]
		[Address(RVA = "0x8B7230", Offset = "0x8B5A30", Length = "0x16")]
		set
		{
		}
	}

	[Token(Token = "0x17000466")]
	public bool PrettyPrint
	{
		[Token(Token = "0x60030DC")]
		[Address(RVA = "0x47F9B0", Offset = "0x47E1B0", Length = "0x5")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60030DD")]
		[Address(RVA = "0x785C60", Offset = "0x784460", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x17000467")]
	public TextWriter TextWriter
	{
		[Token(Token = "0x60030DE")]
		[Address(RVA = "0x46EF30", Offset = "0x46D730", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000468")]
	public bool Validate
	{
		[Token(Token = "0x60030DF")]
		[Address(RVA = "0x5F9A70", Offset = "0x5F8270", Length = "0x5")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60030E0")]
		[Address(RVA = "0x5F9A80", Offset = "0x5F8280", Length = "0x4")]
		set
		{
		}
	}

	[Address(RVA = "0x8B6FD0", Offset = "0x8B57D0", Length = "0x43")]
	[Token(Token = "0x60030E1")]
	static JsonWriter()
	{
	}

	[Token(Token = "0x60030E2")]
	[Address(RVA = "0x8B7020", Offset = "0x8B5820", Length = "0xA9")]
	public JsonWriter()
	{
	}

	[Address(RVA = "0x8B70D0", Offset = "0x8B58D0", Length = "0xCF")]
	[Token(Token = "0x60030E3")]
	public JsonWriter(StringBuilder sb)
	{
	}

	[Address(RVA = "0x8B71A0", Offset = "0x8B59A0", Length = "0x8D")]
	[Token(Token = "0x60030E4")]
	public JsonWriter(TextWriter writer)
	{
	}

	[Address(RVA = "0x8B52E0", Offset = "0x8B3AE0", Length = "0x257")]
	[Token(Token = "0x60030E5")]
	private void DoValidation(Condition cond)
	{
	}

	[Token(Token = "0x60030E6")]
	[Address(RVA = "0x8B5550", Offset = "0x8B3D50", Length = "0xE9")]
	private void Init()
	{
	}

	[Address(RVA = "0x8B5640", Offset = "0x8B3E40", Length = "0x88")]
	[Token(Token = "0x60030E7")]
	private static void IntToHex(int n, char[] hex)
	{
	}

	[Token(Token = "0x60030E8")]
	[Address(RVA = "0x8B5540", Offset = "0x8B3D40", Length = "0xD")]
	private void Indent()
	{
	}

	[Token(Token = "0x60030E9")]
	[Address(RVA = "0x8B5B80", Offset = "0x8B4380", Length = "0x87")]
	private void Put(string str)
	{
	}

	[Token(Token = "0x60030EA")]
	[Address(RVA = "0x8B56D0", Offset = "0x8B3ED0", Length = "0x80")]
	private void PutNewline()
	{
	}

	[Token(Token = "0x60030EB")]
	[Address(RVA = "0x8B5760", Offset = "0x8B3F60", Length = "0x84")]
	private void PutNewline(bool add_comma)
	{
	}

	[Address(RVA = "0x8B57F0", Offset = "0x8B3FF0", Length = "0x370")]
	[Token(Token = "0x60030EC")]
	private void PutString(string str)
	{
	}

	[Token(Token = "0x60030ED")]
	[Address(RVA = "0x8B5D40", Offset = "0x8B4540", Length = "0xD")]
	private void Unindent()
	{
	}

	[Token(Token = "0x60030EE")]
	[Address(RVA = "0x8B5CE0", Offset = "0x8B44E0", Length = "0x5A")]
	public override string ToString()
	{
		return null;
	}

	[Address(RVA = "0x8B5C10", Offset = "0x8B4410", Length = "0xC5")]
	[Token(Token = "0x60030EF")]
	public void Reset()
	{
	}

	[Address(RVA = "0x8B6850", Offset = "0x8B5050", Length = "0x129")]
	[Token(Token = "0x60030F0")]
	public void Write(bool boolean)
	{
	}

	[Address(RVA = "0x8B6B70", Offset = "0x8B5370", Length = "0x1F5")]
	[Token(Token = "0x60030F1")]
	public void Write(decimal number)
	{
	}

	[Token(Token = "0x60030F2")]
	[Address(RVA = "0x8B6D70", Offset = "0x8B5570", Length = "0x251")]
	public void Write(double number)
	{
	}

	[Address(RVA = "0x8B6660", Offset = "0x8B4E60", Length = "0x1E5")]
	[Token(Token = "0x60030F3")]
	public void Write(int number)
	{
	}

	[Address(RVA = "0x8B6470", Offset = "0x8B4C70", Length = "0x1E5")]
	[Token(Token = "0x60030F4")]
	public void Write(long number)
	{
	}

	[Address(RVA = "0x8B62C0", Offset = "0x8B4AC0", Length = "0x1A5")]
	[Token(Token = "0x60030F5")]
	public void Write(string str)
	{
	}

	[Address(RVA = "0x8B6980", Offset = "0x8B5180", Length = "0x1E5")]
	[Token(Token = "0x60030F6")]
	public void Write(ulong number)
	{
	}

	[Token(Token = "0x60030F7")]
	[Address(RVA = "0x8B5D50", Offset = "0x8B4550", Length = "0xF1")]
	public void WriteArrayEnd()
	{
	}

	[Token(Token = "0x60030F8")]
	[Address(RVA = "0x8B5E50", Offset = "0x8B4650", Length = "0xC8")]
	public void WriteArrayStart()
	{
	}

	[Token(Token = "0x60030F9")]
	[Address(RVA = "0x8B5F20", Offset = "0x8B4720", Length = "0xF3")]
	public void WriteObjectEnd()
	{
	}

	[Address(RVA = "0x8B6020", Offset = "0x8B4820", Length = "0xC8")]
	[Token(Token = "0x60030FA")]
	public void WriteObjectStart()
	{
	}

	[Token(Token = "0x60030FB")]
	[Address(RVA = "0x8B60F0", Offset = "0x8B48F0", Length = "0x1C9")]
	public void WritePropertyName(string property_name)
	{
	}
}
