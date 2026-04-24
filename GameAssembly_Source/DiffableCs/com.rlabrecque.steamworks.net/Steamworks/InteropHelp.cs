namespace Steamworks;

public class InteropHelp
{
	internal class SteamParamStringArray
	{
		private IntPtr[] m_Strings; //Field offset: 0x10
		private IntPtr m_ptrStrings; //Field offset: 0x18
		private IntPtr m_pSteamParamStringArray; //Field offset: 0x20

		public SteamParamStringArray(IList<String> strings) { }

		protected virtual void Finalize() { }

		public static IntPtr op_Implicit(SteamParamStringArray that) { }

	}

	internal class UTF8StringHandle : SafeHandleZeroOrMinusOneIsInvalid
	{

		public UTF8StringHandle(string str) { }

		protected virtual bool ReleaseHandle() { }

	}


	public InteropHelp() { }

	public static string ByteArrayToStringUTF8(Byte[] buffer) { }

	public static string PtrToStringUTF8(IntPtr nativeUtf8) { }

	public static void StringToByteArrayUTF8(string str, Byte[] outArrayBuffer, int outArrayBufferSize) { }

	public static void TestIfAvailableClient() { }

	public static void TestIfAvailableGameServer() { }

	public static void TestIfPlatformSupported() { }

}

