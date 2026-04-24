using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.PeroTools.Nice.Actions;
using Assets.Scripts.UI.Panels;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200018E")]
public class PnlIllusCheck : BaseMessageBox
{
	[Token(Token = "0x40009B3")]
	[FieldOffset(Offset = "0xF0")]
	public Image simpleLoading;

	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x40009B4")]
	public Image specialLoading;

	[Token(Token = "0x40009B5")]
	[FieldOffset(Offset = "0x100")]
	public Image verySpecialLoading;

	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40009B6")]
	public Image squareLoading;

	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x40009B7")]
	public Transform m_LoadingCheck;

	[Token(Token = "0x40009B8")]
	[FieldOffset(Offset = "0x118")]
	public CheckWelcome m_CheckWelcome;

	[Token(Token = "0x40009B9")]
	[FieldOffset(Offset = "0x120")]
	public Toggle tglUsed;

	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x40009BA")]
	public Image imgOff;

	[Token(Token = "0x40009BB")]
	[FieldOffset(Offset = "0x130")]
	private SaveImage m_SaveImage;

	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x40009BC")]
	private PnlTroves m_PnlTroves;

	[Token(Token = "0x40009BD")]
	[SerializeField]
	[FieldOffset(Offset = "0x140")]
	private Button m_BtnDownload;

	[SerializeField]
	[Token(Token = "0x40009BE")]
	[FieldOffset(Offset = "0x148")]
	private Button m_LeftButton;

	[Token(Token = "0x40009BF")]
	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	private Button m_RightButton;

	[Token(Token = "0x40009C0")]
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	private List<Popup.PopUpAniParameter> m_PopupAniSchemes;

	[SerializeField]
	[Token(Token = "0x40009C1")]
	[FieldOffset(Offset = "0x160")]
	private List<AutoFadeBtn> m_AutoFadeBtns;

	[Token(Token = "0x40009C2")]
	[FieldOffset(Offset = "0x168")]
	private string m_CurItemType;

	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x40009C3")]
	private int m_EnterSelectedIndex;

	[Address(RVA = "0x79FEC0", Offset = "0x79E6C0", Length = "0x251")]
	[Token(Token = "0x6000B39")]
	public override void AwakeInit()
	{
	}

	[Token(Token = "0x6000B3A")]
	[Address(RVA = "0x7A05F0", Offset = "0x79EDF0", Length = "0xB6")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x7A03B0", Offset = "0x79EBB0", Length = "0x235")]
	[Token(Token = "0x6000B3B")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x7A0120", Offset = "0x79E920", Length = "0xA5")]
	[Token(Token = "0x6000B3C")]
	private void HideAutoHideBtns()
	{
	}

	[Address(RVA = "0x7A1370", Offset = "0x79FB70", Length = "0x65")]
	[Token(Token = "0x6000B3D")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x3EB00", Offset = "0x3DF00")]
	private IEnumerator StartUpAllAutoHideBtnsCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000B3E")]
	[Address(RVA = "0x7A0300", Offset = "0x79EB00", Length = "0xA5")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000B3F")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	private void AdaptiveMobile()
	{
	}

	[Address(RVA = "0x7A0260", Offset = "0x79EA60", Length = "0x45")]
	[Token(Token = "0x6000B40")]
	private void OnBtnLeftClick()
	{
	}

	[Address(RVA = "0x7A02B0", Offset = "0x79EAB0", Length = "0x45")]
	[Token(Token = "0x6000B41")]
	private void OnBtnRightClick()
	{
	}

	[Address(RVA = "0x7A06B0", Offset = "0x79EEB0", Length = "0xB0")]
	[Token(Token = "0x6000B42")]
	private void OnTglValueChanged(bool value)
	{
	}

	[Token(Token = "0x6000B43")]
	[Address(RVA = "0x7A01D0", Offset = "0x79E9D0", Length = "0x85")]
	private void OnBtnDownloadClick()
	{
	}

	[Token(Token = "0x6000B44")]
	[Address(RVA = "0x7A09B0", Offset = "0x79F1B0", Length = "0x271")]
	private void Reset((int, string) selectItemData)
	{
	}

	[Token(Token = "0x6000B45")]
	[Address(RVA = "0x7A0FE0", Offset = "0x79F7E0", Length = "0x380")]
	public void Show(string itemType, Transform parent)
	{
	}

	[Address(RVA = "0x7A0820", Offset = "0x79F020", Length = "0x18B")]
	[Token(Token = "0x6000B46")]
	public void RefreshPopupScheme(string itemType)
	{
	}

	[Token(Token = "0x6000B47")]
	[Address(RVA = "0x7A0F70", Offset = "0x79F770", Length = "0x6C")]
	public void ShowLoading()
	{
	}

	[Token(Token = "0x6000B48")]
	[Address(RVA = "0x7A0C30", Offset = "0x79F430", Length = "0x337")]
	private void ShowAssignLoading(int itemIndex)
	{
	}

	[Token(Token = "0x6000B49")]
	[Address(RVA = "0x7A0770", Offset = "0x79EF70", Length = "0xAF")]
	private void RefreshButtonScaler()
	{
	}

	[Token(Token = "0x6000B4A")]
	[Address(RVA = "0x7A13E0", Offset = "0x79FBE0", Length = "0x6C")]
	public PnlIllusCheck()
	{
	}
}
