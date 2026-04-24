namespace NAudio.Wave;

public class WaveBuffer
{
	public int numberOfBytes; //Field offset: 0x10
	private Byte[] byteBuffer; //Field offset: 0x18
	private Single[] floatBuffer; //Field offset: 0x18
	private Int16[] shortBuffer; //Field offset: 0x18
	private Int32[] intBuffer; //Field offset: 0x18

	public override Single[] FloatBuffer
	{
		 get { } //Length: 5
	}

	public WaveBuffer(Byte[] bufferToBoundTo) { }

	public void BindTo(Byte[] bufferToBoundTo) { }

	public override Single[] get_FloatBuffer() { }

}

