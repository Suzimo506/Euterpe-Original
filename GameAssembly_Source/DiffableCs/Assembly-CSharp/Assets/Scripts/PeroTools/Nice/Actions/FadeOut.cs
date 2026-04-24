namespace Assets.Scripts.PeroTools.Nice.Actions;

public class FadeOut : Action
{
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_GameObejct; //Field offset: 0x10
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_To; //Field offset: 0x18
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_Duration; //Field offset: 0x20
	[SerializeField]
	private Ease m_Ease; //Field offset: 0x28
	private Tweener m_Tweener; //Field offset: 0x30
	private CanvasGroup m_CanvasGroup; //Field offset: 0x38

	public virtual float duration
	{
		 get { } //Length: 94
	}

	public FadeOut() { }

	public virtual void Execute() { }

	public virtual float get_duration() { }

	public virtual void Pause() { }

	public virtual void Resume() { }

}

