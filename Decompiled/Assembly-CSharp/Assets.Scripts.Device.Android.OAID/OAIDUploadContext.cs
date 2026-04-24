using Cpp2ILInjected;

namespace Assets.Scripts.Device.Android.OAID;

[Token(Token = "0x200077E")]
public class OAIDUploadContext : InvokeChainContext
{
	[Token(Token = "0x400279B")]
	[FieldOffset(Offset = "0x20")]
	public string analyticsServerCheckUrl;

	[Token(Token = "0x400279C")]
	[FieldOffset(Offset = "0x28")]
	public string uploadUrl;

	[Token(Token = "0x400279D")]
	[FieldOffset(Offset = "0x30")]
	public string deviceType;

	[Token(Token = "0x400279E")]
	[FieldOffset(Offset = "0x38")]
	public string installTime;

	[Token(Token = "0x400279F")]
	[FieldOffset(Offset = "0x40")]
	public string android_id;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40027A0")]
	public string oaid;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40027A1")]
	public string imei;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40027A2")]
	public string os;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40027A3")]
	public string osVersion;

	[Token(Token = "0x6004633")]
	[Address(RVA = "0x4A2BE0", Offset = "0x4A13E0", Length = "0x12E")]
	public override void Clear()
	{
	}

	[Token(Token = "0x6004634")]
	[Address(RVA = "0x4A2D10", Offset = "0x4A1510", Length = "0x607")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004635")]
	[Address(RVA = "0x441AE0", Offset = "0x4402E0", Length = "0x7")]
	public OAIDUploadContext()
	{
	}
}
