namespace NAudio.Wave.SampleProviders;

public abstract class SampleProviderConverterBase : ISampleProvider
{
	protected IWaveProvider source; //Field offset: 0x10
	private WaveFormat waveFormat; //Field offset: 0x18
	protected Byte[] sourceBuffer; //Field offset: 0x20

	public override WaveFormat WaveFormat
	{
		 get { } //Length: 5
	}

	public SampleProviderConverterBase(IWaveProvider source) { }

	protected void EnsureSourceBuffer(int sourceBytesRequired) { }

	public override WaveFormat get_WaveFormat() { }

	public abstract int Read(Single[] buffer, int offset, int count) { }

}

