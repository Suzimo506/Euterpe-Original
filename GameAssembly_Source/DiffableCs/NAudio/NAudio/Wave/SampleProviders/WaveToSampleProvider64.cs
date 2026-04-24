namespace NAudio.Wave.SampleProviders;

public class WaveToSampleProvider64 : SampleProviderConverterBase
{

	public WaveToSampleProvider64(IWaveProvider source) { }

	public virtual int Read(Single[] buffer, int offset, int count) { }

}

