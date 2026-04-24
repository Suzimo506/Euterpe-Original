using System.Collections.Generic;
using Assets.Scripts.Structs;
using Cpp2ILInjected;

namespace Assets.Scripts.Purchase;

[Token(Token = "0x20006CD")]
public class PeroProductRefreshStage : IIAPPipelineStage
{
	[Token(Token = "0x6003F6C")]
	[Address(RVA = "0xFE0720", Offset = "0xFDEF20", Length = "0x204")]
	protected override void InvokeImpl()
	{
	}

	[Token(Token = "0x6003F6D")]
	[Address(RVA = "0xFE0930", Offset = "0xFDF130", Length = "0x1B7")]
	private void NewInvoke()
	{
	}

	[Address(RVA = "0xFE0AF0", Offset = "0xFDF2F0", Length = "0x105")]
	[Token(Token = "0x6003F6E")]
	private void StoreListenerProductRefreshed(List<ProductInfo> result)
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003F6F")]
	public PeroProductRefreshStage()
	{
	}
}
