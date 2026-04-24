namespace E7.Native;

public static class NativeAudio
{
	internal struct LoadOptions
	{
		internal enum ResamplingQuality
		{
			SINC_FASTEST = 2,
			ZERO_ORDER_HOLD = 3,
			LINEAR = 4,
		}

		public static readonly LoadOptions defaultOptions; //Field offset: 0x0
		public ResamplingQuality resamplingQuality; //Field offset: 0x0

		private static LoadOptions() { }

	}

	[CompilerGenerated]
	private static bool <Initialized>k__BackingField; //Field offset: 0x67FF0

	public static bool Initialized
	{
		[CompilerGenerated]
		 get { } //Length: 53
	}

	private static void AssertInitialized() { }

	[CompilerGenerated]
	public static bool get_Initialized() { }

	public static NativeSource GetNativeSourceAuto() { }

	public static NativeAudioPointer Load(string streamingAssetsRelativePath) { }

	public static NativeAudioPointer Load(string streamingAssetsRelativePath, LoadOptions loadOptions) { }

	private static NotSupportedException NotSupportedThrow() { }

}

