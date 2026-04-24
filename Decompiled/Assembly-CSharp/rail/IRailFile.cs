using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000379")]
public interface IRailFile : IRailComponent
{
	[Token(Token = "0x6002EC1")]
	[Address(RVA = "0x0", Length = "0x0")]
	string GetFilename();

	[Token(Token = "0x6002EC2")]
	[Address(RVA = "0x0", Length = "0x0")]
	uint Read(byte[] buff, uint bytes_to_read, out RailResult result);

	[Token(Token = "0x6002EC3")]
	[Address(RVA = "0x0", Length = "0x0")]
	uint Read(byte[] buff, uint bytes_to_read);

	[Token(Token = "0x6002EC4")]
	[Address(RVA = "0x0", Length = "0x0")]
	uint Write(byte[] buff, uint bytes_to_write, out RailResult result);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002EC5")]
	uint Write(byte[] buff, uint bytes_to_write);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002EC6")]
	RailResult AsyncRead(uint bytes_to_read, string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002EC7")]
	RailResult AsyncWrite(byte[] buffer, uint bytes_to_write, string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002EC8")]
	uint GetSize();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002EC9")]
	void Close();
}
