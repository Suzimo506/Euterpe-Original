namespace Rewired;

[CustomClassObfuscation]
[CustomObfuscation]
internal interface IPlayerMouse : IPlayerController
{

	public event Action<Vector2> ScreenPositionChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public bool defaultToCenter
	{
		 get { } //Length: 0
	}

	public Button leftButton
	{
		 get { } //Length: 0
	}

	public Button middleButton
	{
		 get { } //Length: 0
	}

	public ScreenRect movementArea
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public MovementAreaUnit movementAreaUnit
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float pointerSpeed
	{
		 get { } //Length: 0
	}

	public Button rightButton
	{
		 get { } //Length: 0
	}

	public Vector2 screenPosition
	{
		 get { } //Length: 0
	}

	public Vector2 screenPositionDelta
	{
		 get { } //Length: 0
	}

	public Vector2 screenPositionPrev
	{
		 get { } //Length: 0
	}

	public bool useHardwarePointerPosition
	{
		 get { } //Length: 0
	}

	public MouseWheel wheel
	{
		 get { } //Length: 0
	}

	public MouseAxis xAxis
	{
		 get { } //Length: 0
	}

	public MouseAxis yAxis
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_ScreenPositionChangedEvent(Action<Vector2> value) { }

	public bool get_defaultToCenter() { }

	public Button get_leftButton() { }

	public Button get_middleButton() { }

	public ScreenRect get_movementArea() { }

	public MovementAreaUnit get_movementAreaUnit() { }

	public float get_pointerSpeed() { }

	public Button get_rightButton() { }

	public Vector2 get_screenPosition() { }

	public Vector2 get_screenPositionDelta() { }

	public Vector2 get_screenPositionPrev() { }

	public bool get_useHardwarePointerPosition() { }

	public MouseWheel get_wheel() { }

	public MouseAxis get_xAxis() { }

	public MouseAxis get_yAxis() { }

	[CompilerGenerated]
	public void remove_ScreenPositionChangedEvent(Action<Vector2> value) { }

	public void set_movementArea(ScreenRect value) { }

	public void set_movementAreaUnit(MovementAreaUnit value) { }

}

