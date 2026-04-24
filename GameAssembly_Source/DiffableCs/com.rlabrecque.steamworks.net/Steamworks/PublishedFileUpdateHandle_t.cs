namespace Steamworks;

public struct PublishedFileUpdateHandle_t : IEquatable<PublishedFileUpdateHandle_t>, IComparable<PublishedFileUpdateHandle_t>
{
	public static readonly PublishedFileUpdateHandle_t Invalid; //Field offset: 0x0
	public ulong m_PublishedFileUpdateHandle; //Field offset: 0x0

	private static PublishedFileUpdateHandle_t() { }

	public PublishedFileUpdateHandle_t(ulong value) { }

	public override int CompareTo(PublishedFileUpdateHandle_t other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(PublishedFileUpdateHandle_t other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(PublishedFileUpdateHandle_t x, PublishedFileUpdateHandle_t y) { }

	public static PublishedFileUpdateHandle_t op_Explicit(ulong value) { }

	public static ulong op_Explicit(PublishedFileUpdateHandle_t that) { }

	public static bool op_Inequality(PublishedFileUpdateHandle_t x, PublishedFileUpdateHandle_t y) { }

	public virtual string ToString() { }

}

