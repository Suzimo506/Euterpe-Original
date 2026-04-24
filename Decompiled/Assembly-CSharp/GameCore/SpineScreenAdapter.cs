using Cpp2ILInjected;
using UnityEngine;

namespace GameCore;

[Token(Token = "0x2000463")]
public class SpineScreenAdapter : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40017F5")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x3AF00", Offset = "0x3A300")]
	[SerializeField]
	private float scaleDuration;

	[SerializeField]
	[Token(Token = "0x40017F6")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x3B040", Offset = "0x3A440")]
	private bool m_Adapt43;

	[Token(Token = "0x40017F7")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x3B250", Offset = "0x3A650")]
	[SerializeField]
	private float m_Adapt43AddDuration;

	[Address(RVA = "0x90D9E0", Offset = "0x90C1E0", Length = "0x13D")]
	[Token(Token = "0x60032E6")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x90D9E0", Offset = "0x90C1E0", Length = "0x13D")]
	[Attribute(Name = "ContextMenu", RVA = "0x3B4F0", Offset = "0x3A8F0")]
	[Token(Token = "0x60032E7")]
	private void Adapt()
	{
	}

	[Address(RVA = "0x90DB20", Offset = "0x90C320", Length = "0x15")]
	[Token(Token = "0x60032E8")]
	public SpineScreenAdapter()
	{
	}
}
