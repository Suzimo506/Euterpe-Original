namespace Google.Protobuf;

public static class ExtensionSet
{

	public static ExtensionSet<TTarget> Clone(ExtensionSet<TTarget> set) { }

	public static void MergeFrom(ref ExtensionSet<TTarget>& first, ExtensionSet<TTarget> second) { }

	public static bool TryMergeFieldFrom(ref ExtensionSet<TTarget>& set, ref ParseContext ctx) { }

}

