namespace System.ComponentModel.Design;

[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public interface IDesignerHost : IServiceProvider
{

	public IDesigner GetDesigner(IComponent component) { }

}

