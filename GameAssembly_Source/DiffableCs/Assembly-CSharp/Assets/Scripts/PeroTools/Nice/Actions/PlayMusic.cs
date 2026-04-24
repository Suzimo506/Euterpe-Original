namespace Assets.Scripts.PeroTools.Nice.Actions;

public class PlayMusic : Action
{
	[OnConstanceChanged(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_AudioClipSource; //Field offset: 0x10
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_FadeInTime; //Field offset: 0x18
	[SerializeField]
	private Ease m_Ease; //Field offset: 0x20
	[HideInInspector]
	[SerializeField]
	private List<String> m_AudioClipNames; //Field offset: 0x28
	private AudioClip m_AudioClip; //Field offset: 0x30

	public virtual float duration
	{
		 get { } //Length: 133
	}

	public PlayMusic() { }

	public virtual void Execute() { }

	public virtual float get_duration() { }

}

