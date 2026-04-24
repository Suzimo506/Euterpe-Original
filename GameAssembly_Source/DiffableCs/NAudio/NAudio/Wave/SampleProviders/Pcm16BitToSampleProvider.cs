namespace NAudio.Wave.SampleProviders;

public class Pcm16BitToSampleProvider : SampleProviderConverterBase
{

	public Pcm16BitToSampleProvider(IWaveProvider source) { }

	public virtual int Read(Single[] buffer, int offset, int count) { }

}

