namespace rail;

public class TakeScreenshotResult : EventBase
{
	public uint thumbnail_file_size; //Field offset: 0x30
	public string thumbnail_filepath; //Field offset: 0x38
	public uint image_file_size; //Field offset: 0x40
	public string image_file_path; //Field offset: 0x48

	public TakeScreenshotResult() { }

}

