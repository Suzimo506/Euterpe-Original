namespace rail;

public class RailGetImageDataResult : EventBase
{
	public List<Byte> image_data; //Field offset: 0x30
	public RailImageDataDescriptor image_data_descriptor; //Field offset: 0x38

	public RailGetImageDataResult() { }

}

