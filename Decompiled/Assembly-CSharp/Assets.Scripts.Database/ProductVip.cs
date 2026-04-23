using System;
using Cpp2ILInjected;
using Newtonsoft.Json;

namespace Assets.Scripts.Database;

[Serializable]
[Token(Token = "0x2000801")]
public struct ProductVip
{
	[Token(Token = "0x40029AC")]
	[FieldOffset(Offset = "0x0")]
	public string uid;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40029AD")]
	public string title;

	[Token(Token = "0x40029AE")]
	[FieldOffset(Offset = "0x10")]
	public string[] pay_product_id;

	[Token(Token = "0x40029AF")]
	[FieldOffset(Offset = "0x18")]
	public DateTime devStartTimeUtc;

	[Token(Token = "0x40029B0")]
	[FieldOffset(Offset = "0x20")]
	public DateTime startTimeUtc;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40029B1")]
	public DateTime endTimeUtc;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40029B2")]
	public DateTime unlistedTimeUtc;

	[Token(Token = "0x40029B3")]
	[FieldOffset(Offset = "0x38")]
	public int expirationTimeDay;

	[Token(Token = "0x40029B4")]
	[FieldOffset(Offset = "0x3C")]
	public int expirationTimeHour;

	[Token(Token = "0x40029B5")]
	[FieldOffset(Offset = "0x40")]
	public int expirationTimeMinute;

	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40029B6")]
	public int expirationTimeSecond;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40029B7")]
	public string price_cny;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40029B8")]
	public string startVersion;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40029B9")]
	public string endVersion;

	[JsonIgnore]
	[Token(Token = "0x1700073F")]
	public TimeSpan expirationTime
	{
		[Address(RVA = "0x4A4010", Offset = "0x4A2810", Length = "0x36")]
		[Token(Token = "0x600488A")]
		get
		{
			return default(TimeSpan);
		}
	}
}
