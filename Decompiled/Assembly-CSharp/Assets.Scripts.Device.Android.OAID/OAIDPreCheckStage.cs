using System.Collections;
using Cpp2ILInjected;

namespace Assets.Scripts.Device.Android.OAID;

[Token(Token = "0x200077C")]
public class OAIDPreCheckStage : InvokeChainStage<OAIDUploadContext>
{
	[Token(Token = "0x600462B")]
	[Address(RVA = "0x4A27A0", Offset = "0x4A0FA0", Length = "0xAD")]
	protected override void InvokeImplementation()
	{
	}

	[Address(RVA = "0x4A2730", Offset = "0x4A0F30", Length = "0x65")]
	[Token(Token = "0x600462C")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xA1750", Offset = "0xA0B50")]
	private IEnumerator CheckServerIsOnline()
	{
		return null;
	}

	[Token(Token = "0x600462D")]
	[Address(RVA = "0x4A2850", Offset = "0x4A1050", Length = "0x38")]
	public OAIDPreCheckStage()
	{
		((InvokeChainStage<T>)(object)this)._002Ector();
	}
}
