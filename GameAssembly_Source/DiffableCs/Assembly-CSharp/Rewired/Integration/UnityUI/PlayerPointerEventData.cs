namespace Rewired.Integration.UnityUI;

public class PlayerPointerEventData : PointerEventData
{
	[CompilerGenerated]
	private int <playerId>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	private int <inputSourceIndex>k__BackingField; //Field offset: 0x134
	[CompilerGenerated]
	private IMouseInputSource <mouseSource>k__BackingField; //Field offset: 0x138
	[CompilerGenerated]
	private ITouchInputSource <touchSource>k__BackingField; //Field offset: 0x140
	[CompilerGenerated]
	private PointerEventType <sourceType>k__BackingField; //Field offset: 0x148
	[CompilerGenerated]
	private int <buttonIndex>k__BackingField; //Field offset: 0x14C

	public int buttonIndex
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public int inputSourceIndex
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public IMouseInputSource mouseSource
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public int playerId
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public PointerEventType sourceType
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public ITouchInputSource touchSource
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public PlayerPointerEventData(EventSystem eventSystem) { }

	[CompilerGenerated]
	public int get_buttonIndex() { }

	[CompilerGenerated]
	public int get_inputSourceIndex() { }

	[CompilerGenerated]
	public IMouseInputSource get_mouseSource() { }

	[CompilerGenerated]
	public int get_playerId() { }

	[CompilerGenerated]
	public PointerEventType get_sourceType() { }

	[CompilerGenerated]
	public ITouchInputSource get_touchSource() { }

	[CompilerGenerated]
	public void set_buttonIndex(int value) { }

	[CompilerGenerated]
	public void set_inputSourceIndex(int value) { }

	[CompilerGenerated]
	public void set_mouseSource(IMouseInputSource value) { }

	[CompilerGenerated]
	public void set_playerId(int value) { }

	[CompilerGenerated]
	public void set_sourceType(PointerEventType value) { }

	[CompilerGenerated]
	public void set_touchSource(ITouchInputSource value) { }

	public virtual string ToString() { }

}

