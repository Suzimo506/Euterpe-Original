using Cpp2ILInjected;
using UnityEngine;

namespace GameCore.Scene.Controllers;

[Token(Token = "0x2000467")]
[Attribute(Name = "RequireComponent", RVA = "0x3BDF0", Offset = "0x3B1F0")]
public class Scrollable : MonoBehaviour, IMixOffset
{
	[Attribute(Name = "MinAttribute", RVA = "0x3BE70", Offset = "0x3B270")]
	[Token(Token = "0x4001801")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float m_ScrollLength;

	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001802")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x18E30", Offset = "0x18230")]
	private float m_Anchor;

	[Attribute(Name = "RangeAttribute", RVA = "0x3C050", Offset = "0x3B450")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4001803")]
	private float m_Angle;

	[Token(Token = "0x4001804")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public float m_SpeedFactor;

	[SerializeField]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001805")]
	private bool m_IsGroup;

	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4001806")]
	private Vector2 m_DirectionCache;

	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4001807")]
	private float m_Progress;

	[Token(Token = "0x1700048E")]
	public float scrollProgress
	{
		[Address(RVA = "0x90CF00", Offset = "0x90B700", Length = "0x6")]
		[Token(Token = "0x60032F8")]
		get
		{
			return default(float);
		}
		[Address(RVA = "0x90D940", Offset = "0x90C140", Length = "0x97")]
		[Token(Token = "0x60032F9")]
		set
		{
		}
	}

	[Token(Token = "0x60032FA")]
	[Address(RVA = "0x90D380", Offset = "0x90BB80", Length = "0x47C")]
	private void Start()
	{
	}

	[Token(Token = "0x60032FB")]
	[Address(RVA = "0x90D120", Offset = "0x90B920", Length = "0x136")]
	public Vector3 GetOffsetUpdate()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60032FC")]
	[Address(RVA = "0x90D260", Offset = "0x90BA60", Length = "0x116")]
	public void SetProgressByMileage(float mileage)
	{
	}

	[Address(RVA = "0x90D800", Offset = "0x90C000", Length = "0xB0")]
	[Token(Token = "0x60032FD")]
	private void UpdateAngleCache()
	{
	}

	[Token(Token = "0x60032FE")]
	[Address(RVA = "0x90D8B0", Offset = "0x90C0B0", Length = "0x88")]
	public Scrollable()
	{
	}
}
