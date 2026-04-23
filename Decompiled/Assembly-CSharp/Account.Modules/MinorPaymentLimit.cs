using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using PeroPeroGames.GlobalDefines;

namespace Account.Modules;

[Token(Token = "0x2000567")]
public class MinorPaymentLimit
{
	[Token(Token = "0x2000B8E")]
	public enum PaymentTipType
	{
		[Token(Token = "0x4003A9F")]
		PaymentLimit,
		[Token(Token = "0x4003AA0")]
		PaymentPrompt
	}

	[Token(Token = "0x2000B8F")]
	private struct LimitSetting
	{
		[Token(Token = "0x4003AA1")]
		[FieldOffset(Offset = "0x0")]
		public AgeRange ageRange;

		[Token(Token = "0x4003AA2")]
		[FieldOffset(Offset = "0x4")]
		public int singleAmount;

		[Token(Token = "0x4003AA3")]
		[FieldOffset(Offset = "0x8")]
		public int allAmount;

		[Token(Token = "0x6005ECB")]
		[Address(RVA = "0x48D430", Offset = "0x48BC30", Length = "0xB")]
		public LimitSetting(AgeRange ageRange, int singleAmount, int allAmount)
		{
		}
	}

	[Token(Token = "0x4001FE7")]
	private const string get_month_payment_url = "purchase/get_month_paid_amount";

	[Token(Token = "0x4001FE8")]
	private static readonly List<LimitSetting> minor_payment_limit_settings;

	[Token(Token = "0x6003814")]
	[Address(RVA = "0x77AC40", Offset = "0x779440", Length = "0x238")]
	public void ShowPaymentPromptWindow(PaymentTipType paymentType, float payValue = 0f, Action confirmCallback = null, Action cancelCallback = null, Action shutCallback = null)
	{
	}

	[Token(Token = "0x6003815")]
	[Address(RVA = "0x77AAF0", Offset = "0x7792F0", Length = "0x145")]
	public void RequestPayResult(Action<float> successCallback, Action<long> failCallback = null)
	{
	}

	[Token(Token = "0x6003816")]
	[Address(RVA = "0x77A890", Offset = "0x779090", Length = "0x253")]
	public bool IsPaymentLimited(int price, int reqAllAmount = 0)
	{
		return default(bool);
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003817")]
	public MinorPaymentLimit()
	{
	}
}
