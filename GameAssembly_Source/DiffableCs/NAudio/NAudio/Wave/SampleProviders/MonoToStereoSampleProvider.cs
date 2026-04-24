namespace NAudio.Wave.SampleProviders;

public class MonoToStereoSampleProvider : ISampleProvider
{
	private readonly ISampleProvider source; //Field offset: 0x10
	private readonly WaveFormat waveFormat; //Field offset: 0x18
	private Single[] sourceBuffer; //Field offset: 0x20

	public override WaveFormat WaveFormat
	{
		 get { } //Length: 5
	}

	public MonoToStereoSampleProvider(ISampleProvider source) { }

	private void EnsureSourceBuffer(int count) { }

	public override WaveFormat get_WaveFormat() { }

	public override int Read(Single[] buffer, int offset, int count) { }

}

