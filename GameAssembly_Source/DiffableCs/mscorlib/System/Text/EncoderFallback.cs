namespace System.Text;

public abstract class EncoderFallback
{
	private static EncoderFallback replacementFallback; //Field offset: 0x0
	private static EncoderFallback exceptionFallback; //Field offset: 0x8
	private static object s_InternalSyncObject; //Field offset: 0x10
	internal bool bIsMicrosoftBestFitFallback; //Field offset: 0x10

	public static EncoderFallback ExceptionFallback
	{
		 get { } //Length: 406
	}

	private static object InternalSyncObject
	{
		private get { } //Length: 139
	}

	public abstract int MaxCharCount
	{
		 get { } //Length: 0
	}

	public static EncoderFallback ReplacementFallback
	{
		 get { } //Length: 434
	}

	protected EncoderFallback() { }

	public abstract EncoderFallbackBuffer CreateFallbackBuffer() { }

	public static EncoderFallback get_ExceptionFallback() { }

	private static object get_InternalSyncObject() { }

	public abstract int get_MaxCharCount() { }

	public static EncoderFallback get_ReplacementFallback() { }

}

