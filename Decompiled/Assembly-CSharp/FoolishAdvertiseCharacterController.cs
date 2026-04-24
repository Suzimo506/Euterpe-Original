using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200017A")]
public class FoolishAdvertiseCharacterController : FoolishAdvertiseController
{
	[Token(Token = "0x4000960")]
	[SerializeField]
	[FieldOffset(Offset = "0x40")]
	private float m_BtnCloseHideTime;

	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000961")]
	private int m_CharacterIndexInPnl;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000962")]
	private float m_ShowTimer;

	[Address(RVA = "0x44EC10", Offset = "0x44D410", Length = "0x78")]
	[Token(Token = "0x6000ADD")]
	private void Start()
	{
	}

	[Token(Token = "0x6000ADE")]
	[Address(RVA = "0x44E9C0", Offset = "0x44D1C0", Length = "0x7E")]
	private void Update()
	{
	}

	[Token(Token = "0x6000ADF")]
	[Address(RVA = "0x44E9C0", Offset = "0x44D1C0", Length = "0x7E")]
	private void BtnCloseHideCountDown()
	{
	}

	[Address(RVA = "0x44EBD0", Offset = "0x44D3D0", Length = "0x36")]
	[Token(Token = "0x6000AE0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000AE1")]
	[Address(RVA = "0x44EA40", Offset = "0x44D240", Length = "0x18B")]
	protected override void OnBtnJumpClicked()
	{
	}

	[Address(RVA = "0x44EC90", Offset = "0x44D490", Length = "0xE")]
	[Token(Token = "0x6000AE2")]
	public FoolishAdvertiseCharacterController()
	{
	}
}
