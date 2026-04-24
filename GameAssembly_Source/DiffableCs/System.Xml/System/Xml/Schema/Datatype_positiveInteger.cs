namespace System.Xml.Schema;

internal class Datatype_positiveInteger : Datatype_nonNegativeInteger
{
	private static readonly FacetsChecker numeric10FacetsChecker; //Field offset: 0x6A690

	internal virtual FacetsChecker FacetsChecker
	{
		internal get { } //Length: 86
	}

	public virtual XmlTypeCode TypeCode
	{
		 get { } //Length: 6
	}

	private static Datatype_positiveInteger() { }

	public Datatype_positiveInteger() { }

	internal virtual FacetsChecker get_FacetsChecker() { }

	public virtual XmlTypeCode get_TypeCode() { }

}

