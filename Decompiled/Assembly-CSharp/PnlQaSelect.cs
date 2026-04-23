using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000130")]
public class PnlQaSelect : UISelectManage
{
	[Token(Token = "0x400076E")]
	[FieldOffset(Offset = "0x118")]
	public RectTransform content;

	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x400076F")]
	public Scrollbar scrollbar;

	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000770")]
	private List<GameObject> m_SelectableGameObjects;

	[Token(Token = "0x4000771")]
	[FieldOffset(Offset = "0x130")]
	private bool m_IsPress;

	[Token(Token = "0x4000772")]
	[FieldOffset(Offset = "0x134")]
	private int m_LastIndex;

	[Token(Token = "0x4000773")]
	[SerializeField]
	[FieldOffset(Offset = "0x138")]
	private List<Button> m_Btns;

	[SerializeField]
	[Token(Token = "0x4000774")]
	[FieldOffset(Offset = "0x140")]
	private List<QAButton> m_BtnQAs_Mobile;

	[SerializeField]
	[Token(Token = "0x4000775")]
	[FieldOffset(Offset = "0x148")]
	private List<QAButton> m_BtnQAs_Other;

	[SerializeField]
	[Token(Token = "0x4000776")]
	[FieldOffset(Offset = "0x150")]
	private Button m_BackBtn;

	[Token(Token = "0x4000777")]
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	private Animator m_PnlAnimator;

	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4000778")]
	private bool m_HandlerEvent;

	[Token(Token = "0x4000779")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x1F6B0", Offset = "0x1EAB0")]
	[FieldOffset(Offset = "0x168")]
	public Text title;

	[Attribute(Name = "HeaderAttribute", RVA = "0x1F7E0", Offset = "0x1EBE0")]
	[Token(Token = "0x400077A")]
	[FieldOffset(Offset = "0x170")]
	public GameObject Question8;

	[Token(Token = "0x400077B")]
	[FieldOffset(Offset = "0x178")]
	public GameObject Question9;

	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x400077C")]
	public Text Question12_Simple;

	[Token(Token = "0x400077D")]
	[FieldOffset(Offset = "0x188")]
	public Button question9_Simple;

	[Token(Token = "0x400077E")]
	[FieldOffset(Offset = "0x190")]
	public Button question12_Simple;

	[Token(Token = "0x170000A9")]
	private List<QAButton> m_BtnQAs
	{
		[Token(Token = "0x6000891")]
		[Address(RVA = "0x561370", Offset = "0x55FB70", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000892")]
	[Address(RVA = "0x560990", Offset = "0x55F190", Length = "0x210")]
	public override void OnEnablePnl()
	{
	}

	[Token(Token = "0x6000893")]
	[Address(RVA = "0x560980", Offset = "0x55F180", Length = "0x8")]
	public override void OnDisablePnl()
	{
	}

	[Token(Token = "0x6000894")]
	[Address(RVA = "0x5605A0", Offset = "0x55EDA0", Length = "0x294")]
	public override void OnAwake()
	{
	}

	[Token(Token = "0x6000895")]
	[Address(RVA = "0x560840", Offset = "0x55F040", Length = "0x137")]
	private void OnBackClicked()
	{
	}

	[Token(Token = "0x6000896")]
	[Address(RVA = "0x560BB0", Offset = "0x55F3B0", Length = "0xB7")]
	private void OnQAButtonClicked(Button btn, int index)
	{
	}

	[Token(Token = "0x6000897")]
	[Address(RVA = "0x561290", Offset = "0x55FA90", Length = "0x8")]
	public override List<GameObject> SetSelectableObj()
	{
		return null;
	}

	[Token(Token = "0x6000898")]
	[Address(RVA = "0x560E80", Offset = "0x55F680", Length = "0x7B")]
	public override Transform SetEdgeObj(GameObject currentObj)
	{
		return null;
	}

	[Address(RVA = "0x560C70", Offset = "0x55F470", Length = "0x1C0")]
	[Token(Token = "0x6000899")]
	protected override void OnSelect(GameObject currentObj)
	{
	}

	[Token(Token = "0x600089A")]
	[Address(RVA = "0x5604E0", Offset = "0x55ECE0", Length = "0xBD")]
	public override GameObject DefaultSelectObj()
	{
		return null;
	}

	[Address(RVA = "0x560E40", Offset = "0x55F640", Length = "0x40")]
	[Token(Token = "0x600089B")]
	public override void OnUpdatePnl()
	{
	}

	[Address(RVA = "0x560F00", Offset = "0x55F700", Length = "0x38C")]
	[Token(Token = "0x600089C")]
	private void SetScrollBar(int currentIndex)
	{
	}

	[Token(Token = "0x600089D")]
	[Address(RVA = "0x561300", Offset = "0x55FB00", Length = "0x6C")]
	public PnlQaSelect()
	{
	}
}
