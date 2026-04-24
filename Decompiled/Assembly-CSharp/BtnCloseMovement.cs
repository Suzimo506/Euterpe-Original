using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000179")]
public class BtnCloseMovement : RandomMovement
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000958")]
	[SerializeField]
	private float m_Smoothness;

	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Token(Token = "0x4000959")]
	private float m_ChangeTime;

	[Token(Token = "0x400095A")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 m_OriginalPosition;

	[Token(Token = "0x400095B")]
	[FieldOffset(Offset = "0x64")]
	private bool m_IsActive;

	[Token(Token = "0x400095C")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 m_TargetPosition;

	[Token(Token = "0x400095D")]
	[FieldOffset(Offset = "0x74")]
	private float m_ChangeTimer;

	[Token(Token = "0x400095E")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 m_Velocity;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400095F")]
	private Transform m_OriginalParent;

	[Token(Token = "0x6000AD7")]
	[Address(RVA = "0x460960", Offset = "0x45F160", Length = "0x69")]
	private void Start()
	{
	}

	[Token(Token = "0x6000AD8")]
	[Address(RVA = "0x460630", Offset = "0x45EE30", Length = "0xCB")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000AD9")]
	[Address(RVA = "0x460700", Offset = "0x45EF00", Length = "0x103")]
	public void SetActive(bool active)
	{
	}

	[Token(Token = "0x6000ADA")]
	[Address(RVA = "0x460810", Offset = "0x45F010", Length = "0x14E")]
	private void SetRandomDirection()
	{
	}

	[Address(RVA = "0x4602C0", Offset = "0x45EAC0", Length = "0x36D")]
	[Token(Token = "0x6000ADB")]
	protected override void Move()
	{
	}

	[Address(RVA = "0x4609D0", Offset = "0x45F1D0", Length = "0x15")]
	[Token(Token = "0x6000ADC")]
	public BtnCloseMovement()
	{
	}
}
