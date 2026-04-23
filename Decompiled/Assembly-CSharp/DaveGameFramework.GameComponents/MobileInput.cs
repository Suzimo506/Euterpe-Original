using Cpp2ILInjected;
using UnityEngine;

namespace DaveGameFramework.GameComponents;

[Token(Token = "0x20004CB")]
public class MobileInput : BaseInputComponent
{
	[Token(Token = "0x4001A1E")]
	[FieldOffset(Offset = "0x18")]
	private bool m_IsTouchLeftRight;

	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x4001A1F")]
	private bool m_IsTouchReverseToUpDown;

	[Token(Token = "0x4001A20")]
	[FieldOffset(Offset = "0x1C")]
	private Rect m_TouchDisabledRect;

	[Token(Token = "0x4001A21")]
	[FieldOffset(Offset = "0x2C")]
	private float m_ScrWidthMid;

	[Token(Token = "0x4001A22")]
	[FieldOffset(Offset = "0x30")]
	private float m_ScrHeightMid;

	[Token(Token = "0x60035BB")]
	[Address(RVA = "0x9A01B0", Offset = "0x99E9B0", Length = "0x2C6")]
	public override void AwakeInit()
	{
	}

	[Token(Token = "0x60035BC")]
	[Address(RVA = "0x9A0800", Offset = "0x99F000", Length = "0x104")]
	public override void Reset()
	{
	}

	[Token(Token = "0x60035BD")]
	[Address(RVA = "0x9A04B0", Offset = "0x99ECB0", Length = "0x34C")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x60035BE")]
	[Address(RVA = "0x9A0910", Offset = "0x99F110", Length = "0x1BD")]
	private void TouchHandler(Touch touchInfo, int index)
	{
	}

	[Token(Token = "0x60035BF")]
	[Address(RVA = "0x9A0480", Offset = "0x99EC80", Length = "0x23")]
	private bool IsTouchAir(float touchPositionSingle)
	{
		return default(bool);
	}

	[Token(Token = "0x60035C0")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public MobileInput()
	{
	}
}
