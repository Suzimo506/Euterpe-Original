using System;
using Assets.Scripts.UI.Abstracts;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.PnlAccount;

[Token(Token = "0x200085C")]
public class PopupPnlCloudAsk : BasePopup<JToken, AccountCanvas.SaveDataEntity>
{
	[SerializeField]
	[Token(Token = "0x4002B86")]
	[FieldOffset(Offset = "0x130")]
	private PopupPnlCloudConfirm m_PopupPnlCloudConfirm;

	[SerializeField]
	[Token(Token = "0x4002B87")]
	[FieldOffset(Offset = "0x138")]
	private GameObject m_HighLevelCloudAsk;

	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4002B88")]
	[SerializeField]
	private GameObject m_HighLevelLocalAsk;

	[SerializeField]
	[Token(Token = "0x4002B89")]
	[FieldOffset(Offset = "0x148")]
	private Button m_BtnLocal;

	[Token(Token = "0x4002B8A")]
	[SerializeField]
	[FieldOffset(Offset = "0x150")]
	private Button m_BtnCloud;

	[SerializeField]
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4002B8B")]
	private Text m_TxtLevelCloud;

	[SerializeField]
	[Token(Token = "0x4002B8C")]
	[FieldOffset(Offset = "0x160")]
	private Text m_TxtExpCloud;

	[SerializeField]
	[Token(Token = "0x4002B8D")]
	[FieldOffset(Offset = "0x168")]
	private Text m_TxtDateCloud;

	[SerializeField]
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x4002B8E")]
	private Text m_TxtLastLoginPlatform;

	[SerializeField]
	[Token(Token = "0x4002B8F")]
	[FieldOffset(Offset = "0x178")]
	private Text m_TxtLevelLocal;

	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x4002B90")]
	[SerializeField]
	private Text m_TxtExpLocal;

	[FieldOffset(Offset = "0x188")]
	[SerializeField]
	[Token(Token = "0x4002B91")]
	private GameObject m_Taptap;

	[SerializeField]
	[Token(Token = "0x4002B92")]
	[FieldOffset(Offset = "0x190")]
	private GameObject m_IOS;

	[FieldOffset(Offset = "0x198")]
	[SerializeField]
	[Token(Token = "0x4002B93")]
	private GameObject m_GooglePlay;

	[FieldOffset(Offset = "0x1A0")]
	[SerializeField]
	[Token(Token = "0x4002B94")]
	private GameObject m_Steam;

	[SerializeField]
	[Token(Token = "0x4002B95")]
	[FieldOffset(Offset = "0x1A8")]
	private GameObject m_Unknown;

	[Token(Token = "0x4002B96")]
	[SerializeField]
	[FieldOffset(Offset = "0x1B0")]
	private GameObject m_WeGame;

	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4002B97")]
	private JToken m_saveDatas;

	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4002B98")]
	private AccountCanvas.SaveDataEntity m_saveDataEntity;

	[Address(RVA = "0x4CDF60", Offset = "0x4CC760", Length = "0x46")]
	[Token(Token = "0x6004C91")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6004C92")]
	[Address(RVA = "0x4CDF10", Offset = "0x4CC710", Length = "0x43")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x4CE0E0", Offset = "0x4CC8E0", Length = "0x400")]
	[Token(Token = "0x6004C93")]
	protected override void RendDatasToUI()
	{
	}

	[Address(RVA = "0x4CDFB0", Offset = "0x4CC7B0", Length = "0x124")]
	[Token(Token = "0x6004C94")]
	protected override void RegistClickEvts()
	{
	}

	[Token(Token = "0x6004C95")]
	[Address(RVA = "0x4CDE10", Offset = "0x4CC610", Length = "0x7D")]
	private void ClickOpenCloudConfirm(bool isLocalSave)
	{
	}

	[Address(RVA = "0x4CE4F0", Offset = "0x4CCCF0", Length = "0x128")]
	[Token(Token = "0x6004C96")]
	private void ShowCloudDateTime()
	{
	}

	[Address(RVA = "0x4CE620", Offset = "0x4CCE20", Length = "0xE6")]
	[Token(Token = "0x6004C97")]
	private void ShowCloudLoginPlatform()
	{
	}

	[Address(RVA = "0x4CDE00", Offset = "0x4CC600", Length = "0x9")]
	[Token(Token = "0x6004C98")]
	private int CacularLevel(int exp)
	{
		return default(int);
	}

	[Token(Token = "0x6004C99")]
	[Address(RVA = "0x4CDDF0", Offset = "0x4CC5F0", Length = "0x9")]
	private int CacularCurExp(int exp)
	{
		return default(int);
	}

	[Address(RVA = "0x4CDE90", Offset = "0x4CC690", Length = "0x72")]
	[Token(Token = "0x6004C9A")]
	private string FormatRemainTime(DateTime srcDateTime)
	{
		return null;
	}

	[Address(RVA = "0x4CE730", Offset = "0x4CCF30", Length = "0x38")]
	[Token(Token = "0x6004C9B")]
	public PopupPnlCloudAsk()
	{
		((BasePopup<, >)(object)this)._002Ector();
	}
}
