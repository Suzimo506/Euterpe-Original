using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003CA")]
public interface IRailUtils
{
	[Token(Token = "0x6002F77")]
	[Address(RVA = "0x0", Length = "0x0")]
	uint GetTimeCountSinceGameLaunch();

	[Token(Token = "0x6002F78")]
	[Address(RVA = "0x0", Length = "0x0")]
	uint GetTimeCountSinceComputerLaunch();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F79")]
	uint GetTimeFromServer();

	[Token(Token = "0x6002F7A")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncGetImageData(string image_path, uint scale_to_width, uint scale_to_height, string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F7B")]
	void GetErrorString(RailResult result, out string error_string);

	[Token(Token = "0x6002F7C")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult DirtyWordsFilter(string words, bool replace_sensitive, RailDirtyWordsCheckResult check_result);

	[Token(Token = "0x6002F7D")]
	[Address(RVA = "0x0", Length = "0x0")]
	EnumRailPlatformType GetRailPlatformType();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F7E")]
	RailResult GetLaunchAppParameters(EnumRailLaunchAppType app_type, out string parameter);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F7F")]
	RailResult GetPlatformLanguageCode(out string language_code);

	[Token(Token = "0x6002F80")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult SetWarningMessageCallback(RailWarningMessageCallbackFunction callback);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F81")]
	RailResult GetCountryCodeOfCurrentLoggedInIP(out string country_code);
}
