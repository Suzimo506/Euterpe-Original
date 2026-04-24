namespace UnityEngine.InputSystem.LowLevel;

internal struct TouchscreenState : IInputStateTypeInfo
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <primaryTouchData>e__FixedBuffer
	{
		public byte FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <touchData>e__FixedBuffer
	{
		public byte FixedElementField; //Field offset: 0x0

	}

	public const int MaxTouches = 10; //Field offset: 0x0
	internal const int kTouchDataOffset = 56; //Field offset: 0x0
	[FixedBuffer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	[InputControl]
	public <primaryTouchData>e__FixedBuffer primaryTouchData; //Field offset: 0x0
	[FixedBuffer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[InputControl]
	public <touchData>e__FixedBuffer touchData; //Field offset: 0x38

	public override FourCC format
	{
		 get { } //Length: 53
	}

	public static FourCC Format
	{
		 get { } //Length: 53
	}

	public TouchState* primaryTouch
	{
		 get { } //Length: 4
	}

	public TouchState* touches
	{
		 get { } //Length: 5
	}

	public override FourCC get_format() { }

	public static FourCC get_Format() { }

	public TouchState* get_primaryTouch() { }

	public TouchState* get_touches() { }

}

