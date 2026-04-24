namespace Antlr.Runtime;

public interface IIntStream
{

	public int Count
	{
		 get { } //Length: 0
	}

	public int Index
	{
		 get { } //Length: 0
	}

	public string SourceName
	{
		 get { } //Length: 0
	}

	public void Consume() { }

	public int get_Count() { }

	public int get_Index() { }

	public string get_SourceName() { }

	public int LA(int i) { }

	public int Mark() { }

	public void Release(int marker) { }

	public void Rewind(int marker) { }

	public void Rewind() { }

	public void Seek(int index) { }

}

