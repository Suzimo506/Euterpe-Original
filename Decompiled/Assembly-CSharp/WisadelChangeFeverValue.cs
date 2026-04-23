using Cpp2ILInjected;

[Token(Token = "0x20001A0")]
public class WisadelChangeFeverValue : ChangeFeverValue
{
	[Address(RVA = "0xD32990", Offset = "0xD31190", Length = "0x86")]
	[Token(Token = "0x6000BD1")]
	protected override void OnFever()
	{
	}

	[Address(RVA = "0xD327D0", Offset = "0xD30FD0", Length = "0x86")]
	[Token(Token = "0x6000BD2")]
	protected override void OnFeverMax()
	{
	}

	[Address(RVA = "0xD32860", Offset = "0xD31060", Length = "0x12E")]
	[Token(Token = "0x6000BD3")]
	protected override void OnFeverRateChange()
	{
	}

	[Token(Token = "0x6000BD4")]
	[Address(RVA = "0x4248F0", Offset = "0x4230F0", Length = "0x7")]
	public WisadelChangeFeverValue()
	{
	}
}
