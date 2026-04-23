using System.Collections;
using Cpp2ILInjected;

namespace Assets.Scripts.Device.Android.OAID;

[Token(Token = "0x200077F")]
public class OAIDUploadStage : InvokeChainStage<OAIDUploadContext>
{
	[Token(Token = "0x6004636")]
	[Address(RVA = "0x4A3320", Offset = "0x4A1B20", Length = "0x323")]
	protected override void InvokeImplementation()
	{
	}

	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xA1D60", Offset = "0xA1160")]
	[Token(Token = "0x6004637")]
	[Address(RVA = "0x4A36E0", Offset = "0x4A1EE0", Length = "0x81")]
	private IEnumerator UploadOAID(byte[] binaryData)
	{
		return null;
	}

	[Address(RVA = "0x4A3650", Offset = "0x4A1E50", Length = "0x89")]
	[Token(Token = "0x6004638")]
	private bool IsRepeatUpload(string oaid)
	{
		return default(bool);
	}

	[Address(RVA = "0x4A3770", Offset = "0x4A1F70", Length = "0x38")]
	[Token(Token = "0x6004639")]
	public OAIDUploadStage()
	{
		((InvokeChainStage<T>)(object)this)._002Ector();
	}
}
