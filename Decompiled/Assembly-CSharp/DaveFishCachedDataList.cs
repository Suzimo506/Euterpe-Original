using System;
using System.Collections.Generic;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x20001A3")]
public class DaveFishCachedDataList
{
	[Token(Token = "0x4000A48")]
	[FieldOffset(Offset = "0x10")]
	public List<DaveFishCachedData> fishDataList;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6000BDC")]
	public DaveFishCachedDataList()
	{
	}
}
