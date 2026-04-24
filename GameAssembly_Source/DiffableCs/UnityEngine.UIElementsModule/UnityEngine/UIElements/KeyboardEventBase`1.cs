namespace UnityEngine.UIElements;

public abstract class KeyboardEventBase : EventBase<T>, IKeyboardEvent
{
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private EventModifiers <modifiers>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private char <character>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private KeyCode <keyCode>k__BackingField; //Field offset: 0x0

	protected char character
	{
		[CompilerGenerated]
		 set { } //Length: 8
	}

	protected KeyCode keyCode
	{
		[CompilerGenerated]
		 set { } //Length: 7
	}

	protected EventModifiers modifiers
	{
		[CompilerGenerated]
		 set { } //Length: 7
	}

	protected KeyboardEventBase`1() { }

	public static T GetPooled(char c, KeyCode keyCode, EventModifiers modifiers) { }

	public static T GetPooled(Event systemEvent) { }

	protected virtual void Init() { }

	private void LocalInit() { }

	[CompilerGenerated]
	protected void set_character(char value) { }

	[CompilerGenerated]
	protected void set_keyCode(KeyCode value) { }

	[CompilerGenerated]
	protected void set_modifiers(EventModifiers value) { }

}

