using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Purchase;

[Token(Token = "0x20006B9")]
public class IAPPipeline
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002434")]
	private List<IIAPPipelineStage> stages;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002435")]
	private Action<IAPPipelineContext> m_ExcuteFinishCallback;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002436")]
	private bool isPurchasing;

	[Token(Token = "0x6003F08")]
	[Address(RVA = "0xFD7D10", Offset = "0xFD6510", Length = "0x7")]
	public void Initialize()
	{
	}

	[Address(RVA = "0xFD6EF0", Offset = "0xFD56F0", Length = "0x6EF")]
	[Token(Token = "0x6003F09")]
	private void BuilderInitialize()
	{
	}

	[Token(Token = "0x6003F0A")]
	[Address(RVA = "0xFD7D20", Offset = "0xFD6520", Length = "0x52F")]
	public void StartPurchaseChain(string productId, Action<IAPPipelineContext> excuteFinishCallback)
	{
	}

	[Token(Token = "0x6003F0B")]
	[Address(RVA = "0xFD7980", Offset = "0xFD6180", Length = "0x385")]
	private IAPPipelineContext GetNewIAPOrderPrototype(string productId)
	{
		return default(IAPPipelineContext);
	}

	[Token(Token = "0x6003F0C")]
	[Address(RVA = "0xFD75E0", Offset = "0xFD5DE0", Length = "0x39A")]
	private void ExcuteFinish(IAPPipelineContext iapPipelineContext)
	{
	}

	[Token(Token = "0x6003F0D")]
	[Address(RVA = "0xFD8250", Offset = "0xFD6A50", Length = "0x6E")]
	public IAPPipeline()
	{
	}
}
