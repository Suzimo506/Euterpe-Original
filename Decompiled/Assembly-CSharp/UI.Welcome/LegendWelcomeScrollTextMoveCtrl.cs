using Cpp2ILInjected;
using UnityEngine;

namespace UI.Welcome;

[Token(Token = "0x20001B2")]
public class LegendWelcomeScrollTextMoveCtrl : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A80")]
	[SerializeField]
	private Vector3 m_EndValue;

	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000A81")]
	[SerializeField]
	private Vector3 m_StartValue;

	[Token(Token = "0x4000A82")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "RangeAttribute", RVA = "0xCF40", Offset = "0xC340")]
	[SerializeField]
	private float m_DurationRate;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A83")]
	private RectTransform m_ElementRect;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000A84")]
	private RectTransform m_ContainerRect;

	[Address(RVA = "0x4D63A0", Offset = "0x4D4BA0", Length = "0x88")]
	[Token(Token = "0x6000C24")]
	private void Awake()
	{
	}

	[Address(RVA = "0x4D6430", Offset = "0x4D4C30", Length = "0x197")]
	[Token(Token = "0x6000C25")]
	private void FixedUpdate()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6000C26")]
	public LegendWelcomeScrollTextMoveCtrl()
	{
	}
}
