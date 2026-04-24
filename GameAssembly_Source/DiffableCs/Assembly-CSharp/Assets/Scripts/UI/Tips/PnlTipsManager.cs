namespace Assets.Scripts.UI.Tips;

public class PnlTipsManager : SerializedMonoBehaviour, IPreWarm
{
	private static PnlTipsManager s_Instance; //Field offset: 0x0
	[SerializeField]
	protected static AudioClip s_YesClip; //Field offset: 0x8
	[SerializeField]
	protected static AudioClip s_NoClip; //Field offset: 0x10
	[SerializeField]
	private Dictionary<String, AbstractMessageBox> m_MessageBoxs; //Field offset: 0x58

	public static PnlTipsManager instance
	{
		 get { } //Length: 172
	}

	public static AudioClip noClickSfx
	{
		 get { } //Length: 54
	}

	public static AudioClip yesClickSfx
	{
		 get { } //Length: 54
	}

	public PnlTipsManager() { }

	public static PnlTipsManager get_instance() { }

	public static AudioClip get_noClickSfx() { }

	public static AudioClip get_yesClickSfx() { }

	public AbstractMessageBox GetGeneralMessageBox() { }

	public AbstractMessageBox GetMessageBox(string key) { }

	public T GetMessageBox(string key) { }

	private void Init() { }

	private void OnDestroy() { }

	public override void PreWarm(int slice) { }

	public void ReleaseMessageBox(AbstractMessageBox message) { }

	private void Start() { }

}

