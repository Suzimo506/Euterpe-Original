namespace System.ComponentModel;

[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public interface ITypeDescriptorContext : IServiceProvider
{

	public IContainer Container
	{
		 get { } //Length: 0
	}

	public IContainer get_Container() { }

}

