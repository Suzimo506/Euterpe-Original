namespace System.ComponentModel;

public class CollectionChangeEventArgs : EventArgs
{
	private CollectionChangeAction action; //Field offset: 0x10
	private object element; //Field offset: 0x18

	public override CollectionChangeAction Action
	{
		 get { } //Length: 4
	}

	public override object Element
	{
		 get { } //Length: 5
	}

	public CollectionChangeEventArgs(CollectionChangeAction action, object element) { }

	public override CollectionChangeAction get_Action() { }

	public override object get_Element() { }

}

