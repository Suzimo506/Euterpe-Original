namespace Assets.Scripts.GameCore.GameObjectLogics.GameObjectControl;

public class OnCharacterJumpTiming : StateMachineBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public Animator animator; //Field offset: 0x10
		public AnimatorStateInfo stateInfo; //Field offset: 0x18
		public OnCharacterJumpTiming <>4__this; //Field offset: 0x40

		public <>c__DisplayClass6_0() { }

		internal void <Invoke>b__0() { }

	}

	internal enum JumpState
	{
		Start = 0,
		End = 1,
	}

	private static Coroutine m_StartCoroutine; //Field offset: 0x0
	private static Coroutine m_EndCoroutine; //Field offset: 0x8
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float percent; //Field offset: 0x18
	public JumpState state; //Field offset: 0x1C
	public bool endDust; //Field offset: 0x20

	public OnCharacterJumpTiming() { }

	private Coroutine Invoke(Animator animator, AnimatorStateInfo stateInfo) { }

	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

}

