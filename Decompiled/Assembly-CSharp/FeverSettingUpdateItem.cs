using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000116")]
public class FeverSettingUpdateItem : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006CE")]
	[SerializeField]
	private Image imgBG;

	[SerializeField]
	[Token(Token = "0x40006CF")]
	[FieldOffset(Offset = "0x20")]
	private Text txtFeverName;

	[Address(RVA = "0x44E430", Offset = "0x44CC30", Length = "0x4D")]
	[Token(Token = "0x6000820")]
	public void SetFeverInfo(Sprite sprite, string feverName)
	{
	}

	[Token(Token = "0x6000821")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public FeverSettingUpdateItem()
	{
	}
}
