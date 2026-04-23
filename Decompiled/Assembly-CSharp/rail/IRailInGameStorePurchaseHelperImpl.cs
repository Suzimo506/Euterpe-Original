using System;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000245")]
public class IRailInGameStorePurchaseHelperImpl : RailObject, IRailInGameStorePurchaseHelper
{
	[Token(Token = "0x600286E")]
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	internal IRailInGameStorePurchaseHelperImpl(IntPtr cPtr)
	{
	}

	[Token(Token = "0x600286F")]
	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	~IRailInGameStorePurchaseHelperImpl()
	{
	}

	[Address(RVA = "0xD2D210", Offset = "0xD2BA10", Length = "0x75")]
	[Token(Token = "0x6002870")]
	public virtual RailResult AsyncShowPaymentWindow(string order_id, string user_data)
	{
		return default(RailResult);
	}
}
