using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008DA")]
public class PnlOverseaAsk : UISelectManage
{
	[Token(Token = "0x4002E6D")]
	[FieldOffset(Offset = "0x118")]
	public List<Button> buttons;

	[Token(Token = "0x4002E6E")]
	[FieldOffset(Offset = "0x120")]
	public Text[] texts;

	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4002E6F")]
	public Button yesBtn;

	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4002E70")]
	public GameObject[] imgs;

	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4002E71")]
	private string[] m_Urls;

	[Address(RVA = "0x684B30", Offset = "0x683330", Length = "0x133")]
	[Token(Token = "0x6004FD8")]
	public override List<GameObject> SetSelectableObj()
	{
		return null;
	}

	[Address(RVA = "0x684240", Offset = "0x682A40", Length = "0x8C")]
	[Token(Token = "0x6004FD9")]
	public override void OnAwake()
	{
	}

	[Token(Token = "0x6004FDA")]
	[Address(RVA = "0x6842D0", Offset = "0x682AD0", Length = "0x6F2")]
	public override void OnEnablePnl()
	{
	}

	[Token(Token = "0x6004FDB")]
	[Address(RVA = "0x6849D0", Offset = "0x6831D0", Length = "0x15F")]
	private void OnYesClicked()
	{
	}

	[Token(Token = "0x6004FDC")]
	[Address(RVA = "0x684C70", Offset = "0x683470", Length = "0x8F")]
	public PnlOverseaAsk()
	{
	}
}
