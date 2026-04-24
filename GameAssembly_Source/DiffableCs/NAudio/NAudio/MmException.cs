namespace NAudio;

public class MmException : Exception
{
	private MmResult result; //Field offset: 0x88
	private string function; //Field offset: 0x90

	public MmException(MmResult result, string function) { }

	private static string ErrorMessage(MmResult result, string function) { }

	public static void Try(MmResult result, string function) { }

}

