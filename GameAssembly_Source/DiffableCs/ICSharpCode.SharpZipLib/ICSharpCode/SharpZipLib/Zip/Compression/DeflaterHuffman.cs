namespace ICSharpCode.SharpZipLib.Zip.Compression;

public class DeflaterHuffman
{
	private static readonly Int32[] BL_ORDER; //Field offset: 0x0
	private static readonly Byte[] bit4Reverse; //Field offset: 0x8
	private static Int16[] staticLCodes; //Field offset: 0x10
	private static Byte[] staticLLength; //Field offset: 0x18
	private static Int16[] staticDCodes; //Field offset: 0x20
	private static Byte[] staticDLength; //Field offset: 0x28

	private static DeflaterHuffman() { }

	public static short BitReverse(int toReverse) { }

}

