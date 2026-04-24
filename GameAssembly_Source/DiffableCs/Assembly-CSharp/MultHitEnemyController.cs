//Type is in global namespace

public class MultHitEnemyController : NormalEnemyController
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__22_0; //Field offset: 0x8
		public static TweenCallback <>9__31_0; //Field offset: 0x10
		public static Action <>9__31_1; //Field offset: 0x18
		public static Action <>9__31_2; //Field offset: 0x20
		public static Action <>9__31_3; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal void <InvokeHitEnd>b__31_0() { }

		internal void <InvokeHitEnd>b__31_1() { }

		internal void <InvokeHitEnd>b__31_2() { }

		internal void <InvokeHitEnd>b__31_3() { }

		internal void <OnControllerStart>b__22_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public Vector3 originPos; //Field offset: 0x10

		public <>c__DisplayClass26_0() { }

		internal void <ShakeBossCamera>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public Vector3 originPos; //Field offset: 0x10

		public <>c__DisplayClass27_0() { }

		internal void <ShakeMulCamera>b__0() { }

	}

	private static float m_OriginSize; //Field offset: 0x0
	private static Camera m_Camera; //Field offset: 0x8
	public static bool isMulHitEnding; //Field offset: 0x10
	public static bool isBanEmptyAction; //Field offset: 0x11
	public static int hitCount; //Field offset: 0x14
	private static Sequence m_HittingCameraSequence; //Field offset: 0x18
	public static bool isHitting; //Field offset: 0x20
	private bool m_IsFlyAway; //Field offset: 0x1F8
	private int m_HitCount; //Field offset: 0x1FC
	private float m_AtkTime; //Field offset: 0x200
	private int m_MulHitLowThreshold; //Field offset: 0x204
	private int m_MulHitMidThreshold; //Field offset: 0x208
	private int m_MulHitHighThreshold; //Field offset: 0x20C
	private float m_HitTime; //Field offset: 0x210

	public bool isDead
	{
		 get { } //Length: 8
	}

	public bool isOver
	{
		 get { } //Length: 16
	}

	public MultHitEnemyController() { }

	public virtual bool ControllerMissCheck(int i, decimal currentTick) { }

	private void Fail() { }

	public bool get_isDead() { }

	public bool get_isOver() { }

	public virtual void Init(int scene) { }

	private void InvokeHitEnd() { }

	public virtual void OnControllerAttacked(int result, bool isDeaded) { }

	public virtual bool OnControllerMiss(int index) { }

	public virtual void OnControllerStart() { }

	public void OnControllerTick(TimeNodeOrder tno) { }

	private void OnDestroy() { }

	public static void Pause() { }

	public static void Resume() { }

	public static void ShakeBossCamera() { }

	public static void ShakeMulCamera() { }

	private void Succuess(bool isTotal = false, bool resulted = true) { }

}

