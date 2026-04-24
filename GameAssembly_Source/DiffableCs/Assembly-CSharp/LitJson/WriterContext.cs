namespace LitJson;

internal class WriterContext
{
	public int Count; //Field offset: 0x10
	public bool InArray; //Field offset: 0x14
	public bool InObject; //Field offset: 0x15
	public bool ExpectingValue; //Field offset: 0x16
	public int Padding; //Field offset: 0x18

	public WriterContext() { }

}

