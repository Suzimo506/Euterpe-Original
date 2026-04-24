using System.Collections.Generic;
using Assets.Scripts.Structs;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Panels;

[Token(Token = "0x20001C4")]
public class PnlGraphicSettingNS : UISelectManage
{
	[Token(Token = "0x4000B23")]
	[FieldOffset(Offset = "0x118")]
	public Button bgButton;

	[Token(Token = "0x4000B24")]
	[FieldOffset(Offset = "0x120")]
	public GameObject bgButtonSelected;

	[Token(Token = "0x4000B25")]
	[FieldOffset(Offset = "0x128")]
	public Button feverButton;

	[Token(Token = "0x4000B26")]
	[FieldOffset(Offset = "0x130")]
	public GameObject feverButtonSelected;

	[SerializeField]
	[Token(Token = "0x4000B27")]
	[FieldOffset(Offset = "0x138")]
	private AudioClip backPanelClip;

	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000B28")]
	[SerializeField]
	private List<UISetColor> m_UiSetColors;

	[SerializeField]
	[Token(Token = "0x4000B29")]
	[FieldOffset(Offset = "0x148")]
	private Color m_Normal;

	[Token(Token = "0x4000B2A")]
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	private Color m_High;

	[Token(Token = "0x6000CBD")]
	[Address(RVA = "0x50BAD0", Offset = "0x50A2D0", Length = "0x15")]
	public override void OnAwake()
	{
	}

	[Address(RVA = "0x50BD90", Offset = "0x50A590", Length = "0x2A5")]
	[Token(Token = "0x6000CBE")]
	public override List<GameObject> SetSelectableObj()
	{
		return null;
	}

	[Address(RVA = "0x50BB80", Offset = "0x50A380", Length = "0x20A")]
	[Token(Token = "0x6000CBF")]
	protected override void OnSelect(GameObject currentObj)
	{
	}

	[Token(Token = "0x6000CC0")]
	[Address(RVA = "0x50BAF0", Offset = "0x50A2F0", Length = "0x85")]
	public override void OnDisablePnl()
	{
	}

	[Token(Token = "0x6000CC1")]
	[Address(RVA = "0x4C5020", Offset = "0x4C3820", Length = "0x7")]
	public PnlGraphicSettingNS()
	{
	}
}
