namespace E7.Native;

public struct NativeSource
{
	internal struct PlayOptions
	{
		public static readonly PlayOptions defaultOptions; //Field offset: 0x0
		public float volume; //Field offset: 0x0
		public float pan; //Field offset: 0x4
		public float offsetSeconds; //Field offset: 0x8
		public bool sourceLoop; //Field offset: 0xC

		private static PlayOptions() { }

	}

	[CompilerGenerated]
	private bool <IsValid>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private int <Index>k__BackingField; //Field offset: 0x4

	public void Play(NativeAudioPointer nativeAudioPointer) { }

	public void Play(NativeAudioPointer nativeAudioPointer, PlayOptions playOptions) { }

}

