using Cpp2ILInjected;

namespace Assets.Scripts.UI.Panels.Bulletin.AnnounceModule;

[Token(Token = "0x2000956")]
public class PnlAnnounceController : BaseMessageBox
{
	[Token(Token = "0x40032EB")]
	[FieldOffset(Offset = "0xF0")]
	public PnlAnnounceRequestStateController stateCtrl;

	[Token(Token = "0x40032EC")]
	[FieldOffset(Offset = "0xF8")]
	public PnlAnnounceContentController contentCtrl;

	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40032ED")]
	public PnlAnnounceSelect selectComp;

	[Token(Token = "0x60054CA")]
	[Address(RVA = "0x6C8C50", Offset = "0x6C7450", Length = "0xF0")]
	public void PopupAndRequest(float duration = 0f)
	{
	}

	[Address(RVA = "0x6C8EE0", Offset = "0x6C76E0", Length = "0xC1")]
	[Token(Token = "0x60054CB")]
	public void RequestAnnounceData()
	{
	}

	[Address(RVA = "0x6C8D50", Offset = "0x6C7550", Length = "0x189")]
	[Token(Token = "0x60054CC")]
	public void PopupAsync()
	{
	}

	[Token(Token = "0x60054CD")]
	[Address(RVA = "0x4C6980", Offset = "0x4C5180", Length = "0x7")]
	public PnlAnnounceController()
	{
	}
}
