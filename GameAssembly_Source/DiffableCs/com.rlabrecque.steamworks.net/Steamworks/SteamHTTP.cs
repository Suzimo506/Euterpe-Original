namespace Steamworks;

public static class SteamHTTP
{

	public static HTTPCookieContainerHandle CreateCookieContainer(bool bAllowResponsesToModify) { }

	public static HTTPRequestHandle CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, string pchAbsoluteURL) { }

	public static bool DeferHTTPRequest(HTTPRequestHandle hRequest) { }

	public static bool GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut) { }

	public static bool GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, out bool pbWasTimedOut) { }

	public static bool GetHTTPResponseBodyData(HTTPRequestHandle hRequest, Byte[] pBodyDataBuffer, uint unBufferSize) { }

	public static bool GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize) { }

	public static bool GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, string pchHeaderName, out uint unResponseHeaderSize) { }

	public static bool GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, Byte[] pHeaderValueBuffer, uint unBufferSize) { }

	public static bool GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, Byte[] pBodyDataBuffer, uint unBufferSize) { }

	public static bool PrioritizeHTTPRequest(HTTPRequestHandle hRequest) { }

	public static bool ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer) { }

	public static bool ReleaseHTTPRequest(HTTPRequestHandle hRequest) { }

	public static bool SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle) { }

	public static bool SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle) { }

	public static bool SetCookie(HTTPCookieContainerHandle hCookieContainer, string pchHost, string pchUrl, string pchCookie) { }

	public static bool SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds) { }

	public static bool SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue) { }

	public static bool SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer) { }

	public static bool SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, string pchParamName, string pchParamValue) { }

	public static bool SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, string pchHeaderValue) { }

	public static bool SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds) { }

	public static bool SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, string pchContentType, Byte[] pubBody, uint unBodyLen) { }

	public static bool SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate) { }

	public static bool SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, string pchUserAgentInfo) { }

}

