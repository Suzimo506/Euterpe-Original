using Cpp2ILInjected;
using Newtonsoft.Json.Linq;

namespace Assets.Scripts.Purchase;

[Token(Token = "0x20006C9")]
public class IOSAdultTypeCheckStage : IIAPPipelineStage
{
	[Token(Token = "0x6003F61")]
	[Address(RVA = "0x4EBAF0", Offset = "0x4EA2F0", Length = "0xD")]
	protected override void InvokeImpl()
	{
	}

	[Address(RVA = "0xFD9210", Offset = "0xFD7A10", Length = "0x1D2")]
	[Token(Token = "0x6003F62")]
	private void AnalyzeDataFromPeroServer(JObject result)
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003F63")]
	public IOSAdultTypeCheckStage()
	{
	}
}
