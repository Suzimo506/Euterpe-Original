using Assets.Scripts.UI.Panels;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Specials;

[Token(Token = "0x200086A")]
public class AutoPushPopPanel : MonoBehaviour
{
	[Token(Token = "0x4002BF6")]
	[FieldOffset(Offset = "0x18")]
	public Button btnNavigationBack;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002BF7")]
	public CanvasGroup pnlHome;

	[Token(Token = "0x4002BF8")]
	[FieldOffset(Offset = "0x28")]
	public CanvasGroup pnlMenu;

	[Token(Token = "0x4002BF9")]
	[FieldOffset(Offset = "0x30")]
	public CanvasGroup pnlNavigation;

	[Token(Token = "0x4002BFA")]
	[FieldOffset(Offset = "0x38")]
	public CanvasGroup pnlPreparation;

	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x32B30", Offset = "0x31F30")]
	[Token(Token = "0x4002BFB")]
	public CanvasGroup pnlStage;

	[Token(Token = "0x4002BFC")]
	[FieldOffset(Offset = "0x48")]
	public PnlMenu pnlMenuScript;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4002BFD")]
	public GameObject pnlStageBgsRoot;

	[Token(Token = "0x4002BFE")]
	[FieldOffset(Offset = "0x58")]
	private CanvasGroup m_PreActivePanel;

	[Token(Token = "0x1700086C")]
	private CanvasGroup preActivePanel
	{
		[Token(Token = "0x6004CED")]
		[Address(RVA = "0x429C40", Offset = "0x428440", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004CEE")]
		[Address(RVA = "0x51B9E0", Offset = "0x51A1E0", Length = "0xC")]
		set
		{
		}
	}

	[Token(Token = "0x6004CEF")]
	[Address(RVA = "0x609420", Offset = "0x607C20", Length = "0x423")]
	private void Awake()
	{
	}

	[Address(RVA = "0x609CA0", Offset = "0x6084A0", Length = "0x543")]
	[Token(Token = "0x6004CF0")]
	private void OnNavigationBackClicked()
	{
	}

	[Token(Token = "0x6004CF1")]
	[Address(RVA = "0x6098F0", Offset = "0x6080F0", Length = "0x3AC")]
	private void OnMenuBackClicked()
	{
	}

	[Address(RVA = "0x609850", Offset = "0x608050", Length = "0x9B")]
	[Token(Token = "0x6004CF2")]
	private void Close(CanvasGroup cg, bool changeGo = true)
	{
	}

	[Token(Token = "0x6004CF3")]
	[Address(RVA = "0x60A6B0", Offset = "0x608EB0", Length = "0x9B")]
	private void Show(CanvasGroup cg, bool changeGo = true)
	{
	}

	[Address(RVA = "0x60A1F0", Offset = "0x6089F0", Length = "0x3B")]
	[Token(Token = "0x6004CF4")]
	private void OnPnlHomeActiveChanged(GameObject go, bool active)
	{
	}

	[Token(Token = "0x6004CF5")]
	[Address(RVA = "0x60A4E0", Offset = "0x608CE0", Length = "0x185")]
	private void OnPnlPreparationActiveChanged(GameObject arg0, bool active)
	{
	}

	[Token(Token = "0x6004CF6")]
	[Address(RVA = "0x60A670", Offset = "0x608E70", Length = "0x3B")]
	private void OnPnlStageActiveChanged(GameObject arg0, bool active)
	{
	}

	[Token(Token = "0x6004CF7")]
	[Address(RVA = "0x60A230", Offset = "0x608A30", Length = "0x2A7")]
	private void OnPnlMenuActiveChanged(GameObject arg0, bool active)
	{
	}

	[Token(Token = "0x6004CF8")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public AutoPushPopPanel()
	{
	}
}
