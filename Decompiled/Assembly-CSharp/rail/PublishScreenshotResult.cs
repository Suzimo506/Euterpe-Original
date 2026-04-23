using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000369")]
public class PublishScreenshotResult : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400149A")]
	public SpaceWorkID work_id;

	[Address(RVA = "0x37E9B0", Offset = "0x37D1B0", Length = "0x64")]
	[Token(Token = "0x6002EA2")]
	public PublishScreenshotResult()
	{
	}
}
