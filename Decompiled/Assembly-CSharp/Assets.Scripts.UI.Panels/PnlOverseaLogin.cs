using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;
using ZenFulcrum.EmbeddedBrowser;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008DB")]
public class PnlOverseaLogin : UISelectManage
{
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4002E72")]
	public Button btnFaceBook;

	[Token(Token = "0x4002E73")]
	[FieldOffset(Offset = "0x120")]
	public Button btnGoogle;

	[Token(Token = "0x4002E74")]
	[FieldOffset(Offset = "0x128")]
	public GameObject goPlatform;

	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4002E75")]
	private string m_Copy;

	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4002E76")]
	private List<Button> m_Buttons;

	[Token(Token = "0x4002E77")]
	[SerializeField]
	[FieldOffset(Offset = "0x140")]
	private GameObject m_GoogleLoginWeb;

	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4002E78")]
	public Browser browser;

	[Token(Token = "0x6004FDD")]
	[Address(RVA = "0x684DB0", Offset = "0x6835B0", Length = "0x1D3")]
	public override void OnInit()
	{
	}

	[Address(RVA = "0x684F90", Offset = "0x683790", Length = "0x119")]
	[Token(Token = "0x6004FDE")]
	public override List<GameObject> SetSelectableObj()
	{
		return null;
	}

	[Address(RVA = "0x684D00", Offset = "0x683500", Length = "0xA8")]
	[Token(Token = "0x6004FDF")]
	public override void OnDisablePnl()
	{
	}

	[Address(RVA = "0x685410", Offset = "0x683C10", Length = "0x6C")]
	[Token(Token = "0x6004FE0")]
	public PnlOverseaLogin()
	{
	}
}
