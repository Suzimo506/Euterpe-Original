namespace System.ComponentModel;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class EventHandlerList
{
	private sealed class ListEntry
	{
		internal ListEntry next; //Field offset: 0x10
		internal object key; //Field offset: 0x18
		internal Delegate handler; //Field offset: 0x20

	}

	private ListEntry head; //Field offset: 0x10
	private Component parent; //Field offset: 0x18

	public Delegate Item
	{
		 get { } //Length: 97
	}

	private ListEntry Find(object key) { }

	public Delegate get_Item(object key) { }

}

