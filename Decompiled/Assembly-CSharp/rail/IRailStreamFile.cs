using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200037B")]
public interface IRailStreamFile : IRailComponent
{
	[Token(Token = "0x6002EE1")]
	[Address(RVA = "0x0", Length = "0x0")]
	string GetFilename();

	[Token(Token = "0x6002EE2")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncRead(int offset, uint bytes_to_read, string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002EE3")]
	RailResult AsyncWrite(byte[] buff, uint bytes_to_write, string user_data);

	[Token(Token = "0x6002EE4")]
	[Address(RVA = "0x0", Length = "0x0")]
	ulong GetSize();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002EE5")]
	RailResult Close();

	[Token(Token = "0x6002EE6")]
	[Address(RVA = "0x0", Length = "0x0")]
	void Cancel();
}
