namespace GameLogic;

public class OnJumpEnd : DoNothing
{
	private SpineActionController m_Sac; //Field offset: 0x20
	private Animator m_Animator; //Field offset: 0x28

	public OnJumpEnd() { }

	public virtual void Do(TrackEntry entry) { }

	public virtual void Init() { }

}

