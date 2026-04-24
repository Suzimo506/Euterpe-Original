using System.Collections.Generic;
using Cpp2ILInjected;
using PeroPeroGames.GlobalDefines;
using nn.hid;

namespace Assets.Scripts.GameCore.Controller;

[Token(Token = "0x2000778")]
public class NsController : Controller<NsButtonConfig>
{
	[Token(Token = "0x400277A")]
	[FieldOffset(Offset = "0x18")]
	private List<int> m_DownList;

	[Token(Token = "0x400277B")]
	[FieldOffset(Offset = "0x20")]
	private List<int> m_MoveList;

	[Token(Token = "0x400277C")]
	[FieldOffset(Offset = "0x28")]
	private List<int> m_UpList;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400277D")]
	private Dictionary<string, List<NpadButton>> m_Dict;

	[Token(Token = "0x400277E")]
	[FieldOffset(Offset = "0x38")]
	private string m_ProposalName;

	[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
	[Token(Token = "0x6004600")]
	protected override bool GetButtonProposal(MDButtonType buttonName)
	{
		return default(bool);
	}

	[Token(Token = "0x6004601")]
	[Address(RVA = "0x4A22B0", Offset = "0x4A0AB0", Length = "0xC8")]
	public override void OnInit()
	{
	}

	[Token(Token = "0x6004602")]
	[Address(RVA = "0x4A2380", Offset = "0x4A0B80", Length = "0x112")]
	public override void SwitchProposal(string proposalName)
	{
	}

	[Token(Token = "0x6004603")]
	[Address(RVA = "0x4A2190", Offset = "0x4A0990", Length = "0x7B")]
	private List<int> GetButtonList(BUTTON_STATE buttonState)
	{
		return null;
	}

	[Token(Token = "0x6004604")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0940", Length = "0x4A")]
	public override List<int> GetButtonDown(MDButtonType buttonName)
	{
		return null;
	}

	[Address(RVA = "0x4A2210", Offset = "0x4A0A10", Length = "0x4A")]
	[Token(Token = "0x6004605")]
	public override List<int> GetButtonUp(MDButtonType buttonName)
	{
		return null;
	}

	[Token(Token = "0x6004606")]
	[Address(RVA = "0x4A2260", Offset = "0x4A0A60", Length = "0x4A")]
	public override List<int> GetButton(MDButtonType buttonName)
	{
		return null;
	}

	[Token(Token = "0x6004607")]
	[Address(RVA = "0x4A24A0", Offset = "0x4A0CA0", Length = "0x6E")]
	public NsController()
	{
		((Controller<>)(object)this)._002Ector();
	}
}
