namespace Assets.Scripts.PeroTools.Nice.Actions;

public class SetVolume : Action
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public AudioSource audioSource; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_1
	{
		public float volume; //Field offset: 0x10
		public <>c__DisplayClass6_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass6_1() { }

		internal void <SetAudioSourceVolume>b__0() { }

	}

	internal enum AudioType
	{
		BGM = 0,
		Others = 1,
	}

	[SerializeField]
	private AudioType m_AudioType; //Field offset: 0x10
	[SerializeField]
	private AudioSource m_AudioSource; //Field offset: 0x18
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_Volume; //Field offset: 0x20
	[SerializeField]
	private float m_Duration; //Field offset: 0x28
	[SerializeField]
	private Ease m_Ease; //Field offset: 0x2C

	public SetVolume() { }

	public virtual void Execute() { }

	private void SetAudioSourceVolume(AudioSource audioSource) { }

}

