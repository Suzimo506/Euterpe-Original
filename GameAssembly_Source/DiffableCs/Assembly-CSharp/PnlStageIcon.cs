//Type is in global namespace

public class PnlStageIcon : MonoBehaviour
{
	private Image m_Image; //Field offset: 0x18
	private Sprite m_Sprite; //Field offset: 0x20
	private Text m_Title; //Field offset: 0x28
	private Color m_TitleColor; //Field offset: 0x30
	private Color m_BgColor; //Field offset: 0x40
	private bool m_IsLock; //Field offset: 0x50
	public Sprite iconLock; //Field offset: 0x58
	public Sprite iconWeekFree; //Field offset: 0x60

	public PnlStageIcon() { }

}

