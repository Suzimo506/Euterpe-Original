namespace Google.Protobuf;

public static class ProtoPreconditions
{

	public static T CheckNotNull(T value, string name) { }

	internal static T CheckNotNullUnconstrained(T value, string name) { }

}

