using Assets.Scripts.PeroTools.UI;
using Cpp2ILInjected;
using UnityEngine.UI;

[Token(Token = "0x20000E8")]
public class ImgSaveSelect : BaseMessageBox
{
	[Token(Token = "0x40005D2")]
	[FieldOffset(Offset = "0xF0")]
	public Text path;

	[Token(Token = "0x40005D3")]
	[FieldOffset(Offset = "0xF8")]
	public InputKeyBinding iiusCheckExitBtnCancel;

	[Token(Token = "0x60006BF")]
	[Address(RVA = "0x5C7150", Offset = "0x5C5950", Length = "0x100")]
	public override void Show()
	{
	}

	[Token(Token = "0x60006C0")]
	[Address(RVA = "0x5C70B0", Offset = "0x5C58B0", Length = "0x93")]
	public override void Close(bool disablePrevPopup = false)
	{
	}

	[Token(Token = "0x60006C1")]
	[Address(RVA = "0x4C6980", Offset = "0x4C5180", Length = "0x7")]
	public ImgSaveSelect()
	{
	}
}
