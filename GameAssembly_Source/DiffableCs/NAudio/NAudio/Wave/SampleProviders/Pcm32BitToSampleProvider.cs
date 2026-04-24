namespace NAudio.Wave.SampleProviders;

public class Pcm32BitToSampleProvider : SampleProviderConverterBase
{

	public Pcm32BitToSampleProvider(IWaveProvider source) { }

	public virtual int Read(Single[] buffer, int offset, int count) { }

}

