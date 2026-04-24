namespace Rewired.Integration.UnityUI;

public abstract class RewiredPointerInputModule : BaseInputModule
{
	internal class ButtonState
	{
		private int m_Button; //Field offset: 0x10
		private MouseButtonEventData m_EventData; //Field offset: 0x18

		public int button
		{
			 get { } //Length: 4
			 set { } //Length: 4
		}

		public MouseButtonEventData eventData
		{
			 get { } //Length: 5
			 set { } //Length: 12
		}

		public ButtonState() { }

		public int get_button() { }

		public MouseButtonEventData get_eventData() { }

		public void set_button(int value) { }

		public void set_eventData(MouseButtonEventData value) { }

	}

	internal class MouseButtonEventData
	{
		public FramePressState buttonState; //Field offset: 0x10
		public PlayerPointerEventData buttonData; //Field offset: 0x18

		public MouseButtonEventData() { }

		public bool PressedThisFrame() { }

		public bool ReleasedThisFrame() { }

	}

	internal class MouseState
	{
		private List<ButtonState> m_TrackedButtons; //Field offset: 0x10

		public MouseState() { }

		public bool AnyPressesThisFrame() { }

		public bool AnyReleasesThisFrame() { }

		public ButtonState GetButtonState(int button) { }

		public void SetButtonState(int button, FramePressState stateForMouseButton, PlayerPointerEventData data) { }

	}

	private sealed class UnityInputSource : IMouseInputSource, ITouchInputSource
	{
		private Vector2 m_MousePosition; //Field offset: 0x10
		private Vector2 m_MousePositionPrev; //Field offset: 0x18
		private int m_LastUpdatedFrame; //Field offset: 0x20

		private override int Rewired.UI.IMouseInputSource.buttonCount
		{
			private get { } //Length: 21
		}

		private override bool Rewired.UI.IMouseInputSource.enabled
		{
			private get { } //Length: 18
		}

		private override bool Rewired.UI.IMouseInputSource.locked
		{
			private get { } //Length: 29
		}

		private override int Rewired.UI.IMouseInputSource.playerId
		{
			private get { } //Length: 18
		}

		private override Vector2 Rewired.UI.IMouseInputSource.screenPosition
		{
			private get { } //Length: 133
		}

		private override Vector2 Rewired.UI.IMouseInputSource.screenPositionDelta
		{
			private get { } //Length: 143
		}

		private override Vector2 Rewired.UI.IMouseInputSource.wheelDelta
		{
			private get { } //Length: 22
		}

		private override int Rewired.UI.ITouchInputSource.playerId
		{
			private get { } //Length: 18
		}

		private override int Rewired.UI.ITouchInputSource.touchCount
		{
			private get { } //Length: 22
		}

		private override bool Rewired.UI.ITouchInputSource.touchSupported
		{
			private get { } //Length: 22
		}

		public UnityInputSource() { }

		private override int Rewired.UI.IMouseInputSource.get_buttonCount() { }

		private override bool Rewired.UI.IMouseInputSource.get_enabled() { }

		private override bool Rewired.UI.IMouseInputSource.get_locked() { }

		private override int Rewired.UI.IMouseInputSource.get_playerId() { }

		private override Vector2 Rewired.UI.IMouseInputSource.get_screenPosition() { }

		private override Vector2 Rewired.UI.IMouseInputSource.get_screenPositionDelta() { }

		private override Vector2 Rewired.UI.IMouseInputSource.get_wheelDelta() { }

		private override bool Rewired.UI.IMouseInputSource.GetButton(int button) { }

		private override bool Rewired.UI.IMouseInputSource.GetButtonDown(int button) { }

		private override bool Rewired.UI.IMouseInputSource.GetButtonUp(int button) { }

		private override int Rewired.UI.ITouchInputSource.get_playerId() { }

		private override int Rewired.UI.ITouchInputSource.get_touchCount() { }

		private override bool Rewired.UI.ITouchInputSource.get_touchSupported() { }

