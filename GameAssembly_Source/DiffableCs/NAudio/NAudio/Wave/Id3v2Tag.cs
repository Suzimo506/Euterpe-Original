namespace NAudio.Wave;

public class Id3v2Tag
{
	private long tagStartPosition; //Field offset: 0x10
	private long tagEndPosition; //Field offset: 0x18
	private Byte[] rawData; //Field offset: 0x20

	private Id3v2Tag(Stream input) { }

	public static Id3v2Tag ReadTag(Stream input) { }

}

