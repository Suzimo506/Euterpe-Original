using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200024F")]
public class IRailScreenshotImpl : RailObject, IRailScreenshot, IRailComponent
{
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	[Token(Token = "0x60028FE")]
	internal IRailScreenshotImpl(IntPtr cPtr)
	{
	}

	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	[Token(Token = "0x60028FF")]
	~IRailScreenshotImpl()
	{
	}

	[Token(Token = "0x6002900")]
	[Address(RVA = "0x36E1B0", Offset = "0x36C9B0", Length = "0xE0")]
	public virtual bool SetLocation(string location)
	{
		return default(bool);
	}

	[Address(RVA = "0x36E290", Offset = "0x36CA90", Length = "0x187")]
	[Token(Token = "0x6002901")]
	public virtual bool SetUsers(List<RailID> users)
	{
		return default(bool);
	}

	[Token(Token = "0x6002902")]
	[Address(RVA = "0x36DE60", Offset = "0x36C660", Length = "0x187")]
	public virtual bool AssociatePublishedFiles(List<SpaceWorkID> work_files)
	{
		return default(bool);
	}

	[Address(RVA = "0x36DFF0", Offset = "0x36C7F0", Length = "0x100")]
	[Token(Token = "0x6002903")]
	public virtual RailResult AsyncPublishScreenshot(string work_name, string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x36E0F0", Offset = "0x36C8F0", Length = "0x55")]
	[Token(Token = "0x6002904")]
	public virtual ulong GetComponentVersion()
	{
		return default(ulong);
	}

	[Address(RVA = "0x36E150", Offset = "0x36C950", Length = "0x55")]
	[Token(Token = "0x6002905")]
	public virtual void Release()
	{
	}
}
