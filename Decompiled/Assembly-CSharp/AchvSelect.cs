using System.Collections.Generic;
using Assets.Scripts.PeroTools.UI;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000D3")]
public class AchvSelect : UISelectManage
{
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000511")]
	[SerializeField]
	private RectTransform m_Rect;

	[Attribute(Name = "HeaderAttribute", RVA = "0xA1E40", Offset = "0xA1240")]
	[Token(Token = "0x4000512")]
	[FieldOffset(Offset = "0x120")]
	public Transform challenges;

	[Token(Token = "0x4000513")]
	[SerializeField]
	[FieldOffset(Offset = "0x128")]
	private GameObject m_TaskBoxPrefab;

	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000514")]
	private GameObject[] m_TaskBoxs;

	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000515")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x95830", Offset = "0x94C30")]
	public Transform achv;

	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000516")]
	[SerializeField]
	private GameObject m_AchvBoxs;

	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4000517")]
	public Scrollbar scrollbar;

	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	[Token(Token = "0x4000518")]
	private GameObject m_RefreshTime;

	[Token(Token = "0x4000519")]
	[FieldOffset(Offset = "0x158")]
	public AudioClip pnlMusic;

	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x400051A")]
	public Color highLight;

	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x400051B")]
	public Color normal;

	[Token(Token = "0x400051C")]
	[FieldOffset(Offset = "0x180")]
	public float animTime;

	[Token(Token = "0x400051D")]
	[FieldOffset(Offset = "0x188")]
	private readonly List<GameObject> m_SelectableGameObjects;

	[Token(Token = "0x400051E")]
	[FieldOffset(Offset = "0x190")]
	private readonly List<GameObject> m_SeeableObj;

	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x400051F")]
	private GameObject m_LastObj;

	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x4000520")]
	private int m_ChallengeCount;

	[FieldOffset(Offset = "0x1A4")]
	[Token(Token = "0x4000521")]
	private bool m_IsPress;

	[Token(Token = "0x4000522")]
	[FieldOffset(Offset = "0x1A8")]
	private InputKeyBinding m_DeleteButton;

	[Token(Token = "0x4000523")]
	[FieldOffset(Offset = "0x1B0")]
	private bool m_TaskDirty;

	[Token(Token = "0x4000524")]
	private const int max_task_count = 3;

	[Token(Token = "0x4000525")]
	[FieldOffset(Offset = "0x1B8")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x1F70", Offset = "0x1370")]
	public Button btnAchCard;

	[FieldOffset(Offset = "0x1C0")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x1F70", Offset = "0x1370")]
	[Token(Token = "0x4000526")]
	public Button btnHead;

	[Token(Token = "0x4000527")]
	[FieldOffset(Offset = "0x1C8")]
	public Button btnShowTotalLevelNum;

	[Token(Token = "0x4000528")]
	[FieldOffset(Offset = "0x1D0")]
	public Image imgHead;

	[Token(Token = "0x4000529")]
	[FieldOffset(Offset = "0x1D8")]
	public Text txtPlayerName;

	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x400052A")]
	public Text txtPlayerLevel;

	[FieldOffset(Offset = "0x1E8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x2140", Offset = "0x1540")]
	[Token(Token = "0x400052B")]
	public List<LayoutElement> separators;

	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x400052C")]
	public int notShowTotalSpPreferedWidth;

	[FieldOffset(Offset = "0x1F4")]
	[Token(Token = "0x400052D")]
	public int showTotalNumSpPreferedWidth;

	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x400052E")]
	private float realNotShowTotalSpPreferedWidth;

	[Token(Token = "0x400052F")]
	[FieldOffset(Offset = "0x1FC")]
	private float realShowTotalNumSpPreferedWidth;

	[Token(Token = "0x4000530")]
	[FieldOffset(Offset = "0x200")]
	public GameObject lastSeparatorObj;

	[Token(Token = "0x4000531")]
	[FieldOffset(Offset = "0x208")]
	public GameObject passItemHidelevel;

	[Token(Token = "0x4000532")]
	[FieldOffset(Offset = "0x210")]
	public Text txtNumEasy;

	[Token(Token = "0x4000533")]
	[FieldOffset(Offset = "0x218")]
	public Text txtNumHard;

	[Token(Token = "0x4000534")]
	[FieldOffset(Offset = "0x220")]
	public Text txtNumMaster;

	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000535")]
	public Text txtNumHideLevel;

	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000536")]
	public float passItemMinSize;

	[Token(Token = "0x4000537")]
	[FieldOffset(Offset = "0x238")]
	public Text txtNumFC;

	[Token(Token = "0x4000538")]
	[FieldOffset(Offset = "0x240")]
	public Text txtRedS;

	[Token(Token = "0x4000539")]
	[FieldOffset(Offset = "0x248")]
	public Text txtNumSilverS;

	[Token(Token = "0x400053A")]
	[FieldOffset(Offset = "0x250")]
	public Text txtNumGoldS;

	[Token(Token = "0x400053B")]
	[FieldOffset(Offset = "0x258")]
	private bool m_IsShowTotalLevelNum;

	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x400053C")]
	private List<UnityEngine.UI.ContentSizeFitter> contentSizeFitters;

	[Address(RVA = "0x58F020", Offset = "0x58D820", Length = "0x134")]
	[Token(Token = "0x60005E1")]
	private void RefreshSpPreferedWidth()
	{
	}

	[Token(Token = "0x60005E2")]
	[Address(RVA = "0x58DC00", Offset = "0x58C400", Length = "0xEC")]
	private void OnHeadClick()
	{
	}

	[Token(Token = "0x60005E3")]
	[Address(RVA = "0x58EF20", Offset = "0x58D720", Length = "0xF3")]
	private void RefreshNameAndLevel()
	{
	}

	[Address(RVA = "0x58E2F0", Offset = "0x58CAF0", Length = "0xE3")]
	[Token(Token = "0x60005E4")]
	private void RefreshHead()
	{
	}

	[Address(RVA = "0x58E590", Offset = "0x58CD90", Length = "0x984")]
	[Token(Token = "0x60005E5")]
	private void RefreshLevelPassStatistic(bool usepOpposite = false)
	{
	}

	[Address(RVA = "0x58E3E0", Offset = "0x58CBE0", Length = "0x1A6")]
	[Token(Token = "0x60005E6")]
	private void RefreshLevelEvaluteUI()
	{
	}

	[Token(Token = "0x60005E7")]
	[Address(RVA = "0x58CF20", Offset = "0x58B720", Length = "0x20A")]
	private void FindContentSizeFitters(Transform parent)
	{
	}

	[Token(Token = "0x60005E8")]
	[Address(RVA = "0x58E1C0", Offset = "0x58C9C0", Length = "0x95")]
	private void RefreshAllContentSizeFitters()
	{
	}

	[Address(RVA = "0x58E260", Offset = "0x58CA60", Length = "0x80")]
	[Token(Token = "0x60005E9")]
	private void RefreshChalengeBoxs()
	{
	}

	[Address(RVA = "0x58D250", Offset = "0x58BA50", Length = "0x3F9")]
	[Token(Token = "0x60005EA")]
	public override void OnAwake()
	{
	}

	[Address(RVA = "0x58F4F0", Offset = "0x58DCF0", Length = "0x44")]
	[Token(Token = "0x60005EB")]
	private void SetDirty(object sender, object rev, params object[] args)
	{
	}

	[Token(Token = "0x60005EC")]
	[Address(RVA = "0x58D130", Offset = "0x58B930", Length = "0x119")]
	private void InitKeyBinding(GameObject go)
	{
	}

	[Token(Token = "0x60005ED")]
	[Address(RVA = "0x58CEC0", Offset = "0x58B6C0", Length = "0x5F")]
	private void FastDestroyAllTask()
	{
	}

	[Token(Token = "0x60005EE")]
	[Address(RVA = "0x58F160", Offset = "0x58D960", Length = "0x261")]
	private void RefreshTask()
	{
	}

	[Token(Token = "0x60005EF")]
	[Address(RVA = "0x58DCF0", Offset = "0x58C4F0", Length = "0xB3")]
	public override void OnInit()
	{
	}

	[Address(RVA = "0x58D750", Offset = "0x58BF50", Length = "0x4A3")]
	[Token(Token = "0x60005F0")]
	public override void OnEnablePnl()
	{
	}

	[Address(RVA = "0x58CD60", Offset = "0x58B560", Length = "0x155")]
	[Token(Token = "0x60005F1")]
	public override GameObject DefaultSelectObj()
	{
		return null;
	}

	[Address(RVA = "0x58FB30", Offset = "0x58E330", Length = "0x8")]
	[Token(Token = "0x60005F2")]
	public override List<GameObject> SetSelectableObj()
	{
		return null;
	}

	[Address(RVA = "0x58DDB0", Offset = "0x58C5B0", Length = "0x241")]
	[Token(Token = "0x60005F3")]
	protected override void OnSelect(GameObject currentObj)
	{
	}

	[Token(Token = "0x60005F4")]
	[Address(RVA = "0x58E000", Offset = "0x58C800", Length = "0x1BF")]
	public override void OnUpdatePnl()
	{
	}

	[Token(Token = "0x60005F5")]
	[Address(RVA = "0x58F540", Offset = "0x58DD40", Length = "0xB2")]
	public override Transform SetEdgeObj(GameObject currentObj)
	{
		return null;
	}

	[Address(RVA = "0x58F600", Offset = "0x58DE00", Length = "0x396")]
	[Token(Token = "0x60005F6")]
	private void SetObjHighLight(GameObject obj, bool isSelect)
	{
	}

	[Address(RVA = "0x58FD90", Offset = "0x58E590", Length = "0x6A0")]
	[Token(Token = "0x60005F7")]
	public void UpdateSelectableObj()
	{
	}

	[Address(RVA = "0x58F9A0", Offset = "0x58E1A0", Length = "0x188")]
	[Token(Token = "0x60005F8")]
	private void SetScrollBar(int currentIndex)
	{
	}

	[Address(RVA = "0x58F460", Offset = "0x58DC60", Length = "0x8B")]
	[Token(Token = "0x60005F9")]
	public void ScrollToTop()
	{
	}

	[Token(Token = "0x60005FA")]
	[Address(RVA = "0x58F3D0", Offset = "0x58DBD0", Length = "0x81")]
	public void RemuseDeleteButton()
	{
	}

	[Address(RVA = "0x58D650", Offset = "0x58BE50", Length = "0xFC")]
	[Token(Token = "0x60005FB")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60005FC")]
	[Address(RVA = "0x590440", Offset = "0x58EC40", Length = "0x106")]
	public AchvSelect()
	{
	}
}
