//Type is in global namespace

[Extension]
public static class AndroidRuntimePermissions
{
	internal enum Permission
	{
		Denied = 0,
		Granted = 1,
		ShouldAsk = 2,
	}


	public static Permission[] CheckPermissions(String[] permissions) { }

	private static Permission[] GetDummyResult(String[] permissions) { }

	public static void OpenSettings() { }

	public static Permission RequestPermission(string permission) { }

	private static void ValidateArgument(String[] permissions) { }

}

