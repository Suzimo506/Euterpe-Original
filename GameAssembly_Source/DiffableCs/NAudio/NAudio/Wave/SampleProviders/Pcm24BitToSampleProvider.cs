namespace NAudio.Wave.SampleProviders;

public class Pcm24BitToSampleProvider : SampleProviderConverterBase
{

	public Pcm24BitToSampleProvider(IWaveProvider source) { }

	public virtual int Read(Single[] buffer, int offset, int count) { }

}

