namespace Discord;

public struct ImageHandle
{
	public ImageType Type; //Field offset: 0x0
	public long Id; //Field offset: 0x8
	public uint Size; //Field offset: 0x10

	public static ImageHandle User(long id) { }

	public static ImageHandle User(long id, uint size) { }

}

