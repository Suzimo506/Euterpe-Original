using System;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200025A")]
public class IRailUtilsImpl : RailObject, IRailUtils
{
	[Token(Token = "0x600299D")]
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	internal IRailUtilsImpl(IntPtr cPtr)
	{
	}

	[Token(Token = "0x600299E")]
	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	~IRailUtilsImpl()
	{
	}

	[Token(Token = "0x600299F")]
	[Address(RVA = "0x379D10", Offset = "0x378510", Length = "0xB5")]
	public virtual uint GetTimeCountSinceGameLaunch()
	{
		return default(uint);
	}

	[Address(RVA = "0x379C50", Offset = "0x378450", Length = "0xB5")]
	[Token(Token = "0x60029A0")]
	public virtual uint GetTimeCountSinceComputerLaunch()
	{
		return default(uint);
	}

	[Address(RVA = "0x379DD0", Offset = "0x3785D0", Length = "0xB5")]
	[Token(Token = "0x60029A1")]
	public virtual uint GetTimeFromServer()
	{
		return default(uint);
	}

	[Address(RVA = "0x379040", Offset = "0x377840", Length = "0x126")]
	[Token(Token = "0x60029A2")]
	public virtual RailResult AsyncGetImageData(string image_path, uint scale_to_width, uint scale_to_height, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60029A3")]
	[Address(RVA = "0x3795D0", Offset = "0x377DD0", Length = "0x1DD")]
	public virtual void GetErrorString(RailResult result, out string error_string)
	{
		error_string = null;
	}

	[Token(Token = "0x60029A4")]
	[Address(RVA = "0x379170", Offset = "0x377970", Length = "0x268")]
	public virtual RailResult DirtyWordsFilter(string words, bool replace_sensitive, RailDirtyWordsCheckResult check_result)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60029A5")]
	[Address(RVA = "0x379B90", Offset = "0x378390", Length = "0xB5")]
	public virtual EnumRailPlatformType GetRailPlatformType()
	{
		return default(EnumRailPlatformType);
	}

	[Address(RVA = "0x3797B0", Offset = "0x377FB0", Length = "0x1F0")]
	[Token(Token = "0x60029A6")]
	public virtual RailResult GetLaunchAppParameters(EnumRailLaunchAppType app_type, out string parameter)
	{
		parameter = null;
		return default(RailResult);
	}

	[Token(Token = "0x60029A7")]
	[Address(RVA = "0x3799B0", Offset = "0x3781B0", Length = "0x1DB")]
	public virtual RailResult GetPlatformLanguageCode(out string language_code)
	{
		language_code = null;
		return default(RailResult);
	}

	[Token(Token = "0x60029A8")]
	[Address(RVA = "0x379E90", Offset = "0x378690", Length = "0xCE")]
	public virtual RailResult SetWarningMessageCallback(RailWarningMessageCallbackFunction callback)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60029A9")]
	[Address(RVA = "0x3793E0", Offset = "0x377BE0", Length = "0x1E9")]
	public virtual RailResult GetCountryCodeOfCurrentLoggedInIP(out string country_code)
	{
		country_code = null;
		return default(RailResult);
	}
}
