namespace Assets.Scripts.UI.Panels.PnlDLC;

public class DLCSongCellControl : MonoBehaviour
{
	private const int easy = 0; //Field offset: 0x0
	private const int normal = 1; //Field offset: 0x0
	private const int master = 2; //Field offset: 0x0
	[SerializeField]
	private GameObject m_MaskGameObject; //Field offset: 0x18
	[SerializeField]
	private Image m_Cover; //Field offset: 0x20
	[SerializeField]
	private Text[] m_DiffTxt; //Field offset: 0x28
	[SerializeField]
	private Image m_WeekFree; //Field offset: 0x30
	[SerializeField]
	private Button m_Btn; //Field offset: 0x38
	private MusicInfo m_MusicInfo; //Field offset: 0x40
	private int m_ExtraIndex; //Field offset: 0x48
	private DLCInfoSubControl m_Parent; //Field offset: 0x50

	public int extraIndex
	{
		 get { } //Length: 4
	}

	public MusicInfo musicInfo
	{
		 get { } //Length: 5
	}

	public DLCSongCellControl() { }

	public int get_extraIndex() { }

	public MusicInfo get_musicInfo() { }

}

