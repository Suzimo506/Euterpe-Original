using System;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000230")]
public class IRailBrowserImpl : RailObject, IRailBrowser, IRailComponent
{
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	[Token(Token = "0x6002752")]
	internal IRailBrowserImpl(IntPtr cPtr)
	{
	}

	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	[Token(Token = "0x6002753")]
	~IRailBrowserImpl()
	{
	}

	[Address(RVA = "0xD229F0", Offset = "0xD211F0", Length = "0x137")]
	[Token(Token = "0x6002754")]
	public virtual bool GetCurrentUrl(out string url)
	{
		url = null;
		return default(bool);
	}

	[Token(Token = "0x6002755")]
	[Address(RVA = "0xD22B90", Offset = "0xD21390", Length = "0x65")]
	public virtual bool ReloadWithUrl(string new_url)
	{
		return default(bool);
	}

	[Token(Token = "0x6002756")]
	[Address(RVA = "0xD22C00", Offset = "0xD21400", Length = "0x55")]
	public virtual bool ReloadWithUrl()
	{
		return default(bool);
	}

	[Address(RVA = "0xD22CC0", Offset = "0xD214C0", Length = "0x55")]
	[Token(Token = "0x6002757")]
	public virtual void StopLoad()
	{
	}

	[Address(RVA = "0xD22850", Offset = "0xD21050", Length = "0x65")]
	[Token(Token = "0x6002758")]
	public virtual bool AddJavascriptEventListener(string event_name)
	{
		return default(bool);
	}

	[Token(Token = "0x6002759")]
	[Address(RVA = "0xD22C60", Offset = "0xD21460", Length = "0x55")]
	public virtual bool RemoveAllJavascriptEventListener()
	{
		return default(bool);
	}

	[Address(RVA = "0xD228C0", Offset = "0xD210C0", Length = "0x66")]
	[Token(Token = "0x600275A")]
	public virtual void AllowNavigateNewPage(bool allow)
	{
	}

	[Address(RVA = "0xD22930", Offset = "0xD21130", Length = "0x55")]
	[Token(Token = "0x600275B")]
	public virtual void Close()
	{
	}

	[Token(Token = "0x600275C")]
	[Address(RVA = "0xD22990", Offset = "0xD21190", Length = "0x55")]
	public virtual ulong GetComponentVersion()
	{
		return default(ulong);
	}

	[Address(RVA = "0xD22B30", Offset = "0xD21330", Length = "0x55")]
	[Token(Token = "0x600275D")]
	public virtual void Release()
	{
	}
}
