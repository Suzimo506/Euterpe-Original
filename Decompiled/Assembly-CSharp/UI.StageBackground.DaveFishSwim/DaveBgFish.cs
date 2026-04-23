using Assets.Scripts.UI.StageBackground.DaveFishSwim;
using Cpp2ILInjected;
using Spine.Unity;
using UnityEngine;

namespace UI.StageBackground.DaveFishSwim;

[Token(Token = "0x20001B6")]
public class DaveBgFish : DaveBgActiveObjs
{
	[Token(Token = "0x4000A9A")]
	[SerializeField]
	[FieldOffset(Offset = "0x28")]
	private SwimTrail trail;

	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000A9B")]
	[SerializeField]
	private Vector2 m_SwimVelocityRange;

	[SerializeField]
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000A9C")]
	private Vector2 m_RotateVelocityRange;

	[SerializeField]
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000A9D")]
	private Vector2 m_RotateRange;

	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000A9E")]
	private Quaternion m_TargetRotation;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000A9F")]
	private SkeletonAnimation[] m_SkeletonAnimations;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000AA0")]
	private Vector3 m_HidePosition;

	[Token(Token = "0x4000AA1")]
	[FieldOffset(Offset = "0x6C")]
	private float m_SwimSpeedValue;

	[Token(Token = "0x4000AA2")]
	[FieldOffset(Offset = "0x70")]
	private float m_RotateSpeedValue;

	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000AA3")]
	private SwimDirection m_SwimDirection;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000AA4")]
	private bool m_IsFromLeft;

	[FieldOffset(Offset = "0x79")]
	[Token(Token = "0x4000AA5")]
	private bool m_IsActive;

	[Token(Token = "0x170000E7")]
	public SwimTrail SwimTrail
	{
		[Address(RVA = "0x49EAA0", Offset = "0x49D2A0", Length = "0x4")]
		[Token(Token = "0x6000C2A")]
		get
		{
			return default(SwimTrail);
		}
	}

	[Address(RVA = "0x4D5720", Offset = "0x4D3F20", Length = "0x92")]
	[Token(Token = "0x6000C2B")]
	public override void OnInitialize()
	{
	}

	[Address(RVA = "0x4D61F0", Offset = "0x4D49F0", Length = "0x90")]
	[Token(Token = "0x6000C2C")]
	public override string ToString()
	{
		return null;
	}

	[Address(RVA = "0x4D57C0", Offset = "0x4D3FC0", Length = "0x294")]
	[Token(Token = "0x6000C2D")]
	private void SetAnimation()
	{
	}

	[Address(RVA = "0x4D5A60", Offset = "0x4D4260", Length = "0x3BE")]
	[Token(Token = "0x6000C2E")]
	private void SetCreatePosition()
	{
	}

	[Address(RVA = "0x4D5E20", Offset = "0x4D4620", Length = "0x3C1")]
	[Token(Token = "0x6000C2F")]
	private void SetRotations(Vector3 createPos)
	{
	}

	[Token(Token = "0x6000C30")]
	[Address(RVA = "0x4D5100", Offset = "0x4D3900", Length = "0x4C5")]
	private void FixedUpdate()
	{
	}

	[Address(RVA = "0x4D55D0", Offset = "0x4D3DD0", Length = "0x140")]
	[Token(Token = "0x6000C31")]
	private void JudgeIsArriveEdge()
	{
	}

	[Address(RVA = "0x4D6290", Offset = "0x4D4A90", Length = "0x9C")]
	[Token(Token = "0x6000C32")]
	public DaveBgFish()
	{
	}
}
