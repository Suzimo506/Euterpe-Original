using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000251")]
public class IRailSmallObjectServiceHelperImpl : RailObject, IRailSmallObjectServiceHelper
{
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	[Token(Token = "0x600290D")]
	internal IRailSmallObjectServiceHelperImpl(IntPtr cPtr)
	{
	}

	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	[Token(Token = "0x600290E")]
	~IRailSmallObjectServiceHelperImpl()
	{
	}

	[Address(RVA = "0x36E420", Offset = "0x36CC20", Length = "0x25D")]
	[Token(Token = "0x600290F")]
	public virtual RailResult AsyncDownloadObjects(List<uint> indexes, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002910")]
	[Address(RVA = "0x36E760", Offset = "0x36CF60", Length = "0x1F0")]
	public virtual RailResult GetObjectContent(uint index, out string content)
	{
		content = null;
		return default(RailResult);
	}

	[Token(Token = "0x6002911")]
	[Address(RVA = "0x36E680", Offset = "0x36CE80", Length = "0xDD")]
	public virtual RailResult AsyncQueryObjectState(string user_data)
	{
		return default(RailResult);
	}
}
