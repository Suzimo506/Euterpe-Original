namespace Rewired.Interfaces;

[CustomClassObfuscation]
[CustomObfuscation]
internal interface IInputManagerJoystickPublic
{

	public Extension extension
	{
		 get { } //Length: 0
	}

	public int inputManagerId
	{
		 get { } //Length: 0
	}

	public Guid instanceGuid
	{
		 get { } //Length: 0
	}

	public string name
	{
		 get { } //Length: 0
	}

	public Guid persistentGuid
	{
		 get { } //Length: 0
	}

	public int rewiredId
	{
		 get { } //Length: 0
	}

	public Nullable<Int64> systemId
	{
		 get { } //Length: 0
	}

	public int unityId
	{
		 get { } //Length: 0
	}

	public Extension get_extension() { }

	public int get_inputManagerId() { }

	public Guid get_instanceGuid() { }

	public string get_name() { }

	public Guid get_persistentGuid() { }

	public int get_rewiredId() { }

	public Nullable<Int64> get_systemId() { }

	public int get_unityId() { }

	public void SetVibration(float amount, int motorIndex) { }

	public void StopVibration() { }

}

