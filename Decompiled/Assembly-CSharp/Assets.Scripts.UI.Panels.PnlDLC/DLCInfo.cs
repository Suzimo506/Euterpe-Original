using Assets.Scripts.PeroTools.Nice.Events;
using Assets.Scripts.PeroTools.Nice.Variables;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x2000915")]
public class DLCInfo : MonoBehaviour
{
	[Token(Token = "0x40030DC")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform m_RectTransform;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40030DD")]
	private Transform m_CellTransform;

	[Token(Token = "0x40030DE")]
	[FieldOffset(Offset = "0x28")]
	private Transform m_ThisTransform;

	[Token(Token = "0x40030DF")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private DlcSizeAlbumPair m_DlcSizeAlbumPair;

	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x822E0", Offset = "0x816E0")]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40030E0")]
	[SerializeField]
	[Attribute(Name = "HeaderAttribute", RVA = "0x822E0", Offset = "0x816E0")]
	private DLCInfoBaseControl m_BaseSubControl;

	[Token(Token = "0x40030E1")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private DLCInfoBasePurchaseControl m_BasePurchaseControl;

	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x40030E2")]
	private OnFancyScrollViewCellUpdate m_FsvCellUpdate;

	[SerializeField]
	[Token(Token = "0x40030E3")]
	[FieldOffset(Offset = "0x50")]
	private VariableBehaviour m_VariableBehaviour;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40030E4")]
	private int m_Index;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40030E5")]
	private IPnlDlcCellData m_CurCellData;

	[Token(Token = "0x40030E6")]
	[FieldOffset(Offset = "0x68")]
	private PnlDlc m_Parent;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40030E7")]
	private PnlDlcFSVCellCache m_CellCache;

	[Token(Token = "0x40030E8")]
	[FieldOffset(Offset = "0x78")]
	private bool m_Inited;

	[Token(Token = "0x40030E9")]
	[FieldOffset(Offset = "0x79")]
	private bool m_IsSelected;

	[Token(Token = "0x40030EA")]
	[FieldOffset(Offset = "0x80")]
	private Coroutine m_DelayRefreshCoroutine;

	[Token(Token = "0x170008B8")]
	public IPnlDlcCellData pnlDlcCellData
	{
		[Address(RVA = "0x4293D0", Offset = "0x427BD0", Length = "0x5")]
		[Token(Token = "0x6005268")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008B9")]
	public string selectedCBUid
	{
		[Address(RVA = "0x4293E0", Offset = "0x427BE0", Length = "0xB7")]
		[Token(Token = "0x6005269")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008BA")]
	public PnlDlc parent
	{
		[Address(RVA = "0x4293C0", Offset = "0x427BC0", Length = "0x5")]
		[Token(Token = "0x600526A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600526B")]
	[Address(RVA = "0x427D90", Offset = "0x426590", Length = "0x16C")]
	public void Init(PnlDlc dlcParent)
	{
	}

	[Token(Token = "0x600526C")]
	[Address(RVA = "0x428630", Offset = "0x426E30", Length = "0x11E")]
	private void RegisterEvent()
	{
	}

	[Token(Token = "0x600526D")]
	[Address(RVA = "0x4291B0", Offset = "0x4279B0", Length = "0x17E")]
	private void UngisterEvent()
	{
	}

	[Address(RVA = "0x428080", Offset = "0x426880", Length = "0x12D")]
	[Token(Token = "0x600526E")]
	private void OnDataIndexChange(int index)
	{
	}

	[Token(Token = "0x600526F")]
	[Address(RVA = "0x428340", Offset = "0x426B40", Length = "0x174")]
	private void OnFinalItemChange(int index)
	{
	}

	[Token(Token = "0x6005270")]
	[Address(RVA = "0x4284C0", Offset = "0x426CC0", Length = "0xA7")]
	private void OnPurchasedSuccess()
	{
	}

	[Token(Token = "0x6005271")]
	[Address(RVA = "0x428580", Offset = "0x426D80", Length = "0xA7")]
	public void Refresh(int newIndex, bool isForce = false)
	{
	}

	[Address(RVA = "0x428820", Offset = "0x427020", Length = "0x16C")]
	[Token(Token = "0x6005272")]
	private void SetBaseSize(IPnlDlcCellData cellData)
	{
	}

	[Address(RVA = "0x428F70", Offset = "0x427770", Length = "0x186")]
	[Token(Token = "0x6005273")]
	private void SetGameObjectName(IPnlDlcCellData data)
	{
	}

	[Address(RVA = "0x427F00", Offset = "0x426700", Length = "0x17B")]
	[Token(Token = "0x6005274")]
	private bool IsCurDataMpOrJAP(ref int jsonIndex)
	{
		return default(bool);
	}

	[Address(RVA = "0x428570", Offset = "0x426D70", Length = "0xC")]
	[Token(Token = "0x6005275")]
	public void RefreshDlcCell()
	{
	}

	[Token(Token = "0x6005276")]
	[Address(RVA = "0x428990", Offset = "0x427190", Length = "0x5D6")]
	private void SetDlcCell(IPnlDlcCellData cellData)
	{
	}

	[Address(RVA = "0x428750", Offset = "0x426F50", Length = "0xC8")]
	[Token(Token = "0x6005277")]
	private void ResetCell()
	{
	}

	[Address(RVA = "0x429100", Offset = "0x427900", Length = "0xA8")]
	[Token(Token = "0x6005278")]
	private void TryRefreshBasePurchase(Transform dlcPrefab)
	{
	}

	[Address(RVA = "0x427D60", Offset = "0x426560", Length = "0x27")]
	[Token(Token = "0x6005279")]
	public void SetPlayMask(int index, bool isBillboard = false)
	{
	}

	[Address(RVA = "0x427D30", Offset = "0x426530", Length = "0x24")]
	[Token(Token = "0x600527A")]
	private void Awake()
	{
	}

	[Token(Token = "0x600527B")]
	[Address(RVA = "0x4281B0", Offset = "0x4269B0", Length = "0x185")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x427D60", Offset = "0x426560", Length = "0x27")]
	[Token(Token = "0x600527C")]
	private void Editor_SetPlayMask(int index, bool isBillboard = false)
	{
	}

	[Address(RVA = "0x429330", Offset = "0x427B30", Length = "0x8B")]
	[Token(Token = "0x600527D")]
	public DLCInfo()
	{
	}
}
