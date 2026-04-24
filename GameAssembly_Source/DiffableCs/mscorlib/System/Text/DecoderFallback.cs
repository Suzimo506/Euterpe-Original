namespace System.Text;

public abstract class DecoderFallback
{
	private static DecoderFallback replacementFallback; //Field offset: 0x0
	private static DecoderFallback exceptionFallback; //Field offset: 0x8
	private static object s_InternalSyncObject; //Field offset: 0x10
	internal bool bIsMicrosoftBestFitFallback; //Field offset: 0x10

	public static DecoderFallback ExceptionFallback
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

	public static DecoderFallback ReplacementFallback
	{
		 get { } //Length: 434
	}

	protected DecoderFallback() { }

	public abstract DecoderFallbackBuffer CreateFallbackBuffer() { }

	public static DecoderFallback get_ExceptionFallback() { }

	private static object get_InternalSyncObject() { }

	public abstract int get_MaxCharCount() { }

	public static DecoderFallback get_ReplacementFallback() { }

}

