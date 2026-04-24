//Type is in global namespace

public class UTF8Marshaler : ICustomMarshaler
{
	private static UTF8Marshaler instance_; //Field offset: 0x65229

	public UTF8Marshaler() { }

	public override void CleanUpManagedData(object obj) { }

	public override void CleanUpNativeData(IntPtr data) { }

	public static ICustomMarshaler GetInstance(string cookie) { }

	public override int GetNativeDataSize() { }

	public override IntPtr MarshalManagedToNative(object obj) { }

	public override object MarshalNativeToManaged(IntPtr data) { }

	public static string MarshalNativeToString(IntPtr data) { }

}

