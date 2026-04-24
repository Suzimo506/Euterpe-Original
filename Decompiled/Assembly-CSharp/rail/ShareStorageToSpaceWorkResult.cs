using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200038B")]
public class ShareStorageToSpaceWorkResult : EventBase
{
	[Token(Token = "0x40014DC")]
	[FieldOffset(Offset = "0x30")]
	public SpaceWorkID space_work_id;

	[Token(Token = "0x6002EF4")]
	[Address(RVA = "0x2722240", Offset = "0x2720A40", Length = "0x9D")]
	public ShareStorageToSpaceWorkResult()
	{
	}
}
