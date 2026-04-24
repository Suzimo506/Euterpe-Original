namespace NAudio.Wave.SampleProviders;

public class MeteringSampleProvider : ISampleProvider
{
	private readonly ISampleProvider source; //Field offset: 0x10
	private readonly Single[] maxSamples; //Field offset: 0x18
	private int sampleCount; //Field offset: 0x20
	private readonly int channels; //Field offset: 0x24
	private readonly StreamVolumeEventArgs args; //Field offset: 0x28
	private EventHandler<StreamVolumeEventArgs> StreamVolume; //Field offset: 0x30
	[CompilerGenerated]
	private int <SamplesPerNotification>k__BackingField; //Field offset: 0x38

	public int SamplesPerNotification
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override WaveFormat WaveFormat
	{
		 get { } //Length: 69
	}

	public MeteringSampleProvider(ISampleProvider source) { }

	public MeteringSampleProvider(ISampleProvider source, int samplesPerNotification) { }

	[CompilerGenerated]
	public int get_SamplesPerNotification() { }

	public override WaveFormat get_WaveFormat() { }

	public override int Read(Single[] buffer, int offset, int count) { }

	[CompilerGenerated]
	public void set_SamplesPerNotification(int value) { }

}

