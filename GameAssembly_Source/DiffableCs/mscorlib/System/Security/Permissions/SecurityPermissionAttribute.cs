namespace System.Security.Permissions;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Obsolete]
public sealed class SecurityPermissionAttribute : CodeAccessSecurityAttribute
{
	private SecurityPermissionFlag m_Flags; //Field offset: 0x10

	public bool SkipVerification
	{
		 set { } //Length: 25
	}

	public void set_SkipVerification(bool value) { }

}

