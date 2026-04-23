using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200017D")]
public class FoolishAdvertiseLevelController : FoolishAdvertiseController
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400096E")]
	[SerializeField]
	private BtnCloseMovement m_BtnCloseMovement;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400096F")]
	private int m_CloseClickCount;

	[Address(RVA = "0x44F290", Offset = "0x44DA90", Length = "0x54")]
	[Token(Token = "0x6000AED")]
	protected override void OnBtnJumpClicked()
	{
	}

	[Address(RVA = "0x44F220", Offset = "0x44DA20", Length = "0x63")]
	[Token(Token = "0x6000AEE")]
	protected override void Close()
	{
	}

	[Address(RVA = "0x44F2F0", Offset = "0x44DAF0", Length = "0x8")]
	[Token(Token = "0x6000AEF")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000AF0")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public FoolishAdvertiseLevelController()
	{
	}
}
