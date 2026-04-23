using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003B2")]
public class RailSpaceWorkSyncProgress
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400155F")]
	public float progress;

	[Token(Token = "0x4001560")]
	[FieldOffset(Offset = "0x18")]
	public ulong finished_bytes;

	[Token(Token = "0x4001561")]
	[FieldOffset(Offset = "0x20")]
	public ulong total_bytes;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001562")]
	public EnumRailSpaceWorkSyncState current_state;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6002F5A")]
	public RailSpaceWorkSyncProgress()
	{
	}
}
