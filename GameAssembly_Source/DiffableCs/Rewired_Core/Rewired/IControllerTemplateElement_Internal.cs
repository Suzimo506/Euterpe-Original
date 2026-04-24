namespace Rewired;

[CustomClassObfuscation]
[CustomObfuscation]
internal interface IControllerTemplateElement_Internal
{

	public int elementCount
	{
		 get { } //Length: 0
	}

	public IControllerTemplate parent
	{
		 get { } //Length: 0
	}

	public int get_elementCount() { }

	public IControllerTemplate get_parent() { }

	public IControllerTemplateElement GetElement(int index) { }

	public int GetElementTargets(ControllerElementTarget find, ref IList<ControllerTemplateElementTarget>& list) { }

}

