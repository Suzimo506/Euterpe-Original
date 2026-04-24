namespace Assets.Scripts.GameCore.Managers;

public abstract class AbstractGirlManager : BaseManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<MusicData> <>9__22_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <InitAutoPlay>b__22_0(MusicData l, MusicData r) { }

	}

	[CompilerGenerated]
	private sealed class <AfterComeOut>d__41 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public AbstractGirlManager <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <AfterComeOut>d__41(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <ComeOutFinished>d__40 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public AbstractGirlManager <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <ComeOutFinished>d__40(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private const float play_wait_for_comeout = 3; //Field offset: 0x0
	protected bool m_IsJumpingAction; //Field offset: 0x10
	protected GirlActionController m_CurGirlActionController; //Field offset: 0x18
	protected Animator m_CurAnimator; //Field offset: 0x20
	protected SpineActionController m_Sac; //Field offset: 0x28
	protected List<String> m_HurtVoice; //Field offset: 0x30
	protected bool m_IsAir; //Field offset: 0x38
	protected AudioSource m_GirlEffectAs; //Field offset: 0x40
	[CompilerGenerated]
	private bool <isThisFrameJumpUp>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private bool <isThisFrameJumpDown>k__BackingField; //Field offset: 0x49
	public Coroutine hurtCoroutine; //Field offset: 0x50
	protected List<Decimal> m_DownHitTime; //Field offset: 0x58
	protected float m_MulHitTime; //Field offset: 0x60
	protected float m_MulHitHardTime; //Field offset: 0x64
	public GameObject girl; //Field offset: 0x68
	public GameObject girlGhost; //Field offset: 0x70
	private bool isCommingOut; //Field offset: 0x78

	public Animator animator
	{
		 get { } //Length: 5
	}

	public AudioSource girlEffectAs
	{
		 get { } //Length: 5
	}

	public bool IsAir
	{
		 get { } //Length: 5
	}

	public bool IsCommingOut
	{
		 get { } //Length: 5
	}

	public bool isThisFrameJumpDown
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool isThisFrameJumpUp
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	protected AbstractGirlManager() { }

	[CompilerGenerated]
	private void <AwakeInit>b__34_0(float t) { }

	[CompilerGenerated]
	private void <PlayHurtRoleEffect>b__46_0() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator AfterComeOut() { }

	public void AttacksWithoutExchange(uint result, string actKey = null, int id = -1) { }

	public abstract void AutoPlay(TimeNodeOrder tno, ref decimal ts, ref bool oneHint) { }

	public virtual void AwakeInit() { }

	public void BeAttackEffect() { }

	public void ComeOut() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator ComeOutFinished() { }

	public override void Dead() { }

	public void DestroyGirlSpineAnimation() { }

	public Animator get_animator() { }

	public AudioSource get_girlEffectAs() { }

	public bool get_IsAir() { }

	public bool get_IsCommingOut() { }

	[CompilerGenerated]
	public bool get_isThisFrameJumpDown() { }

	[CompilerGenerated]
	public bool get_isThisFrameJumpUp() { }

	public Vector3 GetCurrentGirlBonePosition(string boneName) { }

	public Vector3 GetCurrentGirlPositon() { }

	public override void Hurt() { }

	private void HurtOnlyAudio() { }

	public void InitAutoPlay() { }

	public void InstanceGirl() { }

	public bool IsJumpingAction() { }

	public void PlayAnimationCallback(string actionKey) { }

	private void PlayHurtRoleEffect() { }

	protected void PlayLongEffectSound(bool toPlay) { }

	public abstract void PlayLongEndAnimator(bool isAir) { }

	public override void PlayLongPressAnimator(bool isPress, bool isAir) { }

	public abstract void PlayRandomHitNothingAnim() { }

	public virtual void Release() { }

	[CompilerGenerated]
	protected void set_isThisFrameJumpDown(bool value) { }

	[CompilerGenerated]
	protected void set_isThisFrameJumpUp(bool value) { }

	public void SetJumpingAction(bool value) { }

	public void SetTone(bool isAir) { }

	public void UnLockActionProtect() { }

}

