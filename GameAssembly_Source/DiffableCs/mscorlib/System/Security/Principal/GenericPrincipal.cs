namespace System.Security.Principal;

[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class GenericPrincipal : ClaimsPrincipal
{
	private IIdentity m_identity; //Field offset: 0x28
	private String[] m_roles; //Field offset: 0x30

	public GenericPrincipal(IIdentity identity, String[] roles) { }

}

