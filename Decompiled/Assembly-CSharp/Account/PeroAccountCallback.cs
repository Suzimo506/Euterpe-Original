using Cpp2ILInjected;
using PeroTools2.Account;

namespace Account;

[Token(Token = "0x2000562")]
public class PeroAccountCallback : AccountCallback
{
	[Address(RVA = "0x77B030", Offset = "0x779830", Length = "0x318")]
	[Token(Token = "0x60037CF")]
	public override void OnSucceed(string res)
	{
	}

	[Token(Token = "0x60037D0")]
	[Address(RVA = "0x77AF70", Offset = "0x779770", Length = "0xBA")]
	public override void OnFailed(int code, string msg)
	{
	}

	[Token(Token = "0x60037D1")]
	[Address(RVA = "0x59E710", Offset = "0x59CF10", Length = "0x23")]
	public override void OnStarted()
	{
	}

	[Address(RVA = "0x59E690", Offset = "0x59CE90", Length = "0x23")]
	[Token(Token = "0x60037D2")]
	public override void OnCompleted()
	{
	}

	[Address(RVA = "0x441AE0", Offset = "0x4402E0", Length = "0x7")]
	[Token(Token = "0x60037D3")]
	public PeroAccountCallback()
	{
	}
}
