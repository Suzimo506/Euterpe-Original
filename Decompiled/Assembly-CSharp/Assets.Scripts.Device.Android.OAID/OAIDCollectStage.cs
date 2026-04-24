using Cpp2ILInjected;

namespace Assets.Scripts.Device.Android.OAID;

[Token(Token = "0x200077B")]
public class OAIDCollectStage : InvokeChainStage<OAIDUploadContext>
{
	[Address(RVA = "0x4A2620", Offset = "0x4A0E20", Length = "0xCC")]
	[Token(Token = "0x6004627")]
	protected override void InvokeImplementation()
	{
	}

	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xA1490", Offset = "0xA0890")]
	[Token(Token = "0x6004628")]
	[Address(RVA = "0x4A2620", Offset = "0x4A0E20", Length = "0xCC")]
	private void GetDeviceInfo()
	{
	}

	[Token(Token = "0x6004629")]
	[Address(RVA = "0x4A2510", Offset = "0x4A0D10", Length = "0x108")]
	private void FillWithTestData()
	{
	}

	[Token(Token = "0x600462A")]
	[Address(RVA = "0x4A26F0", Offset = "0x4A0EF0", Length = "0x38")]
	public OAIDCollectStage()
	{
		((InvokeChainStage<T>)(object)this)._002Ector();
	}
}
