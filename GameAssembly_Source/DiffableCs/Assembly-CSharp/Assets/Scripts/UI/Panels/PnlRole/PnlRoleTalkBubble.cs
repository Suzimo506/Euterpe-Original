namespace Assets.Scripts.UI.Panels.PnlRole;

public class PnlRoleTalkBubble : MonoBehaviour
{
	[SerializeField]
	private Animator m_Animator; //Field offset: 0x18
	private int m_ShowHash; //Field offset: 0x20
	private int m_CloseHash; //Field offset: 0x24
	[SerializeField]
	private Text m_Talk; //Field offset: 0x28
	private float m_EndTime; //Field offset: 0x30
	private bool m_Init; //Field offset: 0x34

	public float endAnimTime
	{
		 get { } //Length: 121
	}

	public PnlRoleTalkBubble() { }

	private void Awake() { }

	public void Close() { }

	public void CloseTalk() { }

	public float get_endAnimTime() { }

	public void ShowTalk(string txt) { }

}

