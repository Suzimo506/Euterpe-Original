namespace Assets.Scripts.GameCore.GamePlay;

public class GameOptimization
{
	private List<Int32> m_OptimizationList; //Field offset: 0x10

	public GameOptimization() { }

	public static void BlockJumpOptimization(List<TimeNodeOrder> tnos) { }

	public bool BlockPunch_OR_Optimization(List<TimeNodeOrder> tnos, TimeNodeOrder punchTno) { }

	public static void BlockPunchOptimization(List<TimeNodeOrder> tnos, ref byte punchResult, ref MusicData punchMd) { }

	public static void BlockTouchOptimization(List<TimeNodeOrder> tnos, TimeNodeOrder punchTno) { }

	public void Init() { }

	public static void PunchTouchGet(ref byte punchResult, ref MusicData punchMd) { }

	public void Release() { }

	public bool TouchPunch_OR_Optimization(List<TimeNodeOrder> tnos, TimeNodeOrder punchTno) { }

}

