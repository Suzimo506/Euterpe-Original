using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq;

namespace Assets.Scripts.Purchase;

[Token(Token = "0x20006B8")]
public class PlayerInfoDiscountCollector : IDiscountCollector
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400242B")]
	private readonly string m_TargetProductId;

	[Token(Token = "0x400242C")]
	private const string created_time_key = "created_at";

	[Token(Token = "0x400242D")]
	[FieldOffset(Offset = "0x28")]
	private readonly TimeSpan newPlayerDiscountTimeSpan;

	[Token(Token = "0x400242E")]
	[FieldOffset(Offset = "0x30")]
	private readonly int newPlayerDiscount;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400242F")]
	private readonly TimeSpan regressionPlayerTimeSpan;

	[Token(Token = "0x4002430")]
	[FieldOffset(Offset = "0x40")]
	private readonly int regressionPlayerDiscount;

	[Token(Token = "0x4002431")]
	[FieldOffset(Offset = "0x48")]
	private List<DiscountInfo> m_ListCached;

	[Token(Token = "0x4002432")]
	[FieldOffset(Offset = "0x50")]
	private bool m_FlagGetProfile;

	[Token(Token = "0x4002433")]
	[FieldOffset(Offset = "0x51")]
	private bool m_FlagGetregression;

	[Token(Token = "0x6003EFF")]
	[Address(RVA = "0xFE0C70", Offset = "0xFDF470", Length = "0xA4")]
	public override void Collect()
	{
	}

	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4CBE0", Offset = "0x4BFE0")]
	[Token(Token = "0x6003F00")]
	[Address(RVA = "0xFE0D20", Offset = "0xFDF520", Length = "0x65")]
	private IEnumerator<float> ECollect()
	{
		return null;
	}

	[Token(Token = "0x6003F01")]
	[Address(RVA = "0xFE0D90", Offset = "0xFDF590", Length = "0x7ED")]
	private void OnGetProfileSuccess(JObject result)
	{
	}

	[Address(RVA = "0xFE1580", Offset = "0xFDFD80", Length = "0xA86")]
	[Token(Token = "0x6003F02")]
	private void OnGetReturnInfoFromPeroServer(JObject result)
	{
	}

	[Token(Token = "0x6003F03")]
	[Address(RVA = "0xFE2170", Offset = "0xFE0970", Length = "0xB4")]
	public PlayerInfoDiscountCollector()
	{
	}
}
