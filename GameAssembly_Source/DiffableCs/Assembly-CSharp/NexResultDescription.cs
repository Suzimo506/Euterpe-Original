//Type is in global namespace

public class NexResultDescription
{
	internal enum ErrorType
	{
		None = 0,
		Logout = 1,
		Busy = 2,
		NoNet = 3,
		NoNsa = 4,
	}

	public static bool isUnknowError; //Field offset: 0x2C927BC

	private static NexResultDescription() { }

	public NexResultDescription() { }

	public static ErrorType GetErrorType(int des) { }

	public static bool isSuccess(int des) { }

}

