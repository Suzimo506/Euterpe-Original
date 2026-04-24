namespace System.Diagnostics.Tracing;

internal sealed class NameInfo : ConcurrentSetItem<KeyValuePair`2<String, EventTags>, NameInfo>
{
	private static int lastIdentity; //Field offset: 0x0
	internal readonly string name; //Field offset: 0x10
	internal readonly EventTags tags; //Field offset: 0x18
	internal readonly int identity; //Field offset: 0x1C
	internal readonly Byte[] nameMetadata; //Field offset: 0x20

	private static NameInfo() { }

	public NameInfo(string name, EventTags tags, int typeMetadataSize) { }

	public virtual int Compare(NameInfo other) { }

	public virtual int Compare(KeyValuePair<String, EventTags> key) { }

	private int Compare(string otherName, EventTags otherTags) { }

	internal static void ReserveEventIDsBelow(int eventId) { }

}

