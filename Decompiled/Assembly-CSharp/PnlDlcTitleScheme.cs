using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Attribute(Name = "RequireComponent", RVA = "0x197D0", Offset = "0x18BD0")]
[Token(Token = "0x2000112")]
public class PnlDlcTitleScheme : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006A4")]
	private RectTransform m_RectTransform;

	[Attribute(Name = "TooltipAttribute", RVA = "0x19950", Offset = "0x18D50")]
	[SerializeField]
	[Token(Token = "0x40006A5")]
	[FieldOffset(Offset = "0x20")]
	private List<Vector2> schemes;

	[Token(Token = "0x60007E1")]
	[Address(RVA = "0x4FEB00", Offset = "0x4FD300", Length = "0x47")]
	private void Awake()
	{
	}

	[Token(Token = "0x60007E2")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60007E3")]
	[Address(RVA = "0x4FEB50", Offset = "0x4FD350", Length = "0xF6")]
	private void BatchesDifferentResolutions()
	{
	}

	[Token(Token = "0x60007E4")]
	[Address(RVA = "0x4FEC50", Offset = "0x4FD450", Length = "0x69")]
	public PnlDlcTitleScheme()
	{
	}
}
