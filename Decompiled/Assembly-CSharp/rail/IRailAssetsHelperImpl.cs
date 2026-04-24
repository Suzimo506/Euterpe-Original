using System;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200022F")]
public class IRailAssetsHelperImpl : RailObject, IRailAssetsHelper
{
	[Token(Token = "0x600274E")]
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	internal IRailAssetsHelperImpl(IntPtr cPtr)
	{
	}

	[Token(Token = "0x600274F")]
	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	~IRailAssetsHelperImpl()
	{
	}

	[Token(Token = "0x6002750")]
	[Address(RVA = "0xD20CB0", Offset = "0xD1F4B0", Length = "0xA0")]
	public virtual IRailAssets OpenAssets()
	{
		return null;
	}

	[Address(RVA = "0xD20D50", Offset = "0xD1F550", Length = "0xA0")]
	[Token(Token = "0x6002751")]
	public virtual IRailAssets OpenGameServerAssets()
	{
		return null;
	}
}
