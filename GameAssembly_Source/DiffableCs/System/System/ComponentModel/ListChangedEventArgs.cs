namespace System.ComponentModel;

public class ListChangedEventArgs : EventArgs
{
	private ListChangedType listChangedType; //Field offset: 0x10
	private int newIndex; //Field offset: 0x14
	private int oldIndex; //Field offset: 0x18
	private PropertyDescriptor propDesc; //Field offset: 0x20

	public ListChangedType ListChangedType
	{
		 get { } //Length: 4
	}

	public int NewIndex
	{
		 get { } //Length: 4
	}

	public int OldIndex
	{
		 get { } //Length: 4
	}

	public ListChangedEventArgs(ListChangedType listChangedType, int newIndex) { }

	public ListChangedEventArgs(ListChangedType listChangedType, int newIndex, PropertyDescriptor propDesc) { }

	public ListChangedEventArgs(ListChangedType listChangedType, PropertyDescriptor propDesc) { }

	public ListChangedEventArgs(ListChangedType listChangedType, int newIndex, int oldIndex) { }

	public ListChangedType get_ListChangedType() { }

	public int get_NewIndex() { }

	public int get_OldIndex() { }

}

