namespace NVorbis;

public interface IContainerReader : IDisposable
{

	public event EventHandler<NewStreamEventArgs> NewStream
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public void add_NewStream(EventHandler<NewStreamEventArgs> value) { }

	public bool FindNextStream() { }

	public bool Init() { }

	public void remove_NewStream(EventHandler<NewStreamEventArgs> value) { }

}

