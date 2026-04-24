//Type is in global namespace

public class PnlVictoryControls
{
	public ResolutionType resolutionType; //Field offset: 0x10
	public GameObject mainPnl; //Field offset: 0x18
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Button btnReset; //Field offset: 0x20
	public Button btnContinue; //Field offset: 0x28
	public Text scoreTxt; //Field offset: 0x30
	public Text highScoreTitle; //Field offset: 0x38
	public Text highScoreTxt; //Field offset: 0x40
	public Text diffTxt; //Field offset: 0x48
	public Text accuracyTxt; //Field offset: 0x50
	public Text maxComboTxt; //Field offset: 0x58
	public GameObject tglLike; //Field offset: 0x60
	public GameObject newBest; //Field offset: 0x68
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Toggle tglAdvJudgment; //Field offset: 0x70
	public GameObject advJudgment; //Field offset: 0x78
	public Animator advJudgmentAnimator; //Field offset: 0x80
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public GameObject detailInfoOther; //Field offset: 0x88
	public GameObject detailInfoTouhou; //Field offset: 0x90
	public Text perfectTxt; //Field offset: 0x98
	public Text greatTxt; //Field offset: 0xA0
	public Text[] passTxt; //Field offset: 0xA8
	public Text[] missTxt; //Field offset: 0xB0
	public Text earlyTxt; //Field offset: 0xB8
	public Text lateTxt; //Field offset: 0xC0
	public Text getTxt; //Field offset: 0xC8

	public PnlVictoryControls() { }

}

