namespace System.Security;

[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public interface IPermission : ISecurityEncodable
{

	public void Demand() { }

	public bool IsSubsetOf(IPermission target) { }

}

