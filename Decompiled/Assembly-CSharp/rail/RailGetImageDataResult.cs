using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003D3")]
public class RailGetImageDataResult : EventBase
{
	[Token(Token = "0x40015B5")]
	[FieldOffset(Offset = "0x30")]
	public List<byte> image_data;

	[Token(Token = "0x40015B6")]
	[FieldOffset(Offset = "0x38")]
	public RailImageDataDescriptor image_data_descriptor;

	[Token(Token = "0x6002F8B")]
	[Address(RVA = "0x27207A0", Offset = "0x271EFA0", Length = "0x91")]
	public RailGetImageDataResult()
	{
	}
}
