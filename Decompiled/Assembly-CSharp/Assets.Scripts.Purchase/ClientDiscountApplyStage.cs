using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Purchase;

[Token(Token = "0x20006C1")]
public class ClientDiscountApplyStage : IIAPPipelineStage
{
	[Token(Token = "0x4002472")]
	[FieldOffset(Offset = "0xD8")]
	private ClientDiscountManager cdm;

	[Token(Token = "0x4002473")]
	[FieldOffset(Offset = "0xE0")]
	private float m_Timeout;

	[Token(Token = "0x6003F42")]
	[Address(RVA = "0x975910", Offset = "0x974110", Length = "0xA4")]
	protected override void InvokeImpl()
	{
	}

	[Address(RVA = "0x9759C0", Offset = "0x9741C0", Length = "0x65")]
	[Token(Token = "0x6003F43")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x4E920", Offset = "0x4DD20")]
	private IEnumerator<float> WaitUntilClientDiscountReady()
	{
		return null;
	}

	[Token(Token = "0x6003F44")]
	[Address(RVA = "0x975A30", Offset = "0x974230", Length = "0x11")]
	public ClientDiscountApplyStage()
	{
	}
}
