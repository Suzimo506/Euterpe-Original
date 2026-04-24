namespace System.Security;

[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
[MonoTODO]
public abstract class CodeAccessPermission : IPermission, ISecurityEncodable
{

	protected CodeAccessPermission() { }

	internal static PermissionState CheckPermissionState(PermissionState state, bool allowUnrestricted) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override void Demand() { }

	[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual bool Equals(object obj) { }

	[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public virtual int GetHashCode() { }

	public abstract bool IsSubsetOf(IPermission target) { }

	private override void System.Security.IPermission.Demand() { }

	public virtual string ToString() { }

	public abstract SecurityElement ToXml() { }

}

