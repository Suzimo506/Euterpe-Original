namespace Rewired.Components;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class PlayerMouse : PlayerController, IPlayerController, IPlayerMouse, IMouseInputSource
{
	internal class ScreenPositionChangedHandler : UnityEvent<Vector2>
	{

		public ScreenPositionChangedHandler() { }

	}

	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _defaultToCenter; //Field offset: 0x58
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float _pointerSpeed; //Field offset: 0x5C
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _useHardwarePointerPosition; //Field offset: 0x60
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _clampToMovementArea; //Field offset: 0x61
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Rect _movementArea; //Field offset: 0x64
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private MovementAreaUnit _movementAreaUnit; //Field offset: 0x74
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private ScreenPositionChangedHandler _onScreenPositionChanged; //Field offset: 0x78

	public override event Action<Vector2> ScreenPositionChangedEvent
	{
		 add { } //Length: 133
		 remove { } //Length: 133
	}

	public bool clampToMovementArea
	{
		 get { } //Length: 127
		 set { } //Length: 261
	}

	public override bool defaultToCenter
	{
		 get { } //Length: 126
		 set { } //Length: 264
	}

	public override Button leftButton
	{
		 get { } //Length: 124
	}

	public override Button middleButton
	{
		 get { } //Length: 124
	}

	public override ScreenRect movementArea
	{
		 get { } //Length: 298
		 set { } //Length: 667
	}

	public override MovementAreaUnit movementAreaUnit
	{
		 get { } //Length: 125
		 set { } //Length: 261
	}

	public override float pointerSpeed
	{
		 get { } //Length: 127
		 set { } //Length: 242
	}

	private override bool Rewired.UI.IMouseInputSource.enabled
	{
		private get { } //Length: 135
	}

	private override bool Rewired.UI.IMouseInputSource.locked
	{
		private get { } //Length: 135
	}

	private override Vector2 Rewired.UI.IMouseInputSource.screenPosition
	{
		private get { } //Length: 169
	}

	private override Vector2 Rewired.UI.IMouseInputSource.screenPositionDelta
	{
		private get { } //Length: 169
	}

	private override Vector2 Rewired.UI.IMouseInputSource.wheelDelta
	{
		private get { } //Length: 169
	}

	public override Button rightButton
	{
		 get { } //Length: 124
	}

	public override Vector2 screenPosition
	{
		 get { } //Length: 158
		 set { } //Length: 178
	}

	public override Vector2 screenPositionDelta
	{
		 get { } //Length: 158
	}

	public override Vector2 screenPositionPrev
	{
		 get { } //Length: 158
	}

	private PlayerMouse sGQvzdoiXDPQjVYqDeByKrgVBTaQ
	{
		private get { } //Length: 67
	}

	public override bool useHardwarePointerPosition
	{
		 get { } //Length: 126
		 set { } //Length: 138
	}

	public override MouseWheel wheel
	{
		 get { } //Length: 124
	}

	public override MouseAxis xAxis
	{
		 get { } //Length: 124
	}

	public override MouseAxis yAxis
	{
		 get { } //Length: 124
	}

	public PlayerMouse() { }

	public override void add_ScreenPositionChangedEvent(Action<Vector2> value) { }

	protected virtual PlayerController CreateSource(object args) { }

	protected virtual void Deinitialize() { }

	public bool get_clampToMovementArea() { }

	public override bool get_defaultToCenter() { }

	public override Button get_leftButton() { }

	public override Button get_middleButton() { }

	public override ScreenRect get_movementArea() { }

	public override MovementAreaUnit get_movementAreaUnit() { }

	public override float get_pointerSpeed() { }

	public override Button get_rightButton() { }

	public override Vector2 get_screenPosition() { }

	public override Vector2 get_screenPositionDelta() { }

	public override Vector2 get_screenPositionPrev() { }

	public override bool get_useHardwarePointerPosition() { }

	public override MouseWheel get_wheel() { }

	public override MouseAxis get_xAxis() { }

	public override MouseAxis get_yAxis() { }

	protected virtual void OnReset() { }

	protected virtual void OnValidated() { }

	internal virtual List<ElementInfo> QZBvwUoCzASpAhAnRnEuAlpcXtHW() { }

	public override void remove_ScreenPositionChangedEvent(Action<Vector2> value) { }

	private override bool Rewired.IPlayerController.get_enabled() { }

	private override void Rewired.IPlayerController.set_enabled(bool value) { }

	private override bool Rewired.UI.IMouseInputSource.get_enabled() { }

	private override bool Rewired.UI.IMouseInputSource.get_locked() { }

	private override Vector2 Rewired.UI.IMouseInputSource.get_screenPosition() { }

	private override Vector2 Rewired.UI.IMouseInputSource.get_screenPositionDelta() { }

	private override Vector2 Rewired.UI.IMouseInputSource.get_wheelDelta() { }

	private override bool Rewired.UI.IMouseInputSource.GetButton(int button) { }

	private override bool Rewired.UI.IMouseInputSource.GetButtonDown(int button) { }

	private override bool Rewired.UI.IMouseInputSource.GetButtonUp(int button) { }

	public void set_clampToMovementArea(bool value) { }

	public void set_defaultToCenter(bool value) { }

	public override void set_movementArea(ScreenRect value) { }

	public override void set_movementAreaUnit(MovementAreaUnit value) { }

	public void set_pointerSpeed(float value) { }

	public void set_screenPosition(Vector2 value) { }

	public void set_useHardwarePointerPosition(bool value) { }

	protected virtual void Subscribe() { }

	private PlayerMouse TbgtoFDIFpOGjmpKEVmgkCregILv() { }

	protected virtual void Unsubscribe() { }

	private void ZScWOzihcWFAhCPaPxIOyBRpvAHI(Vector2 unnamed_param_0) { }

}

