using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000178")]
public class AdvertiseMovement : RandomMovement
{
	[Token(Token = "0x4000954")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float m_MinSpeed;

	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000955")]
	[SerializeField]
	private float m_ChangeRate;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000956")]
	private List<Vector3> m_Directions;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000957")]
	private float m_Timer;

	[Address(RVA = "0x590E90", Offset = "0x58F690", Length = "0x104")]
	[Token(Token = "0x6000AD3")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000AD4")]
	[Address(RVA = "0x590FA0", Offset = "0x58F7A0", Length = "0x266")]
	protected virtual void OverEdgeCheck(float bound)
	{
	}

	[Token(Token = "0x6000AD5")]
	[Address(RVA = "0x590CF0", Offset = "0x58F4F0", Length = "0x19F")]
	protected override void Move()
	{
	}

	[Address(RVA = "0x591210", Offset = "0x58FA10", Length = "0x1DC")]
	[Token(Token = "0x6000AD6")]
	public AdvertiseMovement()
	{
	}
}
