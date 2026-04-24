namespace Assets.Scripts.UI.Controls;

public class CharacterApply : SerializedMonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public string endAnimName; //Field offset: 0x10
		public CharacterApply <>4__this; //Field offset: 0x18
		public Action endCallback; //Field offset: 0x20
		public AnimationClip endClip; //Field offset: 0x28
		public Action <>9__2; //Field offset: 0x30

		public <>c__DisplayClass16_0() { }

		internal bool <PlayCharacterApply>b__0(AnimationClip a) { }

		internal void <PlayCharacterApply>b__1() { }

		internal void <PlayCharacterApply>b__2() { }

	}

	public string characterAnimation; //Field offset: 0x58
	public string characterSound; //Field offset: 0x60
	private bool m_IsMainShow; //Field offset: 0x68
	[SerializeField]
	private Animator m_Animator; //Field offset: 0x70
	private int m_Index; //Field offset: 0x78
	private AudioSource m_AudioSource; //Field offset: 0x80
	private Coroutine m_EndCoroutine; //Field offset: 0x88
	private Coroutine m_AudioCoroutine; //Field offset: 0x90
	private bool m_Init; //Field offset: 0x98

	public bool isMainShow
	{
		 get { } //Length: 5
	}

	public CharacterApply() { }

	public void Clean() { }

	public bool get_isMainShow() { }

	public void Init(int index, bool isMainShow = false) { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void PlayAnim(string animName) { }

	public void PlayCharacterApply() { }

	public void PlayCharacterApply(string animName, string voiceName, Action endCallback = null, bool autoAddSuffix = true) { }

}

