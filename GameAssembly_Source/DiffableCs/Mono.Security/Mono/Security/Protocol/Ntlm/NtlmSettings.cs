namespace Mono.Security.Protocol.Ntlm;

public static class NtlmSettings
{
	private static NtlmAuthLevel defaultAuthLevel; //Field offset: 0x2C927B4

	public static NtlmAuthLevel DefaultAuthLevel
	{
		 get { } //Length: 85
	}

	private static NtlmSettings() { }

	public static NtlmAuthLevel get_DefaultAuthLevel() { }

}

