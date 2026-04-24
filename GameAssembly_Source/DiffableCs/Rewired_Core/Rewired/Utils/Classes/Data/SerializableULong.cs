namespace Rewired.Utils.Classes.Data;

public class SerializableULong
{
	[CustomObfuscation]
	[SerializeField]
	private int ulong_32BitLow; //Field offset: 0x10
	[CustomObfuscation]
	[SerializeField]
	private int ulong_32BitHigh; //Field offset: 0x14

	public ulong value
	{
		 get { } //Length: 15
		 set { } //Length: 11
	}

	public SerializableULong() { }

	public SerializableULong(SerializableULong unnamed_param_0) { }

	private ulong aHdicqYGBtwnXqKqFvsUxpfYDvRo(int unnamed_param_0, int unnamed_param_1) { }

	public SerializableULong Clone() { }

	public ulong get_value() { }

	public void set_value(ulong value) { }

	private void TIOcIeWIvlYsTrYAPAMguuEvOtAl(ulong unnamed_param_0, out int unnamed_param_1, out int unnamed_param_2) { }

}

