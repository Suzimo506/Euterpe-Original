namespace Assets.Scripts.UI.Panels.PnlDLC;

public class DLCInfoSubControl : SerializedMonoBehaviour
{
	public Transform cellContent; //Field offset: 0x58
	[SerializeField]
	private GridLayoutGroup m_GridLayout; //Field offset: 0x60
	[SerializeField]
	private Dictionary<Int32, GridLayoutArgs> m_GridLayoutArgs; //Field offset: 0x68
	[SerializeField]
	private GameObject musicDiscoCell; //Field offset: 0x70
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	private EnableDisableHooker m_SliderHooker; //Field offset: 0x78
	[SerializeField]
	private GameObject m_DownTip; //Field offset: 0x80
	private List<DLCSongCellControl> m_CellControls; //Field offset: 0x88
	[CompilerGenerated]
	private int <jsonIndex>k__BackingField; //Field offset: 0x90
	private Stack<DLCSongCellControl> m_CellStack; //Field offset: 0x98

	public private int jsonIndex
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public DLCInfoSubControl() { }

	[CompilerGenerated]
	public int get_jsonIndex() { }

	[CompilerGenerated]
	private void set_jsonIndex(int value) { }

}

