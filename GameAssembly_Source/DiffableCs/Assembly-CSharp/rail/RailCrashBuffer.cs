namespace rail;

public interface RailCrashBuffer
{

	public uint AppendData(string data, uint length) { }

	public uint GetBufferLength() { }

	public string GetData() { }

	public uint GetValidLength() { }

	public uint SetData(string data, uint length, uint offset) { }

	public uint SetData(string data, uint length) { }

}

