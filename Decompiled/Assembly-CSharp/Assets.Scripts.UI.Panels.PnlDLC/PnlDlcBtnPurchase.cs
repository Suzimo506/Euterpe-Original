using Assets.Scripts.PeroTools.Nice.Components;
using Assets.Scripts.PeroTools.UI;
using Assets.Scripts.Purchase;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x200093A")]
public class PnlDlcBtnPurchase : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x40031D6")]
	[FieldOffset(Offset = "0x18")]
	private BtnIAP m_BtnIapPurchase;

	[Token(Token = "0x40031D7")]
	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	private BtnIAP m_BtnIapRestore;

	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40031D8")]
	private JustAsPlannedBtnHandler m_JustAsPlannedBtnHandler;

	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40031D9")]
	private JustAsPlannedBtnHandler m_JustAsPlannedArkKnight2BtnHandle;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40031DA")]
	[SerializeField]
	private JustAsPlannedBtnHandler m_JustAsPlannedFoolDayHandle;

	[Token(Token = "0x40031DB")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Attribute(Name = "HeaderAttribute", RVA = "0x91A30", Offset = "0x90E30")]
	private PriceTxtDisplay[] m_PriceTxtDisplays;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40031DC")]
	private PriceTxtDisplay m_CurrentDisplay;

	[Token(Token = "0x40031DD")]
	[FieldOffset(Offset = "0x50")]
	private int m_SelectedIndex;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40031DE")]
	private PnlDlc m_Parent;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40031DF")]
	private bool canDoArknightAni;

	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40031E0")]
	private int m_LastSelectIndex;

	[SerializeField]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40031E1")]
	private Text m_TxtIncTax;

	[Token(Token = "0x170008D3")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView fsv
	{
		[Address(RVA = "0x824120", Offset = "0x822920", Length = "0x1B")]
		[Token(Token = "0x60053B8")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x821270", Offset = "0x81FA70", Length = "0x1AB")]
	[Token(Token = "0x60053B9")]
	private void Awake()
	{
	}

	[Token(Token = "0x60053BA")]
	[Address(RVA = "0x821AE0", Offset = "0x8202E0", Length = "0x317")]
	public void Init(PnlDlc parent)
	{
	}

	[Address(RVA = "0x823C30", Offset = "0x822430", Length = "0x2C8")]
	[Token(Token = "0x60053BB")]
	public void Release()
	{
	}

	[Address(RVA = "0x821E60", Offset = "0x820660", Length = "0x2DF")]
	[Token(Token = "0x60053BC")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x822150", Offset = "0x820950", Length = "0x84")]
	[Token(Token = "0x60053BD")]
	private void OnGetProductsCompleted(bool isSuccess)
	{
	}

	[Token(Token = "0x60053BE")]
	[Address(RVA = "0x823F00", Offset = "0x822700", Length = "0x1B3")]
	private void ShowPnlDlcFailMessage()
	{
	}

	[Token(Token = "0x60053BF")]
	[Address(RVA = "0x8221E0", Offset = "0x8209E0", Length = "0x39F")]
	private void OnPurchaseClicked()
	{
	}

	[Token(Token = "0x60053C0")]
	[Address(RVA = "0x822580", Offset = "0x820D80", Length = "0xA8")]
	private void OnRestoreClicked()
	{
	}

	[Address(RVA = "0x822A70", Offset = "0x821270", Length = "0xD1")]
	[Token(Token = "0x60053C1")]
	private void OnTransactionCompleted(TransactionResult result)
	{
	}

	[Token(Token = "0x60053C2")]
	[Address(RVA = "0x822140", Offset = "0x820940", Length = "0xE")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60053C3")]
	[Address(RVA = "0x821420", Offset = "0x81FC20", Length = "0xAA")]
	private void CleanPrev(PriceTxtDisplay prev)
	{
	}

	[Token(Token = "0x60053C4")]
	[Address(RVA = "0x8214D0", Offset = "0x81FCD0", Length = "0x192")]
	private void Clean()
	{
	}

	[Address(RVA = "0x821670", Offset = "0x81FE70", Length = "0x2B8")]
	[Token(Token = "0x60053C5")]
	private PriceTxtDisplay GetPriceTxtDisplayByJsonIndex(int jsonIndex)
	{
		return null;
	}

	[Address(RVA = "0x822A60", Offset = "0x821260", Length = "0xA")]
	[Token(Token = "0x60053C6")]
	private void OnSelected(int index)
	{
	}

	[Address(RVA = "0x822B50", Offset = "0x821350", Length = "0x431")]
	[Token(Token = "0x60053C7")]
	private void PlaySwitch(PriceTxtDisplay prev, PriceTxtDisplay current)
	{
	}

	[Address(RVA = "0x6572A0", Offset = "0x655AA0", Length = "0x5")]
	[Token(Token = "0x60053C8")]
	private void SetCanDoArknight()
	{
	}

	[Token(Token = "0x60053C9")]
	[Address(RVA = "0x822FE0", Offset = "0x8217E0", Length = "0xC4F")]
	private void Refresh()
	{
	}

	[Address(RVA = "0x822F90", Offset = "0x821790", Length = "0x4F")]
	[Token(Token = "0x60053CA")]
	private void Refresh_Mobile()
	{
	}

	[Token(Token = "0x60053CB")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	private void Refresh_PC()
	{
	}

	[Token(Token = "0x60053CC")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	private void Refresh_NS()
	{
	}

	[Token(Token = "0x60053CD")]
	[Address(RVA = "0x821930", Offset = "0x820130", Length = "0x1A6")]
	private void GetServerTimeToRefreshPriceInfo(Product product)
	{
	}

	[Token(Token = "0x60053CE")]
	[Address(RVA = "0x821E00", Offset = "0x820600", Length = "0x60")]
	private void OnCoundownCompleted()
	{
	}

	[Token(Token = "0x60053CF")]
	[Address(RVA = "0x822630", Offset = "0x820E30", Length = "0x423")]
	private void OnRestoreCompleted(bool isOK, TransactionResult result)
	{
	}

	[Address(RVA = "0x824110", Offset = "0x822910", Length = "0xE")]
	[Token(Token = "0x60053D0")]
	public PnlDlcBtnPurchase()
	{
	}
}
