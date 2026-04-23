using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007D0")]
public class HeadInfo : BaseDataObject
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002921")]
	public string image;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002922")]
	public string unlockTip;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002923")]
	public string hexieImage;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002924")]
	public HeadGetChannel getChannel;

	[Token(Token = "0x4002925")]
	[FieldOffset(Offset = "0x40")]
	public string albumUid;

	[Token(Token = "0x4002926")]
	[FieldOffset(Offset = "0x48")]
	public string achUid;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4002927")]
	public int unlockLevel;

	[Token(Token = "0x17000708")]
	public string getImageName
	{
		[Token(Token = "0x60047C5")]
		[Address(RVA = "0x49E8F0", Offset = "0x49D0F0", Length = "0xCD")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000709")]
	public string getUnlocktips
	{
		[Token(Token = "0x60047C6")]
		[Address(RVA = "0x49E9C0", Offset = "0x49D1C0", Length = "0xB4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60047C7")]
	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	public HeadInfo()
	{
	}
}
