namespace NAudio.Wave;

public interface IWaveProvider
{

	public WaveFormat WaveFormat
	{
		 get { } //Length: 0
	}

	public WaveFormat get_WaveFormat() { }

	public int Read(Byte[] buffer, int offset, int count) { }

}

