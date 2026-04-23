using System.Collections;
using Cpp2ILInjected;

namespace Assets.Scripts.UI.Tips;

[Token(Token = "0x2000883")]
public class PnlNsTargetConnectTips : BaseMessageBox
{
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4002C6F")]
	private bool m_IsCoolDown;

	[Token(Token = "0x6004D8F")]
	[Address(RVA = "0x5FCEC0", Offset = "0x5FB6C0", Length = "0x93")]
	public void ShowForTarget(string targetName)
	{
	}

	[Address(RVA = "0x5FCE30", Offset = "0x5FB630", Length = "0x84")]
	[Token(Token = "0x6004D90")]
	protected override void OnYesClicked()
	{
	}

	[Address(RVA = "0x5FCF60", Offset = "0x5FB760", Length = "0x65")]
	[Token(Token = "0x6004D91")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x3B340", Offset = "0x3A740")]
	private IEnumerator YesCoolDown()
	{
		return null;
	}

	[Address(RVA = "0x5F96A0", Offset = "0x5F7EA0", Length = "0x51")]
	[Token(Token = "0x6004D92")]
	public PnlNsTargetConnectTips()
	{
	}
}
