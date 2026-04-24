using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007B7")]
public class DiscoActivityInfo : BaseDataObject
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40028AF")]
	public int activityId;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40028B0")]
	public string logo;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40028B1")]
	public string description;

	[Token(Token = "0x40028B2")]
	[FieldOffset(Offset = "0x38")]
	public string url;

	[Token(Token = "0x40028B3")]
	[FieldOffset(Offset = "0x40")]
	public DateTime endTime;

	[Token(Token = "0x40028B4")]
	[FieldOffset(Offset = "0x48")]
	public bool isOnlyChinaShow;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40028B5")]
	public List<string> uids;

	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	[Token(Token = "0x600474E")]
	public DiscoActivityInfo()
	{
	}
}
