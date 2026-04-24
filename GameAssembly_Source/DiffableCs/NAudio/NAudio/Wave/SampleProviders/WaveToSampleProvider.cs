namespace NAudio.Wave.SampleProviders;

public class WaveToSampleProvider : SampleProviderConverterBase
{

	public WaveToSampleProvider(IWaveProvider source) { }

	public virtual int Read(Single[] buffer, int offset, int count) { }

}

