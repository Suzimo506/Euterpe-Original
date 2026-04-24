namespace ProtoBuf;

public interface IExtension
{

	public Stream BeginAppend() { }

	public Stream BeginQuery() { }

	public void EndAppend(Stream stream, bool commit) { }

	public void EndQuery(Stream stream) { }

	public int GetLength() { }

}

