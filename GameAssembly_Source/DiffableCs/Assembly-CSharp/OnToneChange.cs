//Type is in global namespace

public class OnToneChange : StateMachineBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public Animator animator; //Field offset: 0x10
		public AnimatorStateInfo stateInfo; //Field offset: 0x18
		public OnToneChange <>4__this; //Field offset: 0x40

		public <>c__DisplayClass5_0() { }

		internal void <Invoke>b__0() { }

	}

	internal enum ToneState
	{
		Ground = 0,
		Air = 1,
	}

	private static Coroutine m_AirCoroutine; //Field offset: 0x0
	private static Coroutine m_GroundCoroutine; //Field offset: 0x8
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float percent; //Field offset: 0x18
	public ToneState state; //Field offset: 0x1C

	public OnToneChange() { }

	private Coroutine Invoke(Animator animator, AnimatorStateInfo stateInfo) { }

	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

}

