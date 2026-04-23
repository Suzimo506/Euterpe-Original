using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Controls.BtnTipStateControl;

[Token(Token = "0x20001D4")]
public class PnlLevelConfigLevelRoleConfigKeyTipViewControl : BaseTipControl
{
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5BF60", Offset = "0x5B360")]
	[Token(Token = "0x4000B97")]
	[FieldOffset(Offset = "0x18")]
	private Image m_ImgBack;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C100", Offset = "0x5B500")]
	[Token(Token = "0x4000B98")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image m_ImgFront;

	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C440", Offset = "0x5B840")]
	[Token(Token = "0x4000B99")]
	[FieldOffset(Offset = "0x28")]
	private Color m_ImgBackColorOrigin;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C4C0", Offset = "0x5B8C0")]
	[Token(Token = "0x4000B9A")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Color m_ImgBackColor1;

	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C6B0", Offset = "0x5BAB0")]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000B9B")]
	private Color m_ImgFrontColorOrigin;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C4C0", Offset = "0x5B8C0")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4000B9C")]
	private Color m_ImgFrontColor1;

	[Token(Token = "0x6000D28")]
	[Address(RVA = "0x50D6C0", Offset = "0x50BEC0", Length = "0x14F")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000D29")]
	[Address(RVA = "0x50D610", Offset = "0x50BE10", Length = "0xA9")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x50D810", Offset = "0x50C010", Length = "0xA4")]
	[Token(Token = "0x6000D2A")]
	private void OnTglStateChanged(bool isTglOn)
	{
	}

	[Address(RVA = "0x50D8C0", Offset = "0x50C0C0", Length = "0xBB")]
	[Token(Token = "0x6000D2B")]
	protected override void SetTipState(Func<bool> invoke)
	{
	}

	[Token(Token = "0x6000D2C")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PnlLevelConfigLevelRoleConfigKeyTipViewControl()
	{
	}
}
