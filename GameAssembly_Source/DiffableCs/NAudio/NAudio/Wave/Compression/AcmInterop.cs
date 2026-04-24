namespace NAudio.Wave.Compression;

internal class AcmInterop
{

	public static MmResult acmDriverClose(IntPtr hAcmDriver, int closeFlags) { }

	public static MmResult acmFormatSuggest(IntPtr hAcmDriver, in WaveFormat sourceFormat, out WaveFormat destFormat, int sizeDestFormat, AcmFormatSuggestFlags suggestFlags) { }

	public static MmResult acmStreamClose(IntPtr hAcmStream, int closeFlags) { }

	public static MmResult acmStreamConvert(IntPtr hAcmStream, out AcmStreamHeaderStruct streamHeader, AcmStreamConvertFlags streamConvertFlags) { }

	public static MmResult acmStreamOpen(out IntPtr hAcmStream, IntPtr hAcmDriver, in WaveFormat sourceFormat, in WaveFormat destFormat, in WaveFilter waveFilter, IntPtr callback, IntPtr instance, AcmStreamOpenFlags openFlags) { }

	public static MmResult acmStreamPrepareHeader(IntPtr hAcmStream, out AcmStreamHeaderStruct streamHeader, int prepareFlags) { }

	public static MmResult acmStreamSize(IntPtr hAcmStream, int inputBufferSize, out int outputBufferSize, AcmStreamSizeFlags flags) { }

	public static MmResult acmStreamUnprepareHeader(IntPtr hAcmStream, out AcmStreamHeaderStruct streamHeader, int flags) { }

}

