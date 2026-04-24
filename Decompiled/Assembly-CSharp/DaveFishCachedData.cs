using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x20001A2")]
public class DaveFishCachedData
{
	[Token(Token = "0x4000A46")]
	[FieldOffset(Offset = "0x10")]
	public int fishUid;

	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000A47")]
	public int fishCount;

	[Token(Token = "0x6000BDB")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public DaveFishCachedData()
	{
	}
}
