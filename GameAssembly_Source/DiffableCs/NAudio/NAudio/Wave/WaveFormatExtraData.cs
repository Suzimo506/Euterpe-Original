namespace NAudio.Wave;

public class WaveFormatExtraData : WaveFormat
{
	private Byte[] extraData; //Field offset: 0x28

	internal WaveFormatExtraData() { }

	internal void ReadExtraData(BinaryReader reader) { }

}

