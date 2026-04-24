namespace NAudio.Wave;

public class XingHeader
{
	[Flags]
	private enum XingHeaderOptions
	{
		Frames = 1,
		Bytes = 2,
		Toc = 4,
		VbrScale = 8,
	}

	private static Int32[] sr_table; //Field offset: 0x0
	private int vbrScale; //Field offset: 0x10
	private int startOffset; //Field offset: 0x14
	private int endOffset; //Field offset: 0x18
	private int tocOffset; //Field offset: 0x1C
	private int framesOffset; //Field offset: 0x20
	private int bytesOffset; //Field offset: 0x24
	private Mp3Frame frame; //Field offset: 0x28

	private static XingHeader() { }

	private XingHeader() { }

	public static XingHeader LoadXingHeader(Mp3Frame frame) { }

	private static int ReadBigEndian(Byte[] buffer, int offset) { }

}

