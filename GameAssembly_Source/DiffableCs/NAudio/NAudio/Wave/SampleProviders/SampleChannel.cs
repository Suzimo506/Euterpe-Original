namespace NAudio.Wave.SampleProviders;

public class SampleChannel : ISampleProvider
{
	private readonly VolumeSampleProvider volumeProvider; //Field offset: 0x10
	private readonly MeteringSampleProvider preVolumeMeter; //Field offset: 0x18
	private readonly WaveFormat waveFormat; //Field offset: 0x20

	public float Volume
	{
		 get { } //Length: 28
		 set { } //Length: 28
	}

	public override WaveFormat WaveFormat
	{
		 get { } //Length: 5
	}

	public SampleChannel(IWaveProvider waveProvider, bool forceStereo) { }

	public float get_Volume() { }

	public override WaveFormat get_WaveFormat() { }

	public override int Read(Single[] buffer, int offset, int sampleCount) { }

	public void set_Volume(float value) { }

}

