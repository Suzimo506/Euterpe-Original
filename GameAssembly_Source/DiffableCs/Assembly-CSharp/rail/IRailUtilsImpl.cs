namespace rail;

public class IRailUtilsImpl : RailObject, IRailUtils
{

	internal IRailUtilsImpl(IntPtr cPtr) { }

	public override RailResult AsyncGetImageData(string image_path, uint scale_to_width, uint scale_to_height, string user_data) { }

	public override RailResult DirtyWordsFilter(string words, bool replace_sensitive, RailDirtyWordsCheckResult check_result) { }

	protected virtual void Finalize() { }

	public override RailResult GetCountryCodeOfCurrentLoggedInIP(out string country_code) { }

	public override void GetErrorString(RailResult result, out string error_string) { }

	public override RailResult GetLaunchAppParameters(EnumRailLaunchAppType app_type, out string parameter) { }

	public override RailResult GetPlatformLanguageCode(out string language_code) { }

	public override EnumRailPlatformType GetRailPlatformType() { }

	public override uint GetTimeCountSinceComputerLaunch() { }

	public override uint GetTimeCountSinceGameLaunch() { }

	public override uint GetTimeFromServer() { }

	public override RailResult SetWarningMessageCallback(RailWarningMessageCallbackFunction callback) { }

}