		private override Touch Rewired.UI.ITouchInputSource.GetTouch(int index) { }

		private void TryUpdate() { }

	}

	public const int kMouseLeftId = -1; //Field offset: 0x0
	public const int kMouseRightId = -2; //Field offset: 0x0
	public const int kMouseMiddleId = -3; //Field offset: 0x0
	public const int kFakeTouchesId = -4; //Field offset: 0x0
	private const int customButtonsStartingId = -2147483520; //Field offset: 0x0
	private const int customButtonsMaxCount = 128; //Field offset: 0x0
	private const int customButtonsLastId = -2147483392; //Field offset: 0x0
	private readonly List<IMouseInputSource> m_MouseInputSourcesList; //Field offset: 0x48
	private Dictionary<Int32, Dictionary`2<Int32, PlayerPointerEventData>[]> m_PlayerPointerData; //Field offset: 0x50
	private ITouchInputSource m_UserDefaultTouchInputSource; //Field offset: 0x58
	private UnityInputSource __m_DefaultInputSource; //Field offset: 0x60
	private readonly MouseState m_MouseState; //Field offset: 0x68

	private UnityInputSource defaultInputSource
	{
		private get { } //Length: 112
	}

	private IMouseInputSource defaultMouseInputSource
	{
		private get { } //Length: 7
	}

	protected ITouchInputSource defaultTouchInputSource
	{
		 get { } //Length: 7
	}

	protected override bool isMouseSupported
	{
		 get { } //Length: 249
	}

	protected RewiredPointerInputModule() { }

	public void AddMouseInputSource(IMouseInputSource source) { }

	public void AddTouchInputSource(ITouchInputSource source) { }

	protected void ClearMouseInputSources() { }

	protected void ClearSelection() { }

	protected void CopyFromTo(PointerEventData from, PointerEventData to) { }

	private PlayerPointerEventData CreatePointerEventData(int playerId, int pointerIndex, int pointerTypeId, PointerEventType pointerEventType) { }

	protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent) { }

	private UnityInputSource get_defaultInputSource() { }

	private IMouseInputSource get_defaultMouseInputSource() { }

	protected ITouchInputSource get_defaultTouchInputSource() { }

	protected override bool get_isMouseSupported() { }

	protected PlayerPointerEventData GetLastPointerEventData(int playerId, int pointerIndex, int pointerTypeId, bool ignorePointerTypeId, PointerEventType pointerEventType) { }

	public IMouseInputSource GetMouseInputSource(int playerId, int mouseIndex) { }

	public int GetMouseInputSourceCount(int playerId) { }

	protected override MouseState GetMousePointerEventData(int playerId, int mouseIndex) { }

	protected bool GetPointerData(int playerId, int pointerIndex, int pointerTypeId, out PlayerPointerEventData data, bool create, PointerEventType pointerEventType) { }

	public ITouchInputSource GetTouchInputSource(int playerId, int sourceIndex) { }

	public int GetTouchInputSourceCount(int playerId) { }

	protected PlayerPointerEventData GetTouchPointerEventData(int playerId, int touchDeviceIndex, Touch input, out bool pressed, out bool released) { }

	protected bool IsDefaultMouse(IMouseInputSource mouse) { }

	protected abstract bool IsDefaultPlayer(int playerId) { }

	public virtual bool IsPointerOverGameObject(int pointerTypeId) { }

	protected override void ProcessDrag(PlayerPointerEventData pointerEvent) { }

	protected override void ProcessMove(PlayerPointerEventData pointerEvent) { }

	public void RemoveMouseInputSource(IMouseInputSource source) { }

	protected void RemovePointerData(PlayerPointerEventData data) { }

	public void RemoveTouchInputSource(ITouchInputSource source) { }

	private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold) { }

	protected FramePressState StateForMouseButton(int playerId, int mouseIndex, int buttonId) { }

	public virtual string ToString() { }

}

