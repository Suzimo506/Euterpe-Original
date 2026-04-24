namespace Steamworks;

public struct PublishedFileId_t : IEquatable<PublishedFileId_t>, IComparable<PublishedFileId_t>
{
	public static readonly PublishedFileId_t Invalid; //Field offset: 0x0
	public ulong m_PublishedFileId; //Field offset: 0x0

	private static PublishedFileId_t() { }

	public PublishedFileId_t(ulong value) { }

	public override int CompareTo(PublishedFileId_t other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(PublishedFileId_t other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(PublishedFileId_t x, PublishedFileId_t y) { }

	public static PublishedFileId_t op_Explicit(ulong value) { }

	public static ulong op_Explicit(PublishedFileId_t that) { }

	public static bool op_Inequality(PublishedFileId_t x, PublishedFileId_t y) { }

	public virtual string ToString() { }

}

