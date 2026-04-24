using Cpp2ILInjected;
using UI.Panels.PnlInputs.PCInputModules;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000F2")]
public class PCCustomKeyCell : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400060A")]
	public Image objImg;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400060B")]
	public Image imgSpecialButton;

	[Token(Token = "0x400060C")]
	[FieldOffset(Offset = "0x28")]
	public Text txtKey;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400060D")]
	public Text txtKeySetting;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400060E")]
	public Text txtKeyNo;

	[Token(Token = "0x400060F")]
	[FieldOffset(Offset = "0x40")]
	public Image imgSelected;

	[Token(Token = "0x4000610")]
	[FieldOffset(Offset = "0x48")]
	private PnlInputPc.KeyType m_BtnType;

	[Token(Token = "0x4000611")]
	[FieldOffset(Offset = "0x50")]
	private InputCustomizeSelect m_CustomizeSelect;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000612")]
	private bool m_isListeningCustomKey;

	[Token(Token = "0x600071C")]
	[Address(RVA = "0x872B10", Offset = "0x871310", Length = "0x1AF")]
	private void Awake()
	{
	}

	[Token(Token = "0x600071D")]
	[Address(RVA = "0x873070", Offset = "0x871870", Length = "0x56")]
	public void OnClickToSendInfo()
	{
	}

	[Address(RVA = "0x6F3B00", Offset = "0x6F2300", Length = "0x4")]
	[Token(Token = "0x600071E")]
	public PnlInputPc.KeyType GetBtnType()
	{
		return default(PnlInputPc.KeyType);
	}

	[Token(Token = "0x600071F")]
	[Address(RVA = "0x872F60", Offset = "0x871760", Length = "0x10F")]
	public void CustomCurrentKey(PnlInputKeyboard parent)
	{
	}

	[Token(Token = "0x6000720")]
	[Address(RVA = "0x873200", Offset = "0x871A00", Length = "0x78")]
	public void SetKeyToKey(string keyName)
	{
	}

	[Token(Token = "0x6000721")]
	[Address(RVA = "0x8732D0", Offset = "0x871AD0", Length = "0x4A")]
	public void SetKeyToSetting()
	{
	}

	[Address(RVA = "0x873280", Offset = "0x871A80", Length = "0x4A")]
	[Token(Token = "0x6000722")]
	public void SetKeyToNo()
	{
	}

	[Token(Token = "0x6000723")]
	[Address(RVA = "0x873320", Offset = "0x871B20", Length = "0x127")]
	public void SetKeyToSpecial(string keyName)
	{
	}

	[Address(RVA = "0x8730D0", Offset = "0x8718D0", Length = "0x125")]
	[Token(Token = "0x6000724")]
	private void OnKeySetting(string buttonName, int currentCustomKeyIndex)
	{
	}

	[Token(Token = "0x6000725")]
	[Address(RVA = "0x872CC0", Offset = "0x8714C0", Length = "0x1A7")]
	private void CheckActive(GameObject showObj)
	{
	}

	[Address(RVA = "0x872E70", Offset = "0x871670", Length = "0xE2")]
	[Token(Token = "0x6000726")]
	private void CheckKeyType()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6000727")]
	public PCCustomKeyCell()
	{
	}
}
