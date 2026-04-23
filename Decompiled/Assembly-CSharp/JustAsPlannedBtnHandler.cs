using Assets.Scripts.UI.Panels.PnlDLC;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200010B")]
public class JustAsPlannedBtnHandler : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4000693")]
	[FieldOffset(Offset = "0x18")]
	private Button m_BtnJustAsPlanned;

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000694")]
	private Button m_BtnQuestion;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000695")]
	private PnlDlcBtnPurchase m_Parent;

	[SerializeField]
	[Token(Token = "0x4000696")]
	[FieldOffset(Offset = "0x30")]
	private float tipsWidthValue;

	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000697")]
	private int m_CurrentSelectedJsonIndex;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000698")]
	private string m_CurrentSelectedJsonUid;

	[Token(Token = "0x60007C8")]
	[Address(RVA = "0x5D26B0", Offset = "0x5D0EB0", Length = "0xD4")]
	private void Start()
	{
	}

	[Token(Token = "0x60007C9")]
	[Address(RVA = "0x5D2120", Offset = "0x5D0920", Length = "0xAE")]
	public void Init(PnlDlcBtnPurchase parent)
	{
	}

	[Token(Token = "0x60007CA")]
	[Address(RVA = "0x5D2790", Offset = "0x5D0F90", Length = "0xA1")]
	private void TipsWidth()
	{
	}

	[Token(Token = "0x60007CB")]
	[Address(RVA = "0x5D2660", Offset = "0x5D0E60", Length = "0x48")]
	private void PlayClickSfx()
	{
	}

	[Token(Token = "0x60007CC")]
	[Address(RVA = "0x5D24C0", Offset = "0x5D0CC0", Length = "0x198")]
	private void OnQuestionBtnClicked()
	{
	}

	[Token(Token = "0x60007CD")]
	[Address(RVA = "0x5D21D0", Offset = "0x5D09D0", Length = "0x2EF")]
	private void OnJustAsPlannedBtnClicked()
	{
	}

	[Address(RVA = "0x5D2010", Offset = "0x5D0810", Length = "0x100")]
	[Token(Token = "0x60007CE")]
	public void CheckQuestionHide(int albumJson, string uid)
	{
	}

	[Address(RVA = "0x5D2840", Offset = "0x5D1040", Length = "0xE")]
	[Token(Token = "0x60007CF")]
	public JustAsPlannedBtnHandler()
	{
	}
}
