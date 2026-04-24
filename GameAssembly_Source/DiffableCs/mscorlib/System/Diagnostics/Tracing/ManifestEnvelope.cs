namespace System.Diagnostics.Tracing;

internal struct ManifestEnvelope
{
	internal enum ManifestFormats
	{
		SimpleXmlFormat = 1,
	}

	public ManifestFormats Format; //Field offset: 0x0
	public byte MajorVersion; //Field offset: 0x1
	public byte MinorVersion; //Field offset: 0x2
	public byte Magic; //Field offset: 0x3
	public ushort TotalChunks; //Field offset: 0x4
	public ushort ChunkNumber; //Field offset: 0x6

}

