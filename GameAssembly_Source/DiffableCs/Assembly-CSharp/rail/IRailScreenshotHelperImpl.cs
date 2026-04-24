namespace rail;

public class IRailScreenshotHelperImpl : RailObject, IRailScreenshotHelper
{

	internal IRailScreenshotHelperImpl(IntPtr cPtr) { }

	public override void AsyncTakeScreenshot(string user_data) { }

	public override IRailScreenshot CreateScreenshotWithLocalImage(string image_file, string thumbnail_file) { }

	public override IRailScreenshot CreateScreenshotWithRawData(Byte[] rgb_data, uint len, uint width, uint height) { }

	protected virtual void Finalize() { }

	public override void HookScreenshotHotKey(bool hook) { }

	public override bool IsScreenshotHotKeyHooked() { }

}

