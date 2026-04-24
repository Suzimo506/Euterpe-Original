namespace Assets.Scripts.GameCore.GameObjectLogics.GameObjectControl;

public class PlayAnimation : StateMachineBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public Animator animator; //Field offset: 0x10
		public string sName; //Field offset: 0x18
		public PlayAnimation <>4__this; //Field offset: 0x20

		public <>c__DisplayClass11_0() { }

		internal void <Play>b__0() { }

		internal void <Play>b__1() { }

	}

	internal enum ActionType
	{
		Reset = 0,
		KeepCurrent = 1,
	}

	internal enum PlayType
	{
		Skeleton = 0,
		DOTween = 1,
		Animation = 2,
		Animator = 3,
	}

	internal enum Timing
	{
		Enter = 0,
		Exit = 1,
	}

	public PlayType playType; //Field offset: 0x18
	public List<String> animationNames; //Field offset: 0x20
	public bool isLoop; //Field offset: 0x28
	public ActionType actionType; //Field offset: 0x2C
	public Timing timing; //Field offset: 0x30
	public float delay; //Field offset: 0x34
	private SkeletonAnimation m_SAnimation; //Field offset: 0x38
	private Animation m_Animation; //Field offset: 0x40
	private Sequence m_DelaySeq; //Field offset: 0x48

	public PlayAnimation() { }

	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	private void Play(Animator animator) { }

}

