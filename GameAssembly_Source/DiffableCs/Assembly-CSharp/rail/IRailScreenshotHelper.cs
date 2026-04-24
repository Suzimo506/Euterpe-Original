namespace rail;

public interface IRailScreenshotHelper
{

	public void AsyncTakeScreenshot(string user_data) { }

	public IRailScreenshot CreateScreenshotWithLocalImage(string image_file, string thumbnail_file) { }

	public IRailScreenshot CreateScreenshotWithRawData(Byte[] rgb_data, uint len, uint width, uint height) { }

	public void HookScreenshotHotKey(bool hook) { }

	public bool IsScreenshotHotKeyHooked() { }

}

