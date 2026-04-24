namespace NAudio.Wave.SampleProviders;

public class Pcm8BitToSampleProvider : SampleProviderConverterBase
{

	public Pcm8BitToSampleProvider(IWaveProvider source) { }

	public virtual int Read(Single[] buffer, int offset, int count) { }

}

