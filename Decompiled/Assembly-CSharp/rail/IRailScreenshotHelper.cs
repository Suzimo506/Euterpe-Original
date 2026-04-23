using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000368")]
public interface IRailScreenshotHelper
{
	[Token(Token = "0x6002E9D")]
	[Address(RVA = "0x0", Length = "0x0")]
	IRailScreenshot CreateScreenshotWithRawData(byte[] rgb_data, uint len, uint width, uint height);

	[Token(Token = "0x6002E9E")]
	[Address(RVA = "0x0", Length = "0x0")]
	IRailScreenshot CreateScreenshotWithLocalImage(string image_file, string thumbnail_file);

	[Token(Token = "0x6002E9F")]
	[Address(RVA = "0x0", Length = "0x0")]
	void AsyncTakeScreenshot(string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002EA0")]
	void HookScreenshotHotKey(bool hook);

	[Token(Token = "0x6002EA1")]
	[Address(RVA = "0x0", Length = "0x0")]
	bool IsScreenshotHotKeyHooked();
}
