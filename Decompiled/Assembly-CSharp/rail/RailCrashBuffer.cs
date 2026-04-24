using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003CE")]
public interface RailCrashBuffer
{
	[Token(Token = "0x6002F82")]
	[Address(RVA = "0x0", Length = "0x0")]
	string GetData();

	[Token(Token = "0x6002F83")]
	[Address(RVA = "0x0", Length = "0x0")]
	uint GetBufferLength();

	[Token(Token = "0x6002F84")]
	[Address(RVA = "0x0", Length = "0x0")]
	uint GetValidLength();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F85")]
	uint SetData(string data, uint length, uint offset);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F86")]
	uint SetData(string data, uint length);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F87")]
	uint AppendData(string data, uint length);
}
