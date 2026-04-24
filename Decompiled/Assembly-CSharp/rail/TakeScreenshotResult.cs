using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200036B")]
public class TakeScreenshotResult : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400149B")]
	public uint thumbnail_file_size;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400149C")]
	public string thumbnail_filepath;

	[Token(Token = "0x400149D")]
	[FieldOffset(Offset = "0x40")]
	public uint image_file_size;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400149E")]
	public string image_file_path;

	[Token(Token = "0x6002EA4")]
	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	public TakeScreenshotResult()
	{
	}
}
