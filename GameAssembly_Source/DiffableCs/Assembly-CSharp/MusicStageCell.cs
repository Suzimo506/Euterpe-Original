//Type is in global namespace

public class MusicStageCell : MonoBehaviour
{
	private static Int32[] s_BaseAlbumUids; //Field offset: 0x0
	[SerializeField]
	private VariableBehaviour m_CellVariable; //Field offset: 0x18
	private int m_CellIndex; //Field offset: 0x20
	[SerializeField]
	private Image m_StageImg; //Field offset: 0x28
	public MusicInfo musicInfo; //Field offset: 0x30
	[SerializeField]
	private GameObject m_LockObj; //Field offset: 0x38
	private int m_MusicUnlockLevel; //Field offset: 0x40
	[SerializeField]
	private Text m_LockTxt; //Field offset: 0x48
	[SerializeField]
	private GameObject m_WeekFreeImg; //Field offset: 0x50

	private static MusicStageCell() { }

	public MusicStageCell() { }

	private void Awake() { }

	private void IsBaseAlbum() { }

	internal void OnChangeCell(float i) { }

	private void OnDestroy() { }

}

