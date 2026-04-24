namespace rail;

public interface IRailUtils
{

	public RailResult AsyncGetImageData(string image_path, uint scale_to_width, uint scale_to_height, string user_data) { }

	public RailResult DirtyWordsFilter(string words, bool replace_sensitive, RailDirtyWordsCheckResult check_result) { }

	public RailResult GetCountryCodeOfCurrentLoggedInIP(out string country_code) { }

	public void GetErrorString(RailResult result, out string error_string) { }

	public RailResult GetLaunchAppParameters(EnumRailLaunchAppType app_type, out string parameter) { }

	public RailResult GetPlatformLanguageCode(out string language_code) { }

	public EnumRailPlatformType GetRailPlatformType() { }

	public uint GetTimeCountSinceComputerLaunch() { }

	public uint GetTimeCountSinceGameLaunch() { }

	public uint GetTimeFromServer() { }

	public RailResult SetWarningMessageCallback(RailWarningMessageCallbackFunction callback) { }

}

