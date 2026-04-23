using Assets.Scripts.Database;
using Cpp2ILInjected;

[Token(Token = "0x2000160")]
public class HeadItemData
{
	[Token(Token = "0x40008AE")]
	[FieldOffset(Offset = "0x10")]
	public HeadInfo headInfo;

	[Token(Token = "0x170000D9")]
	public bool isUnLock
	{
		[Address(RVA = "0x5C3F10", Offset = "0x5C2710", Length = "0x65")]
		[Token(Token = "0x6000A1C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000DA")]
	public bool isHeadNew
	{
		[Address(RVA = "0x5C3EA0", Offset = "0x5C26A0", Length = "0x65")]
		[Token(Token = "0x6000A1D")]
		get
		{
			return default(bool);
		}
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6000A1E")]
	public HeadItemData()
	{
	}
}
