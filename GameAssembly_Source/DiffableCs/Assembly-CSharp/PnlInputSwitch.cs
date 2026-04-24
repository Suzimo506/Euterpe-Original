//Type is in global namespace

public class PnlInputSwitch : UISelectManage
{
	private static readonly String[] buttonProposal; //Field offset: 0x0
	private static readonly String[] revertButtonProposal; //Field offset: 0x8
	public Button switchL; //Field offset: 0x110
	public Button switchR; //Field offset: 0x118
	public Text txtButton; //Field offset: 0x120
	public Text txtScreen; //Field offset: 0x128
	public FancyScrollView controlScrollView; //Field offset: 0x130
	public FancyScrollView buttonFancyScrollView; //Field offset: 0x138
	public FancyScrollView screenFancyScrollView; //Field offset: 0x140
	public FancyScrollView feverFancyScrollView; //Field offset: 0x148
	public FancyScrollView reverseFancyScrollView; //Field offset: 0x150
	public FancyScrollView vibrationFancyScrollView; //Field offset: 0x158
	public PointsBar buttonPointsBar; //Field offset: 0x160
	public PointsBar screenPointsBar; //Field offset: 0x168
	public Color highLightColor; //Field offset: 0x170
	public Color normalColor; //Field offset: 0x180
	[SerializeField]
	private UISetColor[] m_UiSetColors; //Field offset: 0x190
	private bool m_IsButtonPage; //Field offset: 0x198
	private int m_ControlIndex; //Field offset: 0x19C
	private int m_ButtonProposalIndex; //Field offset: 0x1A0
	private int m_ScreenProposalIndex; //Field offset: 0x1A4
	private bool m_IsBtnReverse; //Field offset: 0x1A8
	private bool m_IsTouchReverse; //Field offset: 0x1A9
	private bool m_IsVibration; //Field offset: 0x1AA
	private bool m_IsAutoFever; //Field offset: 0x1AB
	private bool m_IsInitVibration; //Field offset: 0x1AC
	private bool m_IsInitReverse; //Field offset: 0x1AD
	private bool m_IsInitButton; //Field offset: 0x1AE
	private bool m_IsInitScreen; //Field offset: 0x1AF

	private static PnlInputSwitch() { }

	public PnlInputSwitch() { }

}

