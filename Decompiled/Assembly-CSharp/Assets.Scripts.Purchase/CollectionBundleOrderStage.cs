using System.Collections.Generic;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq;

namespace Assets.Scripts.Purchase;

[Token(Token = "0x20006C4")]
public class CollectionBundleOrderStage : IIAPPipelineStage
{
	[Token(Token = "0x4002475")]
	[FieldOffset(Offset = "0xD8")]
	private string requestUrl;

	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4002476")]
	private string m_GoogleUrl;

	[Token(Token = "0x4002477")]
	[FieldOffset(Offset = "0xE8")]
	private string m_iOSUrl;

	[Token(Token = "0x4002478")]
	[FieldOffset(Offset = "0xF0")]
	private Dictionary<string, object> builderData;

	[Token(Token = "0x6003F4A")]
	[Address(RVA = "0xFD4140", Offset = "0xFD2940", Length = "0xBD")]
	public CollectionBundleOrderStage()
	{
	}

	[Address(RVA = "0xFD3910", Offset = "0xFD2110", Length = "0x4E")]
	[Token(Token = "0x6003F4B")]
	protected override void InvokeImpl()
	{
	}

	[Token(Token = "0x6003F4C")]
	[Address(RVA = "0xFD3A40", Offset = "0xFD2240", Length = "0x50F")]
	private void RequestPeroOrderIdentifier()
	{
	}

	[Token(Token = "0x6003F4D")]
	[Address(RVA = "0xFD3F50", Offset = "0xFD2750", Length = "0x1E6")]
	private void RequestSuccess(JObject response)
	{
	}

	[Address(RVA = "0xFD39B0", Offset = "0xFD21B0", Length = "0x8D")]
	[Token(Token = "0x6003F4E")]
	private void RequestFailed(long code, string msg)
	{
	}

	[Address(RVA = "0xFD3960", Offset = "0xFD2160", Length = "0x4F")]
	[Token(Token = "0x6003F4F")]
	private void RequestCompleted()
	{
	}
}
