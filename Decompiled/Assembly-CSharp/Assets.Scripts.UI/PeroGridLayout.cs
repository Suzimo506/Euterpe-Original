using Cpp2ILInjected;
using UnityEngine.UI;

namespace Assets.Scripts.UI;

[Token(Token = "0x200081F")]
public class PeroGridLayout : GridLayoutGroup
{
	[Token(Token = "0x6004AF2")]
	[Address(RVA = "0x4C2580", Offset = "0x4C0D80", Length = "0xA")]
	public override void SetLayoutHorizontal()
	{
	}

	[Token(Token = "0x6004AF3")]
	[Address(RVA = "0x4C2590", Offset = "0x4C0D90", Length = "0xC")]
	public override void SetLayoutVertical()
	{
	}

	[Token(Token = "0x6004AF4")]
	[Address(RVA = "0x4C1DB0", Offset = "0x4C05B0", Length = "0xA")]
	private bool IsLastRow(int itemIndex, int count, int row)
	{
		return default(bool);
	}

	[Token(Token = "0x6004AF5")]
	[Address(RVA = "0x4C1DC0", Offset = "0x4C05C0", Length = "0x7B8")]
	private void SetCellsAlongAxis(int axis)
	{
	}

	[Token(Token = "0x6004AF6")]
	[Address(RVA = "0x4C25A0", Offset = "0x4C0DA0", Length = "0x7")]
	public PeroGridLayout()
	{
	}
}
