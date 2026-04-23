using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq;
using PeroTools2.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000095")]
public class AgreementCanvas : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x400042B")]
	[FieldOffset(Offset = "0x18")]
	private GameObject m_AccountCanvas;

	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400042C")]
	private GameObject m_MainManager;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400042D")]
	private JObject m_JObjAgreement;

	[Token(Token = "0x400042E")]
	[FieldOffset(Offset = "0x30")]
	private AccountCanvas.MDAccountProtocolData m_AccountData;

	[FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x88590", Offset = "0x87990")]
	[SerializeField]
	[Token(Token = "0x400042F")]
	private Popup m_PopupPnlChange;

	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000430")]
	private ClickableText m_CTxtChange;

	[SerializeField]
	[Token(Token = "0x4000431")]
	[FieldOffset(Offset = "0x58")]
	private Button m_BtnChangeAgree1;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000432")]
	[SerializeField]
	private Button m_BtnChangeDisagree1;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000433")]
	[SerializeField]
	private Popup m_PopupPnlChangeAgreeAgain;

	[SerializeField]
	[Token(Token = "0x4000434")]
	[FieldOffset(Offset = "0x70")]
	private ClickableText m_CTxtChangeAgreeAgain;

	[SerializeField]
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000435")]
	private Button m_BtnChangeAgree2;

	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x4000436")]
	private Button m_BtnChangeDisagree2;

	[Token(Token = "0x4000437")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7F2B0", Offset = "0x7E6B0")]
	[FieldOffset(Offset = "0x88")]
	private Popup m_PopupPnlUserAgreement;

	[Token(Token = "0x4000438")]
	[SerializeField]
	[FieldOffset(Offset = "0x90")]
	private TextMeshProUGUI m_TxtUserAgreement;

	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7F660", Offset = "0x7EA60")]
	[SerializeField]
	[Token(Token = "0x4000439")]
	[FieldOffset(Offset = "0x98")]
	private Popup m_PopupPnlPrivacyAgreement;

	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400043A")]
	[SerializeField]
	private TextMeshProUGUI m_TxtPrivacyAgreement;

	[Address(RVA = "0x5919F0", Offset = "0x5901F0", Length = "0x59")]
	[Token(Token = "0x60004AC")]
	private void Start()
	{
	}

	[Address(RVA = "0x591590", Offset = "0x58FD90", Length = "0x9D")]
	[Token(Token = "0x60004AD")]
	private void InitAccountData()
	{
	}

	[Address(RVA = "0x591630", Offset = "0x58FE30", Length = "0x3B9")]
	[Token(Token = "0x60004AE")]
	private void InitPnlChange()
	{
	}

	[Address(RVA = "0x5913F0", Offset = "0x58FBF0", Length = "0x196")]
	[Token(Token = "0x60004AF")]
	private void GetUserPrivacyAgreementInfo()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x60004B0")]
	private void SaveAccountData()
	{
	}

	[Address(RVA = "0x591F30", Offset = "0x590730", Length = "0x28C")]
	[Token(Token = "0x60004B1")]
	private void UpdateAgreementText()
	{
	}

	[Token(Token = "0x60004B2")]
	[Address(RVA = "0x591B70", Offset = "0x590370", Length = "0x14B")]
	private void SendToBackendUrl(string url, string method = "GET", Action<JObject> succeedCallback = null)
	{
	}

	[Token(Token = "0x60004B3")]
	[Address(RVA = "0x591AD0", Offset = "0x5902D0", Length = "0x9C")]
	private void OpenAgreementText(string key)
	{
	}

	[Token(Token = "0x60004B4")]
	[Address(RVA = "0x5919F0", Offset = "0x5901F0", Length = "0x59")]
	private void OnAcceptAgreement()
	{
	}

	[Token(Token = "0x60004B5")]
	[Address(RVA = "0x591A50", Offset = "0x590250", Length = "0x7E")]
	private void OnBtnAcceptAgreementClick()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x60004B6")]
	public AgreementCanvas()
	{
	}
}
