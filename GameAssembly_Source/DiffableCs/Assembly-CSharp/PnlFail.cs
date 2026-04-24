//Type is in global namespace

public class PnlFail : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static DOGetter<Single> <>9__8_0; //Field offset: 0x8
		public static DOSetter<Single> <>9__8_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal float <Fail>b__8_0() { }

		internal void <Fail>b__8_1(float volume) { }

	}

	[SerializeField]
	private GameObject m_FailBg; //Field offset: 0x18
	[SerializeField]
	private AudioClip m_FailMusic; //Field offset: 0x20
	[SerializeField]
	private Button m_Return; //Field offset: 0x28
	[SerializeField]
	private Button m_Restart; //Field offset: 0x30
	private float m_PrevVolume; //Field offset: 0x38

	public PnlFail() { }

	private void Awake() { }

	public void Fail() { }

	private void OnEnable() { }

	private void OnFadeOutComplete() { }

	private void OnRestartClicked() { }

	private void OnReturnClicked() { }

}

