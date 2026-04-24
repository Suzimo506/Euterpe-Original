using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200038A")]
public class RailSyncFileOption
{
	[Token(Token = "0x40014DB")]
	[FieldOffset(Offset = "0x10")]
	public bool sync_file_not_to_remote;

	[Token(Token = "0x6002EF3")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public RailSyncFileOption()
	{
	}
}
