namespace UnityEngine.InputSystem.LowLevel;

public struct TouchState : IInputStateTypeInfo
{
	internal const int kSizeInBytes = 56; //Field offset: 0x0
	[InputControl]
	public int touchId; //Field offset: 0x0
	[InputControl]
	public Vector2 position; //Field offset: 0x4
	[InputControl]
	public Vector2 delta; //Field offset: 0xC
	[InputControl]
	public float pressure; //Field offset: 0x14
	[InputControl]
	public Vector2 radius; //Field offset: 0x18
	[InputControl]
	[InputControl]
	public byte phaseId; //Field offset: 0x20
	[InputControl]
	public byte tapCount; //Field offset: 0x21
	private byte displayIndex; //Field offset: 0x22
	[InputControl]
	[InputControl]
	public byte flags; //Field offset: 0x23
	internal uint updateStepCount; //Field offset: 0x24
	[InputControl]
	public double startTime; //Field offset: 0x28
	[InputControl]
	public Vector2 startPosition; //Field offset: 0x30

	internal bool beganInSameFrame
	{
		internal get { } //Length: 8
		internal set { } //Length: 33
	}

	public override FourCC format
	{
		 get { } //Length: 53
	}

	public static FourCC Format
	{
		 get { } //Length: 53
	}

	public bool isIndirectTouch
	{
		 get { } //Length: 7
		 set { } //Length: 33
	}

	public bool isInProgress
	{
		 get { } //Length: 21
	}

	public bool isNoneEndedOrCanceled
	{
		 get { } //Length: 21
	}

	internal bool isOrphanedPrimaryTouch
	{
		internal get { } //Length: 8
		internal set { } //Length: 33
	}

	public bool isPrimaryTouch
	{
		 get { } //Length: 8
		 set { } //Length: 33
	}

	public bool isTap
	{
		 get { } //Length: 8
		 set { } //Length: 33
	}

	internal bool isTapPress
	{
		internal get { } //Length: 8
		internal set { } //Length: 33
	}

	internal bool isTapRelease
	{
		internal get { } //Length: 8
		internal set { } //Length: 33
	}

	public TouchPhase phase
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	internal bool get_beganInSameFrame() { }

	public override FourCC get_format() { }

	public static FourCC get_Format() { }

	public bool get_isIndirectTouch() { }

	public bool get_isInProgress() { }

	public bool get_isNoneEndedOrCanceled() { }

	internal bool get_isOrphanedPrimaryTouch() { }

	public bool get_isPrimaryTouch() { }

	public bool get_isTap() { }

	internal bool get_isTapPress() { }

	internal bool get_isTapRelease() { }

	public TouchPhase get_phase() { }

	internal void set_beganInSameFrame(bool value) { }

	public void set_isIndirectTouch(bool value) { }

	internal void set_isOrphanedPrimaryTouch(bool value) { }

	public void set_isPrimaryTouch(bool value) { }

	public void set_isTap(bool value) { }

	internal void set_isTapPress(bool value) { }

	internal void set_isTapRelease(bool value) { }

	public void set_phase(TouchPhase value) { }

	public virtual string ToString() { }

}

