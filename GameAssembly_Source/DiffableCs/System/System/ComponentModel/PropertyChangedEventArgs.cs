namespace System.ComponentModel;

public class PropertyChangedEventArgs : EventArgs
{
	private readonly string propertyName; //Field offset: 0x10

	public PropertyChangedEventArgs(string propertyName) { }

}

