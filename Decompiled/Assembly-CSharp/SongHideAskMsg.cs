using Cpp2ILInjected;

[Token(Token = "0x20000D2")]
public class SongHideAskMsg : BaseMessageBox
{
	[Address(RVA = "0x62FF10", Offset = "0x62E710", Length = "0x1D")]
	[Token(Token = "0x60005DE")]
	public override void AwakeInit()
	{
	}

	[Token(Token = "0x60005DF")]
	[Address(RVA = "0x62FF30", Offset = "0x62E730", Length = "0xFC")]
	public override void SetSetting(string key, int value)
	{
	}

	[Token(Token = "0x60005E0")]
	[Address(RVA = "0x4C6980", Offset = "0x4C5180", Length = "0x7")]
	public SongHideAskMsg()
	{
	}
}
