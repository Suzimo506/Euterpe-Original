using Cpp2ILInjected;

namespace Assets.Scripts.Device.Android.OAID;

[Token(Token = "0x200077D")]
public class OAIDUploadChain : InvokeChain<OAIDUploadContext>
{
	[Token(Token = "0x4002796")]
	[FieldOffset(Offset = "0x30")]
	private readonly string checkUrl;

	[Token(Token = "0x4002797")]
	[FieldOffset(Offset = "0x38")]
	private readonly string uploadUrl;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002798")]
	private readonly string analyticsServerInitUrlDev;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4002799")]
	private readonly string analyticsServerInitUrlTest;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400279A")]
	private readonly string analyticsServerInitUrlRelease;

	[Token(Token = "0x17000694")]
	private string analyticsServerUrl
	{
		[Address(RVA = "0x4A2BC0", Offset = "0x4A13C0", Length = "0x10")]
		[Token(Token = "0x600462E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000695")]
	private string uploadAnalyticsUrl
	{
		[Address(RVA = "0x4A2BD0", Offset = "0x4A13D0", Length = "0x10")]
		[Token(Token = "0x600462F")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x4A2900", Offset = "0x4A1100", Length = "0x216")]
	[Token(Token = "0x6004630")]
	protected override void DefineStage()
	{
	}

	[Token(Token = "0x6004631")]
	[Address(RVA = "0x4A2890", Offset = "0x4A1090", Length = "0x6C")]
	protected override void ContextInitializeByInvokeData(InvokeData _)
	{
	}

	[Token(Token = "0x6004632")]
	[Address(RVA = "0x4A2B20", Offset = "0x4A1320", Length = "0x97")]
	public OAIDUploadChain()
	{
		((InvokeChain<T>)(object)this)._002Ector();
	}
}
