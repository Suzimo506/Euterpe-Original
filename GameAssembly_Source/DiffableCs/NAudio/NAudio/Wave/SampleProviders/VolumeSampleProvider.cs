namespace NAudio.Wave.SampleProviders;

public class VolumeSampleProvider : ISampleProvider
{
	private readonly ISampleProvider source; //Field offset: 0x10
	private float volume; //Field offset: 0x18

	public float Volume
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public override WaveFormat WaveFormat
	{
		 get { } //Length: 69
	}

	public VolumeSampleProvider(ISampleProvider source) { }

	public float get_Volume() { }

	public override WaveFormat get_WaveFormat() { }

	public override int Read(Single[] buffer, int offset, int sampleCount) { }

	public void set_Volume(float value) { }

}

