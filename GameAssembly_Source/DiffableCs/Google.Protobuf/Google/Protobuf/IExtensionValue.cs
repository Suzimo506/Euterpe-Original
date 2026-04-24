namespace Google.Protobuf;

internal interface IExtensionValue : IEquatable<IExtensionValue>, IDeepCloneable<IExtensionValue>
{

	public int CalculateSize() { }

	public void MergeFrom(ref ParseContext ctx) { }

	public void MergeFrom(IExtensionValue value) { }

	public void WriteTo(ref WriteContext ctx) { }

}

