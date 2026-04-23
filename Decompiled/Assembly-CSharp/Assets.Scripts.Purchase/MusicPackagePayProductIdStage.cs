using System;
using Cpp2ILInjected;

namespace Assets.Scripts.Purchase;

[Token(Token = "0x20006CB")]
[Obsolete]
public class MusicPackagePayProductIdStage : IIAPPipelineStage
{
	[Token(Token = "0x6003F67")]
	[Address(RVA = "0x4EBAF0", Offset = "0x4EA2F0", Length = "0xD")]
	protected override void InvokeImpl()
	{
	}

	[Address(RVA = "0xFDDD10", Offset = "0xFDC510", Length = "0x1DA")]
	[Token(Token = "0x6003F68")]
	private string TryReplaceProductIdToPayProductId(string productId)
	{
		return null;
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003F69")]
	public MusicPackagePayProductIdStage()
	{
	}
}
