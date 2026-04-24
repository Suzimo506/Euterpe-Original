namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class Event
{
	private static Event s_Current; //Field offset: 0x0
	private static Event s_MasterEvent; //Field offset: 0x8
	internal IntPtr m_Ptr; //Field offset: 0x10

	public bool alt
	{
		 get { } //Length: 56
	}

	[NativeProperty]
	public int button
	{
		 get { } //Length: 51
	}

	[NativeProperty]
	public char character
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	[NativeProperty]
	public int clickCount
	{
		 get { } //Length: 51
	}

	public bool command
	{
		 get { } //Length: 56
	}

	public string commandName
	{
		[FreeFunction]
		 get { } //Length: 51
		[FreeFunction]
		 set { } //Length: 66
	}

	public bool control
	{
		 get { } //Length: 56
	}

	public static Event current
	{
		 get { } //Length: 53
		 set { } //Length: 150
	}

	[NativeProperty]
	public Vector2 delta
	{
		 get { } //Length: 70
	}

	[NativeProperty]
	public int displayIndex
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	internal bool isDirectManipulationDevice
	{
		[VisibleToOtherModules]
		internal get { } //Length: 109
	}

	public bool isKey
	{
		 get { } //Length: 73
	}

	public bool isMouse
	{
		 get { } //Length: 85
	}

	[NativeProperty]
	public KeyCode keyCode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	[NativeProperty]
	public EventModifiers modifiers
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	[NativeProperty]
	public Vector2 mousePosition
	{
		 get { } //Length: 70
		 set { } //Length: 61
	}

	[NativeProperty]
	public PointerType pointerType
	{
		 get { } //Length: 51
	}

	[NativeProperty]
	public float pressure
	{
		 get { } //Length: 51
	}

	[NativeProperty]
	public EventType rawType
	{
		 get { } //Length: 51
	}

	public bool shift
	{
		 get { } //Length: 56
	}

	public EventType type
	{
		[FreeFunction]
		 get { } //Length: 51
		[FreeFunction]
		 set { } //Length: 64
	}

	public Event(Event other) { }

	public Event(int displayIndex) { }

	public Event() { }

	[VisibleToOtherModules]
	internal void CopyFrom(Event e) { }

	[FreeFunction]
	[VisibleToOtherModules]
	internal void CopyFromPtr(IntPtr ptr) { }

	public virtual bool Equals(object obj) { }

	protected virtual void Finalize() { }

	public bool get_alt() { }

	public int get_button() { }

	public char get_character() { }

	public int get_clickCount() { }

	public bool get_command() { }

	[FreeFunction]
	public string get_commandName() { }

	public bool get_control() { }

	public static Event get_current() { }

	public Vector2 get_delta() { }

	private void get_delta_Injected(out Vector2 ret) { }

	public int get_displayIndex() { }

	[VisibleToOtherModules]
	internal bool get_isDirectManipulationDevice() { }

	public bool get_isKey() { }

	public bool get_isMouse() { }

	public KeyCode get_keyCode() { }

	public EventModifiers get_modifiers() { }

	public Vector2 get_mousePosition() { }

	private void get_mousePosition_Injected(out Vector2 ret) { }

	public PointerType get_pointerType() { }

	public float get_pressure() { }

	public EventType get_rawType() { }

	public bool get_shift() { }

	[FreeFunction]
	public EventType get_type() { }

	public virtual int GetHashCode() { }

	[FreeFunction]
	public EventType GetTypeForControl(int controlID) { }

	[FreeFunction]
	private static IntPtr Internal_Copy(IntPtr otherPtr) { }

	[FreeFunction]
	private static IntPtr Internal_Create(int displayIndex) { }

	[FreeFunction]
	private static void Internal_Destroy(IntPtr ptr) { }

	[RequiredByNativeCode]
	internal static void Internal_MakeMasterEventCurrent(int displayIndex) { }

	private static void Internal_SetNativeEvent(IntPtr ptr) { }

	[NativeMethod]
	private void Internal_Use() { }

	public static Event KeyboardEvent(string key) { }

	public static bool PopEvent(Event outEvent) { }

	public void set_character(char value) { }

	[FreeFunction]
	public void set_commandName(string value) { }

	public static void set_current(Event value) { }

	public void set_displayIndex(int value) { }

	public void set_keyCode(KeyCode value) { }

	public void set_modifiers(EventModifiers value) { }

	public void set_mousePosition(Vector2 value) { }

	private void set_mousePosition_Injected(ref Vector2 value) { }

	[FreeFunction]
	public void set_type(EventType value) { }

	public virtual string ToString() { }

	public void Use() { }

}

