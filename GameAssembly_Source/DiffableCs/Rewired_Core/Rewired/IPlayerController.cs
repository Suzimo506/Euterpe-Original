namespace Rewired;

[CustomClassObfuscation]
[CustomObfuscation]
internal interface IPlayerController
{

	public event Action<Int32, Single> AxisValueChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<Int32, Boolean> ButtonStateChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<Boolean> EnabledStateChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public IList<Axis> axes
	{
		 get { } //Length: 0
	}

	public int axisCount
	{
		 get { } //Length: 0
	}

	public int buttonCount
	{
		 get { } //Length: 0
	}

	public IList<Button> buttons
	{
		 get { } //Length: 0
	}

	public int elementCount
	{
		 get { } //Length: 0
	}

	public IList<Element> elements
	{
		 get { } //Length: 0
	}

	public bool enabled
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public int playerId
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	[CompilerGenerated]
	public void add_AxisValueChangedEvent(Action<Int32, Single> value) { }

	[CompilerGenerated]
	public void add_ButtonStateChangedEvent(Action<Int32, Boolean> value) { }

	[CompilerGenerated]
	public void add_EnabledStateChangedEvent(Action<Boolean> value) { }

	public IList<Axis> get_axes() { }

	public int get_axisCount() { }

	public int get_buttonCount() { }

	public IList<Button> get_buttons() { }

	public int get_elementCount() { }

	public IList<Element> get_elements() { }

	public bool get_enabled() { }

	public int get_playerId() { }

	public float GetAxis(int index) { }

	public float GetAxisRaw(int index) { }

	public bool GetButton(int index) { }

	public bool GetButtonDown(int index) { }

	public bool GetButtonUp(int index) { }

	public T GetElement(int index) { }

	public Element GetElement(int index) { }

	[CompilerGenerated]
	public void remove_AxisValueChangedEvent(Action<Int32, Single> value) { }

	[CompilerGenerated]
	public void remove_ButtonStateChangedEvent(Action<Int32, Boolean> value) { }

	[CompilerGenerated]
	public void remove_EnabledStateChangedEvent(Action<Boolean> value) { }

	public void set_enabled(bool value) { }

	public void set_playerId(int value) { }

}

