using System;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000250")]
public class IRailScreenshotHelperImpl : RailObject, IRailScreenshotHelper
{
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	[Token(Token = "0x6002906")]
	internal IRailScreenshotHelperImpl(IntPtr cPtr)
	{
	}

	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	[Token(Token = "0x6002907")]
	~IRailScreenshotHelperImpl()
	{
	}

	[Token(Token = "0x6002908")]
	[Address(RVA = "0x36DB90", Offset = "0x36C390", Length = "0x13D")]
	public virtual IRailScreenshot CreateScreenshotWithRawData(byte[] rgb_data, uint len, uint width, uint height)
	{
		return null;
	}

	[Token(Token = "0x6002909")]
	[Address(RVA = "0x36DA50", Offset = "0x36C250", Length = "0x13E")]
	public virtual IRailScreenshot CreateScreenshotWithLocalImage(string image_file, string thumbnail_file)
	{
		return null;
	}

	[Address(RVA = "0x36D960", Offset = "0x36C160", Length = "0xE2")]
	[Token(Token = "0x600290A")]
	public virtual void AsyncTakeScreenshot(string user_data)
	{
	}

	[Token(Token = "0x600290B")]
	[Address(RVA = "0x36DCD0", Offset = "0x36C4D0", Length = "0xC3")]
	public virtual void HookScreenshotHotKey(bool hook)
	{
	}

	[Token(Token = "0x600290C")]
	[Address(RVA = "0x36DDA0", Offset = "0x36C5A0", Length = "0xBA")]
	public virtual bool IsScreenshotHotKeyHooked()
	{
		return default(bool);
	}
}
