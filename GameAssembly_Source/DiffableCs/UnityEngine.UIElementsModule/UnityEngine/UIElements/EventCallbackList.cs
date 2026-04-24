namespace UnityEngine.UIElements;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class EventCallbackList
{
	private List<EventCallbackFunctorBase> m_List; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int <trickleDownCallbackCount>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int <bubbleUpCallbackCount>k__BackingField; //Field offset: 0x1C

	public private int bubbleUpCallbackCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public int Count
	{
		 get { } //Length: 59
	}

	public EventCallbackFunctorBase Item
	{
		 get { } //Length: 89
	}

	public private int trickleDownCallbackCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public EventCallbackList() { }

	public EventCallbackList(EventCallbackList source) { }

	public void AddRange(EventCallbackList list) { }

	public void Clear() { }

	[CompilerGenerated]
	public int get_bubbleUpCallbackCount() { }

	public int get_Count() { }

	public EventCallbackFunctorBase get_Item(int i) { }

	[CompilerGenerated]
	public int get_trickleDownCallbackCount() { }

	[CompilerGenerated]
	private void set_bubbleUpCallbackCount(int value) { }

	[CompilerGenerated]
	private void set_trickleDownCallbackCount(int value) { }

}

