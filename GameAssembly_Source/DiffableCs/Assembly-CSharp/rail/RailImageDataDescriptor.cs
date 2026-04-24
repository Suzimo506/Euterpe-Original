namespace rail;

public class RailImageDataDescriptor
{
	public EnumRailImagePixelFormat pixel_format; //Field offset: 0x10
	public uint image_height; //Field offset: 0x14
	public uint stride_in_bytes; //Field offset: 0x18
	public uint image_width; //Field offset: 0x1C
	public uint bits_per_pixel; //Field offset: 0x20

	public RailImageDataDescriptor() { }

}

