using System;
using Assets.Scripts.UI.Abstracts;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.PnlAccount;

[Token(Token = "0x200085D")]
public class PopupPnlCloudConfirm : BasePopup<bool, AccountCanvas.SaveDataEntity>
{
	[SerializeField]
	[Token(Token = "0x4002B99")]
	[FieldOffset(Offset = "0x130")]
	private GameObject m_TxtLocal;

	[SerializeField]
	[Token(Token = "0x4002B9A")]
	[FieldOffset(Offset = "0x138")]
	private GameObject m_TxtCloud;

	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	[Token(Token = "0x4002B9B")]
	private GameObject m_HighTips;

	[SerializeField]
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4002B9C")]
	private GameObject m_LowTips;

	[SerializeField]
	[Token(Token = "0x4002B9D")]
	[FieldOffset(Offset = "0x150")]
	private GameObject m_HighLevelCloud;

	[Token(Token = "0x4002B9E")]
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	private GameObject m_LowLevelCloud;

	[Token(Token = "0x4002B9F")]
	[SerializeField]
	[FieldOffset(Offset = "0x160")]
	private GameObject m_HighLevelLocal;

	[SerializeField]
	[Token(Token = "0x4002BA0")]
	[FieldOffset(Offset = "0x168")]
	private GameObject m_LowLevelLocal;

	[FieldOffset(Offset = "0x170")]
	[SerializeField]
	[Token(Token = "0x4002BA1")]
	private GameObject m_HighYes;

	[SerializeField]
	[Token(Token = "0x4002BA2")]
	[FieldOffset(Offset = "0x178")]
	private GameObject m_LowYes;

	[SerializeField]
	[Token(Token = "0x4002BA3")]
	[FieldOffset(Offset = "0x180")]
	private GameObject m_HighNo;

	[SerializeField]
	[Token(Token = "0x4002BA4")]
	[FieldOffset(Offset = "0x188")]
	private GameObject m_LowNo;

	[SerializeField]
	[Token(Token = "0x4002BA5")]
	[FieldOffset(Offset = "0x190")]
	private Button m_BtnYes;

	[SerializeField]
	[Token(Token = "0x4002BA6")]
	[FieldOffset(Offset = "0x198")]
	private Text m_TxtConfirmLevelCloud;

	[Token(Token = "0x4002BA7")]
	[FieldOffset(Offset = "0x1A0")]
	[SerializeField]
	private Text m_TxtConfirmExpCloud;

	[SerializeField]
	[Token(Token = "0x4002BA8")]
	[FieldOffset(Offset = "0x1A8")]
	private Text m_TxtConfirmDateCloud;

	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4002BA9")]
	[SerializeField]
	private Text m_TxtConfirmLevelLocal;

	[SerializeField]
	[Token(Token = "0x4002BAA")]
	[FieldOffset(Offset = "0x1B8")]
	private Text m_TxtConfirmExpLocal;

	[Token(Token = "0x4002BAB")]
	[FieldOffset(Offset = "0x1C0")]
	private bool m_isLocalSave;

	[Token(Token = "0x4002BAC")]
	[FieldOffset(Offset = "0x1C8")]
	private AccountCanvas.SaveDataEntity m_saveDataEntity;

	[Token(Token = "0x6004C9E")]
	[Address(RVA = "0x4CE910", Offset = "0x4CD110", Length = "0x46")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6004C9F")]
	[Address(RVA = "0x4CE8C0", Offset = "0x4CD0C0", Length = "0x43")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6004CA0")]
	[Address(RVA = "0x4CE960", Offset = "0x4CD160", Length = "0xAB")]
	protected override void RegistClickEvts()
	{
	}

	[Token(Token = "0x6004CA1")]
	[Address(RVA = "0x4CEA10", Offset = "0x4CD210", Length = "0x1FB")]
	protected override void RendDatasToUI()
	{
	}

	[Token(Token = "0x6004CA2")]
	[Address(RVA = "0x4CE770", Offset = "0x4CCF70", Length = "0xC0")]
	private void ActiveState(bool high)
	{
	}

	[Token(Token = "0x6004CA3")]
	[Address(RVA = "0x4CDE00", Offset = "0x4CC600", Length = "0x9")]
	private int CacularLevel(int exp)
	{
		return default(int);
	}

	[Token(Token = "0x6004CA4")]
	[Address(RVA = "0x4CDDF0", Offset = "0x4CC5F0", Length = "0x9")]
	private int CacularCurExp(int exp)
	{
		return default(int);
	}

	[Token(Token = "0x6004CA5")]
	[Address(RVA = "0x4CE840", Offset = "0x4CD040", Length = "0x72")]
	private string FormatRemainTime(DateTime srcDateTime)
	{
		return null;
	}

	[Token(Token = "0x6004CA6")]
	[Address(RVA = "0x4CECE0", Offset = "0x4CD4E0", Length = "0x3F")]
	public PopupPnlCloudConfirm()
	{
		((BasePopup<, >)(object)this)._002Ector();
	}
}
