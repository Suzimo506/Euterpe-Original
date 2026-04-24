namespace Assets.Scripts.GameCore.HostComponent;

public class BattleRoleAttributeComponent
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__18_0; //Field offset: 0x8
		public static Action <>9__18_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <MissHardEffect>b__18_0() { }

		internal void <MissHardEffect>b__18_1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public MusicData md; //Field offset: 0x10

		public <>c__DisplayClass29_0() { }

		internal bool <AttackScore>b__0(MusicData m) { }

	}

	private static BattleRoleAttributeComponent m_Instance; //Field offset: 0x0
	public int hp; //Field offset: 0x10
	public int hurt; //Field offset: 0x14
	private int m_JudgeState; //Field offset: 0x18
	public int early; //Field offset: 0x1C
	public int late; //Field offset: 0x20
	private Coroutine m_ZombiaCoroutine1; //Field offset: 0x28
	private Coroutine m_ZombiaCoroutine2; //Field offset: 0x30
	private bool m_IsShowLateEarly; //Field offset: 0x38
	private Coroutine m_HurtEffectCoroutine; //Field offset: 0x40
	private Coroutine m_ZombiaCoroutine; //Field offset: 0x48

	public static BattleRoleAttributeComponent instance
	{
		 get { } //Length: 174
	}

	public int judgeState
	{
		 get { } //Length: 4
	}

	private static BattleRoleAttributeComponent() { }

	public BattleRoleAttributeComponent() { }

	public void AddHp(int value) { }

	public void AttackScore(int idx, int result, TimeNodeOrder tno) { }

	private void CalCritical(MusicData md, int result) { }

	private int CalScore(MusicData md, int result) { }

	public void Dead() { }

	private void Destroy() { }

	public static BattleRoleAttributeComponent get_instance() { }

	public int get_judgeState() { }

	public int GetHp() { }

	public int GetHpMax() { }

	public int GetHurtValue() { }

	public float HpRate() { }

	public void Hurt(int hurtValue, bool isAir) { }

	public void Init() { }

	public bool IsDead() { }

	public void MissHardEffect(float duration) { }

	public void Revive(bool ifFirstLoad = false) { }

}

