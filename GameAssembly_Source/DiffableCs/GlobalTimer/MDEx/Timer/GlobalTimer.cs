namespace MDEx.Timer;

public class GlobalTimer : MonoBehaviour
{
	private static GameObject s_TimerObj; //Field offset: 0x0
	private static GlobalTimer s_Timer; //Field offset: 0x8
	private static bool s_IsDispose; //Field offset: 0x10
	private Stopwatch m_StopWatch; //Field offset: 0x18
	private long m_prevTick; //Field offset: 0x20
	private long m_deltaTime; //Field offset: 0x28

	public static float deltaTime
	{
		 get { } //Length: 603
	}

	public static GlobalTimer Instance
	{
		 get { } //Length: 456
	}

	private static GlobalTimer() { }

	public GlobalTimer() { }

	private void Awake() { }

	public static float get_deltaTime() { }

	public static GlobalTimer get_Instance() { }

	private void OnDestoy() { }

	private void OnSceneChange(Scene curScene, LoadSceneMode mode) { }

	public void TimerReset() { }

	private void Update() { }

}

