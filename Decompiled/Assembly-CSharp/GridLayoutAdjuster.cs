using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200016B")]
[Attribute(Name = "RequireComponent", RVA = "0x30B70", Offset = "0x2FF70")]
public class GridLayoutAdjuster : MonoBehaviour
{
	[Token(Token = "0x40008E2")]
	[FieldOffset(Offset = "0x18")]
	private GridLayoutGroup m_GridLayout;

	[Token(Token = "0x40008E3")]
	[FieldOffset(Offset = "0x20")]
	public int desiredColumnCount;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40008E4")]
	private RectTransform m_RectTransform;

	[Address(RVA = "0x5C3B30", Offset = "0x5C2330", Length = "0x6F")]
	[Token(Token = "0x6000A46")]
	private void Start()
	{
	}

	[Address(RVA = "0x5C3B20", Offset = "0x5C2320", Length = "0x10")]
	[Token(Token = "0x6000A47")]
	public void SetColumnCount(int count)
	{
	}

	[Token(Token = "0x6000A48")]
	[Address(RVA = "0x5C3B10", Offset = "0x5C2310", Length = "0x7")]
	private void OnRectTransformDimensionsChange()
	{
	}

	[Address(RVA = "0x5C3960", Offset = "0x5C2160", Length = "0x1A4")]
	[Token(Token = "0x6000A49")]
	private void AdjustGridLayout()
	{
	}

	[Address(RVA = "0x5C3BA0", Offset = "0x5C23A0", Length = "0xE")]
	[Token(Token = "0x6000A4A")]
	public GridLayoutAdjuster()
	{
	}
}
