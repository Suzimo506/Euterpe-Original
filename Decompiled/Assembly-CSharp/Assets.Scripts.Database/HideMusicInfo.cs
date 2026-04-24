using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007D5")]
public class HideMusicInfo : BaseDataObject
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002932")]
	public string musicUid;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002933")]
	public int invokeType;

	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4002934")]
	public int diffIndex;

	[Token(Token = "0x4002935")]
	[FieldOffset(Offset = "0x30")]
	public int changedIndex;

	[Token(Token = "0x4002936")]
	[FieldOffset(Offset = "0x34")]
	public int handleType;

	[Token(Token = "0x1700070C")]
	public HideMapInvokeType HideMapInvokeType
	{
		[Token(Token = "0x60047D5")]
		[Address(RVA = "0x49EAA0", Offset = "0x49D2A0", Length = "0x4")]
		get
		{
			return default(HideMapInvokeType);
		}
	}

	[Token(Token = "0x60047D6")]
	[Address(RVA = "0x49EA80", Offset = "0x49D280", Length = "0x15")]
	public HideMusicInfo()
	{
	}
}
