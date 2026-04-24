namespace Rewired.UI;

public interface ITouchInputSource
{

	public int playerId
	{
		 get { } //Length: 0
	}

	public int touchCount
	{
		 get { } //Length: 0
	}

	public bool touchSupported
	{
		 get { } //Length: 0
	}

	public int get_playerId() { }

	public int get_touchCount() { }

	public bool get_touchSupported() { }

	public Touch GetTouch(int index) { }

}

