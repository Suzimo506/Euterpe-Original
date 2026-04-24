namespace NAudio.Wave;

public interface ISampleProvider
{

	public WaveFormat WaveFormat
	{
		 get { } //Length: 0
	}

	public WaveFormat get_WaveFormat() { }

	public int Read(Single[] buffer, int offset, int count) { }

}

