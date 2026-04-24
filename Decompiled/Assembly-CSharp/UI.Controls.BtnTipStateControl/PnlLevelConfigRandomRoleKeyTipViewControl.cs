using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Controls.BtnTipStateControl;

[Token(Token = "0x20001D5")]
public class PnlLevelConfigRandomRoleKeyTipViewControl : BaseTipControl
{
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5BF60", Offset = "0x5B360")]
	[Token(Token = "0x4000B9D")]
	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	private Image m_ImgBack;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B9E")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C100", Offset = "0x5B500")]
	private Image m_ImgFront;

	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C440", Offset = "0x5B840")]
	[Token(Token = "0x4000B9F")]
	[FieldOffset(Offset = "0x28")]
	private Color m_ImgBackColorOrigin;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C4C0", Offset = "0x5B8C0")]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000BA0")]
	[SerializeField]
	private Color m_ImgBackColor1;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6B0", Offset = "0x5BAB0")]
	[SerializeField]
	[Token(Token = "0x4000BA1")]
	[FieldOffset(Offset = "0x48")]
	private Color m_ImgFrontColorOrigin;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C4C0", Offset = "0x5B8C0")]
	[SerializeField]
	[Token(Token = "0x4000BA2")]
	[FieldOffset(Offset = "0x58")]
	private Color m_ImgFrontColor1;

	[Token(Token = "0x6000D2D")]
	[Address(RVA = "0x50DA30", Offset = "0x50C230", Length = "0x14F")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000D2E")]
	[Address(RVA = "0x50D980", Offset = "0x50C180", Length = "0xA9")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000D2F")]
	[Address(RVA = "0x50DB80", Offset = "0x50C380", Length = "0xA4")]
	private void OnTglStateChanged(bool isTglOn)
	{
	}

	[Token(Token = "0x6000D30")]
	[Address(RVA = "0x50DC30", Offset = "0x50C430", Length = "0xBB")]
	protected override void SetTipState(Func<bool> invoke)
	{
	}

	[Token(Token = "0x6000D31")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PnlLevelConfigRandomRoleKeyTipViewControl()
	{
	}
}
