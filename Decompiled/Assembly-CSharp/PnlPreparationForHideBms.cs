using Cpp2ILInjected;
using UnityEngine.UI;

[Token(Token = "0x200012D")]
public class PnlPreparationForHideBms : PnlPreparation
{
	[Token(Token = "0x4000764")]
	[FieldOffset(Offset = "0x78")]
	public Button btnBackToCollect;

	[Token(Token = "0x6000885")]
	[Address(RVA = "0x7B2940", Offset = "0x7B1140", Length = "0xD5")]
	protected override void OnAwake()
	{
	}

	[Address(RVA = "0x7B2A20", Offset = "0x7B1220", Length = "0x16E")]
	[Token(Token = "0x6000886")]
	private void OnBackClicked()
	{
	}

	[Token(Token = "0x6000887")]
	[Address(RVA = "0x7B2B90", Offset = "0x7B1390", Length = "0x64")]
	public PnlPreparationForHideBms()
	{
	}
}
