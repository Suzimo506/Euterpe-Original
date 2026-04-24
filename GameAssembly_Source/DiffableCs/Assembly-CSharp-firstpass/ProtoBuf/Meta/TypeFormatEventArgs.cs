namespace ProtoBuf.Meta;

public class TypeFormatEventArgs : EventArgs
{
	private Type type; //Field offset: 0x10
	private string formattedName; //Field offset: 0x18
	private readonly bool typeFixed; //Field offset: 0x20

	public string FormattedName
	{
		 get { } //Length: 5
		 set { } //Length: 153
	}

	public Type Type
	{
		 get { } //Length: 5
		 set { } //Length: 196
	}

	internal TypeFormatEventArgs(string formattedName) { }

	internal TypeFormatEventArgs(Type type) { }

	public string get_FormattedName() { }

	public Type get_Type() { }

	public void set_FormattedName(string value) { }

	public void set_Type(Type value) { }

}

