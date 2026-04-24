namespace Assets.Scripts.PeroTools.Nice.Actions;

public class PlaySound : Action
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<String> <>9__6_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Enter>b__6_0(string name) { }

	}

	[OnConstanceChanged(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_AudioClipSource; //Field offset: 0x10
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_Volume; //Field offset: 0x18
	private AudioClip m_AudioClip; //Field offset: 0x20
	[HideInInspector]
	[SerializeField]
	private List<String> m_AudioClipNames; //Field offset: 0x28

	public virtual float duration
	{
		 get { } //Length: 133
	}

	public PlaySound() { }

	public virtual void Enter() { }

	public virtual void Execute() { }

	public virtual float get_duration() { }

}

