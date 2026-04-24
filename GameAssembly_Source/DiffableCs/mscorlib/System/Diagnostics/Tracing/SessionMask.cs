namespace System.Diagnostics.Tracing;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal struct SessionMask
{
	private uint m_mask; //Field offset: 0x0

	public static SessionMask All
	{
		 get { } //Length: 6
	}

	public bool Item
	{
		 get { } //Length: 29
		 set { } //Length: 22
	}

	public SessionMask(uint mask = 0) { }

	public static SessionMask FromEventKeywords(ulong m) { }

	public static SessionMask FromId(int perEventSourceSessionId) { }

	public static SessionMask get_All() { }

	public bool get_Item(int perEventSourceSessionId) { }

	public bool IsEqualOrSupersetOf(SessionMask m) { }

	public static ulong op_Explicit(SessionMask m) { }

	public static uint op_Explicit(SessionMask m) { }

	public void set_Item(int perEventSourceSessionId, bool value) { }

	public ulong ToEventKeywords() { }

}

