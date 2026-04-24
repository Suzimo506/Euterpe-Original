namespace System.ComponentModel;

public class PropertyChangingEventArgs : EventArgs
{
	private readonly string propertyName; //Field offset: 0x10

	public PropertyChangingEventArgs(string propertyName) { }

}

