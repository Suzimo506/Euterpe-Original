using Cpp2ILInjected;
using UnityEngine;

namespace UI.Specials.LegendBuroSpecials;

[Token(Token = "0x20001B9")]
public class ChangeFxTextValueLegend : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000ABA")]
	[SerializeField]
	private SuperTextMesh m_SuText;

	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000ABB")]
	private Font m_BadAppleFont;

	[Address(RVA = "0x4D5030", Offset = "0x4D3830", Length = "0xCE")]
	[Token(Token = "0x6000C4D")]
	private void Start()
	{
	}

	[Address(RVA = "0x4D4F70", Offset = "0x4D3770", Length = "0xBC")]
	[Token(Token = "0x6000C4E")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6000C4F")]
	public ChangeFxTextValueLegend()
	{
	}
}
