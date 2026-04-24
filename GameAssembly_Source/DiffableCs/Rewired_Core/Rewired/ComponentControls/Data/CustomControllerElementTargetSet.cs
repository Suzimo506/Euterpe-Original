namespace Rewired.ComponentControls.Data;

[CustomClassObfuscation]
[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public abstract class CustomControllerElementTargetSet
{

	internal abstract CustomControllerElementTarget Item
	{
		internal get { } //Length: 0
	}

	internal abstract int targetCount
	{
		internal get { } //Length: 0
	}

	protected CustomControllerElementTargetSet() { }

	internal abstract void ClearElementCaches() { }

	internal abstract CustomControllerElementTarget get_Item(int index) { }

	internal abstract int get_targetCount() { }

}

