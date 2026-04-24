namespace System.ComponentModel;

public class Win32Exception : ExternalException, ISerializable
{
	private static bool s_ErrorMessagesInitialized; //Field offset: 0x0
	private static Dictionary<Int32, String> s_ErrorMessage; //Field offset: 0x8
	private readonly int nativeErrorCode; //Field offset: 0x88

	public int NativeErrorCode
	{
		 get { } //Length: 7
	}

	private static Win32Exception() { }

	public Win32Exception() { }

	public Win32Exception(int error) { }

	public Win32Exception(int error, string message) { }

	public Win32Exception(string message) { }

	public Win32Exception(string message, Exception innerException) { }

	protected Win32Exception(SerializationInfo info, StreamingContext context) { }

	public int get_NativeErrorCode() { }

	internal static string GetErrorMessage(int error) { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private static void InitializeErrorMessages() { }

}

