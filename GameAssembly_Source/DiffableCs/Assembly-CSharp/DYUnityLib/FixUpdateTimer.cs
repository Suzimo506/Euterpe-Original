namespace DYUnityLib;

public class FixUpdateTimer
{
	private static bool _isPausing; //Field offset: 0x0
	public const float fInterval = 0.01; //Field offset: 0x0
	private const int precision = 100; //Field offset: 0x0
	public const int TIMER_TYPE_EVENT_ARRAY = 0; //Field offset: 0x0
	public const int TIMER_TYPE_STEP_ARRAY = 1; //Field offset: 0x0
	public static List<FixUpdateTimer> timers; //Field offset: 0x8
	[DecimalConstant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static readonly decimal dInterval; //Field offset: 0x10
	private int m_Index; //Field offset: 0x10
	private UInt32[][] m_OldIdx; //Field offset: 0x18
	private Int32[] m_Ticks; //Field offset: 0x20
	private int iType; //Field offset: 0x28
	private int passedTick; //Field offset: 0x2C
	private int prePassedTick; //Field offset: 0x30
	private int passedCount; //Field offset: 0x34
	private int totalTick; //Field offset: 0x38
	private uint defaultEvent; //Field offset: 0x3C
	private bool isPause; //Field offset: 0x40
	private int m_curPassedTick; //Field offset: 0x44
	private UInt32[][] events; //Field offset: 0x48

	private void __OnTickEventArray() { }

	private void __OnTickStepArray() { }

	private static FixUpdateTimer() { }

	public FixUpdateTimer() { }

	public void AddTickEvent(decimal tick, uint eventIndex) { }

	public void Cancel() { }

	public void ClearTickEvent() { }

	public decimal GetPassTick() { }

	public void Init(decimal _totalTick, int index, int timerType = 0) { }

	public static bool IsPausing() { }

	public bool IsRunning() { }

	private void OnTick() { }

	public void Pause() { }

	public static void PauseTimer() { }

	public void Resume() { }

	public static void ResumeTimer() { }

	public static void RollTimer() { }

	public void Run() { }

	private void SetPassTick(int tick) { }

}

