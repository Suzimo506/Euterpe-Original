using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003B6")]
public class RailUserSpaceDownloadResult
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001570")]
	public string err_msg;

	[Token(Token = "0x4001571")]
	[FieldOffset(Offset = "0x18")]
	public ulong finished_bytes;

	[Token(Token = "0x4001572")]
	[FieldOffset(Offset = "0x20")]
	public uint finished_files;

	[Token(Token = "0x4001573")]
	[FieldOffset(Offset = "0x28")]
	public ulong total_bytes;

	[Token(Token = "0x4001574")]
	[FieldOffset(Offset = "0x30")]
	public uint total_files;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001575")]
	public SpaceWorkID id;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001576")]
	public uint err_code;

	[Token(Token = "0x6002F5E")]
	[Address(RVA = "0x27216B0", Offset = "0x271FEB0", Length = "0x9D")]
	public RailUserSpaceDownloadResult()
	{
	}
}
