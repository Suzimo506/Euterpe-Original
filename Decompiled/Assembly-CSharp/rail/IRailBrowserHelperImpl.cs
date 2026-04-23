using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000231")]
public class IRailBrowserHelperImpl : RailObject, IRailBrowserHelper
{
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	[Token(Token = "0x600275E")]
	internal IRailBrowserHelperImpl(IntPtr cPtr)
	{
	}

	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	[Token(Token = "0x600275F")]
	~IRailBrowserHelperImpl()
	{
	}

	[Address(RVA = "0xD22270", Offset = "0xD20A70", Length = "0x192")]
	[Token(Token = "0x6002760")]
	public virtual IRailBrowser AsyncCreateBrowser(string url, uint window_width, uint window_height, string user_data, CreateBrowserOptions options, out RailResult result)
	{
		System.Runtime.CompilerServices.Unsafe.As<RailResult, @null>(ref result) = null;
		return null;
	}

	[Token(Token = "0x6002761")]
	[Address(RVA = "0xD220E0", Offset = "0xD208E0", Length = "0x186")]
	public virtual IRailBrowser AsyncCreateBrowser(string url, uint window_width, uint window_height, string user_data, CreateBrowserOptions options)
	{
		return null;
	}

	[Address(RVA = "0xD22010", Offset = "0xD20810", Length = "0xCE")]
	[Token(Token = "0x6002762")]
	public virtual IRailBrowser AsyncCreateBrowser(string url, uint window_width, uint window_height, string user_data)
	{
		return null;
	}

	[Token(Token = "0x6002763")]
	[Address(RVA = "0xD224D0", Offset = "0xD20CD0", Length = "0x17B")]
	public virtual IRailBrowserRender CreateCustomerDrawBrowser(string url, string user_data, CreateCustomerDrawBrowserOptions options, out RailResult result)
	{
		System.Runtime.CompilerServices.Unsafe.As<RailResult, @null>(ref result) = null;
		return null;
	}

	[Token(Token = "0x6002764")]
	[Address(RVA = "0xD22650", Offset = "0xD20E50", Length = "0x172")]
	public virtual IRailBrowserRender CreateCustomerDrawBrowser(string url, string user_data, CreateCustomerDrawBrowserOptions options)
	{
		return null;
	}

	[Token(Token = "0x6002765")]
	[Address(RVA = "0xD22410", Offset = "0xD20C10", Length = "0xBC")]
	public virtual IRailBrowserRender CreateCustomerDrawBrowser(string url, string user_data)
	{
		return null;
	}

	[Address(RVA = "0xD227D0", Offset = "0xD20FD0", Length = "0x77")]
	[Token(Token = "0x6002766")]
	public virtual RailResult NavigateWebPage(string url, bool display_in_new_tab)
	{
		return default(RailResult);
	}
}
