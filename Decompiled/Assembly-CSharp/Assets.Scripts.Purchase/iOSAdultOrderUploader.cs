using Cpp2ILInjected;
using Newtonsoft.Json.Linq;

namespace Assets.Scripts.Purchase;

[Token(Token = "0x20006D3")]
public class iOSAdultOrderUploader : IIAPPipelineStage
{
	[Address(RVA = "0x4EBAF0", Offset = "0x4EA2F0", Length = "0xD")]
	[Token(Token = "0x6003F7E")]
	protected override void InvokeImpl()
	{
	}

	[Address(RVA = "0x6627B0", Offset = "0x660FB0", Length = "0xC0")]
	[Token(Token = "0x6003F7F")]
	private void OnSuccess(JObject result)
	{
	}

	[Address(RVA = "0x6626F0", Offset = "0x660EF0", Length = "0xB6")]
	[Token(Token = "0x6003F80")]
	private void OnFailed(long code, string msg)
	{
	}

	[Token(Token = "0x6003F81")]
	[Address(RVA = "0x441AE0", Offset = "0x4402E0", Length = "0x7")]
	public iOSAdultOrderUploader()
	{
	}
}
