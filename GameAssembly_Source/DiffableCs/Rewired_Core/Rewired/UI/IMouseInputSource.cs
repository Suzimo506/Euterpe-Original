namespace Rewired.UI;

public interface IMouseInputSource
{

	public int buttonCount
	{
		 get { } //Length: 0
	}

	public bool enabled
	{
		 get { } //Length: 0
	}

	public bool locked
	{
		 get { } //Length: 0
	}

	public int playerId
	{
		 get { } //Length: 0
	}

	public Vector2 screenPosition
	{
		 get { } //Length: 0
	}

	public Vector2 screenPositionDelta
	{
		 get { } //Length: 0
	}

	public Vector2 wheelDelta
	{
		 get { } //Length: 0
	}

	public int get_buttonCount() { }

	public bool get_enabled() { }

	public bool get_locked() { }

	public int get_playerId() { }

	public Vector2 get_screenPosition() { }

	public Vector2 get_screenPositionDelta() { }

	public Vector2 get_wheelDelta() { }

	public bool GetButton(int button) { }

	public bool GetButtonDown(int button) { }

	public bool GetButtonUp(int button) { }

}

