namespace NexPlugin.AuthenticationErrorCode;

public enum ErrorCode
{
	NASAuthenticateError = 1,
	TokenParseError = 2,
	HttpConnectionError = 3,
	HttpDNSError = 4,
	HttpGetProxySetting = 5,
	TokenExpired = 6,
	ValidationFailed = 7,
	InvalidParam = 8,
	PrincipalIdUnmatched = 9,
	MoveCountUnmatch = 10,
	UnderMaintenance = 11,
	UnsupportedVersion = 12,
	ServerVersionIsOld = 13,
	Unknown = 14,
	ClientVersionIsOld = 15,
	AccountLibraryError = 16,
	ServiceNoLongerAvailable = 17,
	UnknownApplication = 18,
	ApplicationVersionIsOld = 19,
	OutOfService = 20,
	NetworkServiceLicenseRequired = 21,
	NetworkServiceLicenseSystemError = 22,
	NetworkServiceLicenseError3 = 23,
	NetworkServiceLicenseError4 = 24,
}

