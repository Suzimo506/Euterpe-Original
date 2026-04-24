using System.Collections.Generic;
using Assets.Scripts.Structs;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200013A")]
public class VolumeSelect : UISelectManage
{
	[Token(Token = "0x40007B8")]
	[FieldOffset(Offset = "0x118")]
	public AudioClip optionBgmClip;

	[Token(Token = "0x40007B9")]
	[FieldOffset(Offset = "0x120")]
	public Color highLight;

	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x40007BA")]
	public Color normal;

	[Token(Token = "0x40007BB")]
	[FieldOffset(Offset = "0x140")]
	public Color battleSfxUnSelectedColor;

	[SerializeField]
	[Token(Token = "0x40007BC")]
	[FieldOffset(Offset = "0x150")]
	private UISetColor[] m_UiSetColors;

	[SerializeField]
	[Token(Token = "0x40007BD")]
	[FieldOffset(Offset = "0x158")]
	private List<Slider> m_SliderList;

	[Token(Token = "0x40007BE")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x21D40", Offset = "0x21140")]
	[SerializeField]
	[FieldOffset(Offset = "0x160")]
	private List<Toggle> m_TitleTgls;

	[SerializeField]
	[Token(Token = "0x40007BF")]
	[FieldOffset(Offset = "0x168")]
	private ToggleGroup m_BgVoiceTglGroup;

	[FieldOffset(Offset = "0x170")]
	[SerializeField]
	[Token(Token = "0x40007C0")]
	private Toggle m_BgVoiceIsOn;

	[SerializeField]
	[Token(Token = "0x40007C1")]
	[FieldOffset(Offset = "0x178")]
	private Toggle m_BgVoiceIsOff;

	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x40007C2")]
	private GameObject m_LastSelect;

	[Address(RVA = "0xD31260", Offset = "0xD2FA60", Length = "0x366")]
	[Token(Token = "0x60008E5")]
	public override void OnAwake()
	{
	}

	[Token(Token = "0x60008E6")]
	[Address(RVA = "0xD31850", Offset = "0xD30050", Length = "0x11")]
	public override void OnInit()
	{
	}

	[Token(Token = "0x60008E7")]
	[Address(RVA = "0xD311B0", Offset = "0xD2F9B0", Length = "0xA6")]
	public override GameObject DefaultSelectObj()
	{
		return null;
	}

	[Token(Token = "0x60008E8")]
	[Address(RVA = "0xD31870", Offset = "0xD30070", Length = "0x8")]
	protected override void OnSelect(GameObject currentObj)
	{
	}

	[Token(Token = "0x60008E9")]
	[Address(RVA = "0xD31D60", Offset = "0xD30560", Length = "0x1D3")]
	private void UISliderInit(Slider slider)
	{
	}

	[Address(RVA = "0xD31AA0", Offset = "0xD302A0", Length = "0x2B5")]
	[Token(Token = "0x60008EA")]
	public override List<GameObject> SetSelectableObj()
	{
		return null;
	}

	[Address(RVA = "0xD319B0", Offset = "0xD301B0", Length = "0xE9")]
	[Token(Token = "0x60008EB")]
	private void SetSelectImage(GameObject currentObj)
	{
	}

	[Token(Token = "0x60008EC")]
	[Address(RVA = "0xD315D0", Offset = "0xD2FDD0", Length = "0x184")]
	public override void OnDisablePnl()
	{
	}

	[Token(Token = "0x60008ED")]
	[Address(RVA = "0xD31760", Offset = "0xD2FF60", Length = "0xE2")]
	public override void OnEnablePnl()
	{
	}

	[Token(Token = "0x60008EE")]
	[Address(RVA = "0xD31880", Offset = "0xD30080", Length = "0x12F")]
	private void SetFocusColor(GameObject go, bool enable)
	{
	}

	[Address(RVA = "0x4C5020", Offset = "0x4C3820", Length = "0x7")]
	[Token(Token = "0x60008EF")]
	public VolumeSelect()
	{
	}
}
