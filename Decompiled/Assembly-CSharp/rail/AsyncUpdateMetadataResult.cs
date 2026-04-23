using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003A0")]
public class AsyncUpdateMetadataResult : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001507")]
	public EnumRailSpaceWorkType type;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001508")]
	public SpaceWorkID id;

	[Token(Token = "0x6002F53")]
	[Address(RVA = "0xD1F7B0", Offset = "0xD1DFB0", Length = "0x64")]
	public AsyncUpdateMetadataResult()
	{
	}
}
