using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000181")]
public class IAPTypeQAButton : QAButton
{
	[SerializeField]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400097A")]
	private bool m_IsAnswerChangedByIAP;

	[Token(Token = "0x400097B")]
	[SerializeField]
	[FieldOffset(Offset = "0xA0")]
	private RectTransform m_JAPAnswer;

	[Token(Token = "0x400097C")]
	[SerializeField]
	[FieldOffset(Offset = "0xA8")]
	private RectTransform m_MPAnswer;

	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400097D")]
	[SerializeField]
	private bool m_IsTitleChangedByIAP;

	[SerializeField]
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400097E")]
	private Button m_BtnJAPTitle;

	[SerializeField]
	[Token(Token = "0x400097F")]
	[FieldOffset(Offset = "0xC0")]
	private Button m_BtnMPTitle;

	[Address(RVA = "0x5C5D40", Offset = "0x5C4540", Length = "0x14F")]
	[Token(Token = "0x6000AFF")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000B00")]
	[Address(RVA = "0x5C5F20", Offset = "0x5C4720", Length = "0xCB")]
	private void ChangeContentByIAPType()
	{
	}

	[Token(Token = "0x6000B01")]
	[Address(RVA = "0x9CE3D0", Offset = "0x9CCBD0", Length = "0x7A")]
	private void ChangeContentByIAPType<T>(ref T mainContent, T JAPContent, T MPContent, bool hasBuyJAP) where T : Component
	{
	}

	[Token(Token = "0x6000B02")]
	[Address(RVA = "0x5C5E90", Offset = "0x5C4690", Length = "0x8F")]
	private void ChangeActiveObject(GameObject preObj, GameObject curObj)
	{
	}

	[Token(Token = "0x6000B03")]
	[Address(RVA = "0x5C5FF0", Offset = "0x5C47F0", Length = "0x9C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000B04")]
	[Address(RVA = "0x5C6090", Offset = "0x5C4890", Length = "0x7")]
	public IAPTypeQAButton()
	{
	}
}
