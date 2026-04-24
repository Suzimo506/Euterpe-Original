namespace DYUnityLib;

public class TouchScript
{
	private struct TouchIndex
	{
		public const int LR_BEGIN = 0; //Field offset: 0x0
		public const int LR_MOVED = 1; //Field offset: 0x0
		public const int LR_ENDED = 2; //Field offset: 0x0
		public const int UD_BEGIN = 3; //Field offset: 0x0
		public const int UD_MOVED = 4; //Field offset: 0x0
		public const int UD_ENDED = 5; //Field offset: 0x0
		public const int touch_count = 6; //Field offset: 0x0
		public const int Air = 0; //Field offset: 0x0
		public const int Road = 1; //Field offset: 0x0

	}

	private static int m_TouchsBeginIndex; //Field offset: 0x0
	private const int length = 20; //Field offset: 0x0
	private static int m_TouchsMoveIndex; //Field offset: 0x4
	private static int m_TouchsEndIndex; //Field offset: 0x8
	public float tickTime; //Field offset: 0x10
	private DBTouch dbTouch; //Field offset: 0x18
	private readonly Single[][] m_Touchs; //Field offset: 0x20
	private readonly List<GEventHandler`1<UInt32>> m_CustomEvent; //Field offset: 0x28
	private Rect m_DisableTouchRect; //Field offset: 0x30
	private Vector2[] m_Trapezoids; //Field offset: 0x40
	private float m_TouchEventPhaseP; //Field offset: 0x48
	private int m_JumpIndex; //Field offset: 0x4C
	private int m_PunchIndex; //Field offset: 0x50
	private Single[] m_JumpTouchs; //Field offset: 0x58
	private Single[] m_PunchTouchs; //Field offset: 0x60
	private int m_FeverActionId; //Field offset: 0x68
	private readonly MDButtonType[] m_ButtonNames; //Field offset: 0x70

	public TouchScript() { }

	public void AddCustomEvent(GEventHandler<UInt32> e) { }

	public void ClearCustomEvent() { }

	public Single[][] GetTouchs() { }

	private void IndexChange(int i, TouchPhase phase, bool isPunch) { }

	public bool IsJumpTouch(TouchPhase phase = 0) { }

	private bool IsPunch(float p) { }

	public bool IsPunchTouch(TouchPhase phase = 0) { }

	private void KeyHandler() { }

	private void ManualHandler(List<Int32> pressList, bool isAutoFever, bool invokeFever) { }

	public static void OnGameTouchPlayInited() { }

	public void OnStart() { }

	public void RemoveCustomEvent(GEventHandler<UInt32> e) { }

	private void Reset() { }

	public void TouchEventPhase() { }

	private void TouchHandler(ref Touch touch, int arrayIndex) { }

	public void TouchTrigger(uint triggerId) { }

}

