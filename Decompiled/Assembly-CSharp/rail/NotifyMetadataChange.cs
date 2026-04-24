using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000353")]
public class NotifyMetadataChange : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400145A")]
	public RailID changer_id;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400145B")]
	public ulong room_id;

	[Token(Token = "0x6002E85")]
	[Address(RVA = "0x37E6B0", Offset = "0x37CEB0", Length = "0x64")]
	public NotifyMetadataChange()
	{
	}
}
