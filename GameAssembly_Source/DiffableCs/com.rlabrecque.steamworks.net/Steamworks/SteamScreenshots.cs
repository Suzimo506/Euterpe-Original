namespace Steamworks;

public static class SteamScreenshots
{

	public static ScreenshotHandle AddScreenshotToLibrary(string pchFilename, string pchThumbnailFilename, int nWidth, int nHeight) { }

	public static ScreenshotHandle AddVRScreenshotToLibrary(EVRScreenshotType eType, string pchFilename, string pchVRFilename) { }

	public static void HookScreenshots(bool bHook) { }

	public static bool IsScreenshotsHooked() { }

	public static bool SetLocation(ScreenshotHandle hScreenshot, string pchLocation) { }

	public static bool TagPublishedFile(ScreenshotHandle hScreenshot, PublishedFileId_t unPublishedFileID) { }

	public static bool TagUser(ScreenshotHandle hScreenshot, CSteamID steamID) { }

	public static void TriggerScreenshot() { }

	public static ScreenshotHandle WriteScreenshot(Byte[] pubRGB, uint cubRGB, int nWidth, int nHeight) { }

}

