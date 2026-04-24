using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200037E")]
public class AsyncQueryQuotaResult : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40014B2")]
	public ulong available_quota;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40014B3")]
	public ulong total_quota;

	[Token(Token = "0x6002EE9")]
	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	public AsyncQueryQuotaResult()
	{
	}
}
