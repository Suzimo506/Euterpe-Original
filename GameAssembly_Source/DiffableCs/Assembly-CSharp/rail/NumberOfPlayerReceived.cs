namespace rail;

public class NumberOfPlayerReceived : EventBase
{
	public int online_number; //Field offset: 0x30
	public int offline_number; //Field offset: 0x34

	public NumberOfPlayerReceived() { }

}

