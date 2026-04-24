namespace System.ComponentModel.Design;

[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public interface IComponentChangeService
{

	public void OnComponentChanged(object component, MemberDescriptor member, object oldValue, object newValue) { }

	public void OnComponentChanging(object component, MemberDescriptor member) { }

}

