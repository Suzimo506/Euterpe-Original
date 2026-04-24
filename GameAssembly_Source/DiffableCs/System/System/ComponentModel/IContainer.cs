namespace System.ComponentModel;

[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public interface IContainer : IDisposable
{

	public ComponentCollection Components
	{
		 get { } //Length: 0
	}

	public ComponentCollection get_Components() { }

	public void Remove(IComponent component) { }

}

