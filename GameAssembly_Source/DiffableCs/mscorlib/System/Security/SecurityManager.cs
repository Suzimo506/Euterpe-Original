namespace System.Security;

[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public static class SecurityManager
{

	[Obsolete]
	public static bool SecurityEnabled
	{
		 get { } //Length: 3
	}

	internal static bool CheckElevatedPermissions() { }

	internal static void EnsureElevatedPermissions() { }

	public static bool get_SecurityEnabled() { }

}

