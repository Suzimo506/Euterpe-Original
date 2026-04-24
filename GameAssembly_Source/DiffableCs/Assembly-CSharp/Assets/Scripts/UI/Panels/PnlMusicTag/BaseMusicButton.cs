namespace Assets.Scripts.UI.Panels.PnlMusicTag;

public class BaseMusicButton : MonoBehaviour
{
	[SerializeField]
	protected Button m_CellBtn; //Field offset: 0x18
	protected MusicInfo m_MusicInfo; //Field offset: 0x20

	public BaseMusicButton() { }

}

