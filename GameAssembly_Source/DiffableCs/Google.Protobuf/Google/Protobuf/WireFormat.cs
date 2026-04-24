namespace Google.Protobuf;

public static class WireFormat
{
	internal enum WireType
	{
		Varint = 0,
		Fixed64 = 1,
		LengthDelimited = 2,
		StartGroup = 3,
		EndGroup = 4,
		Fixed32 = 5,
	}


	public static int GetTagFieldNumber(uint tag) { }

	public static WireType GetTagWireType(uint tag) { }

	public static uint MakeTag(int fieldNumber, WireType wireType) { }

}

