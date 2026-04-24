using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200037D")]
public class AsyncListFileResult : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40014AE")]
	public List<RailStreamFileInfo> file_list;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40014AF")]
	public uint try_list_file_num;

	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40014B0")]
	public uint all_file_num;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40014B1")]
	public uint start_index;

	[Address(RVA = "0xD1F3D0", Offset = "0xD1DBD0", Length = "0x69")]
	[Token(Token = "0x6002EE8")]
	public AsyncListFileResult()
	{
	}
}
