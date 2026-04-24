using System;
using Cpp2ILInjected;

namespace Assets.Scripts.Purchase;

[Token(Token = "0x20006C8")]
public abstract class IIAPPipelineStage : IComparable<IIAPPipelineStage>
{
	[Token(Token = "0x4002479")]
	[FieldOffset(Offset = "0x10")]
	private int priority;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400247A")]
	private Action<IAPPipelineContext> m_ExcuteCallBack;

	[Token(Token = "0x400247B")]
	[FieldOffset(Offset = "0x20")]
	protected IAPPipelineContext m_IAPPipelineContext;

	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x400247C")]
	private IIAPPipelineStage m_NextStage;

	[Address(RVA = "0x48EDC0", Offset = "0x48D5C0", Length = "0xC")]
	[Token(Token = "0x6003F5A")]
	public void SetBuildCallBack(Action<IAPPipelineContext> callBack)
	{
	}

	[Token(Token = "0x6003F5B")]
	[Address(RVA = "0x49A9A0", Offset = "0x4991A0", Length = "0xF")]
	public void SetNextBuilder(IIAPPipelineStage nextStage)
	{
	}

	[Token(Token = "0x6003F5C")]
	[Address(RVA = "0xFD9170", Offset = "0xFD7970", Length = "0x9C")]
	public void Invoke(IAPPipelineContext context)
	{
	}

	[Token(Token = "0x6003F5D")]
	[Address(RVA = "0x0", Length = "0x0")]
	protected abstract void InvokeImpl();

	[Token(Token = "0x6003F5E")]
	[Address(RVA = "0xFD8DF0", Offset = "0xFD75F0", Length = "0x37C")]
	protected void Finish(uint errorCode = 0u, string errorMsg = null)
	{
	}

	[Token(Token = "0x6003F5F")]
	[Address(RVA = "0xFD8DC0", Offset = "0xFD75C0", Length = "0x2E")]
	public int CompareTo(IIAPPipelineStage otherHandler)
	{
		return default(int);
	}

	[Token(Token = "0x6003F60")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	protected IIAPPipelineStage()
	{
	}
}
